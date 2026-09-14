using mage.Actions;
using mage.Actions.PaletteEditor;
using mage.Controls;
using mage.Dialogs;
using mage.Theming;
using mage.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace mage.Editors.NewEditors;

public partial class FormPaletteNew : Form
{
    public static void OpenPaletteEditor(bool tileset, byte value)
    {
        if (Program.ExperimentalFeaturesEnabled) new FormPaletteNew(tileset, value).Show();
        else new FormPalette(FormMain.Instance, tileset, value).Show();
    }
    public static void OpenPaletteEditor(int offset, int rows)
    {
        if (Program.ExperimentalFeaturesEnabled) new FormPaletteNew(offset, rows).Show();
        else new FormPalette(FormMain.Instance, offset, rows).Show();
    }

    private enum Tool
    {
        Select,
        Pen,
        Eyedropper
    }

    #region Fields
    // State
    private bool init = false;
    private bool ignoreColorSwatchUpdate = false;
    private Palette palette;
    private Status status;
    private GenericUndoRedo UndoRedo = new();
    private EditorGridActionGroup? latestActionGroup = null;
    private Point? SelectionPivot = null;
    private Point? MovingPivot = null;
    private bool ReachedMovingThreshold = false;
    private int MovingThreshold
    {
        get
        {
            if (tileDisplay_pal.Zoom == 4) return 2;
            if (tileDisplay_pal.Zoom == 3) return 4;
            if (tileDisplay_pal.Zoom == 2) return 5;
            if (tileDisplay_pal.Zoom == 1) return 6;
            return 7;
        }
    }

    private const int CellSize = 16;
    private const string ClipboardFormat = "MagePaletteEditor_Colors";

    // Colors
    private ushort colorPrimary = 0;
    private ushort colorSecondary = ushort.MaxValue;

    // Drawables
    private static float[] DashPattern = new float[] { 2, 3 };
    private Pen DottedPenWhite = new Pen(Color.White, 1) { DashPattern = DashPattern };
    private Pen DottedPenBlack = new Pen(Color.Black, 1) { DashPattern = DashPattern, DashOffset = 2 };
    private Drawable Selection;
    private int SelectionDashOffset
    {
        get => (int)DottedPenWhite.DashOffset;
        set
        {
            DottedPenWhite.DashOffset = value;
            DottedPenBlack.DashOffset = value + 2;
        }
    }
    private bool SelectionVisible
    {
        get => Selection.Visible;
        set
        {
            if (Selection.Visible == value) return;
            Selection.Visible = value;

            button_copy.Enabled = value;
            button_transform.Enabled = value;
            button_cut.Enabled = value;
        }
    }
    private Rectangle SelectionCells => new(Selection.X / CellSize, Selection.Y / CellSize, Selection.Width / CellSize, Selection.Height / CellSize);

    new private Drawable Cursor;
    private Pen CursorPen = new Pen(Color.Red, 1);


    // Selection
    private ushort[,]? selectedColors = null;
    private bool movingSelection = false;

    // Transformation Preview
    private ushort[,]? transformationPreview = null;
    private bool displayPreview = false;

    // Tools
    private Tool SelectedTool
    {
        get;
        set
        {
            if (field == value) return;
            field = value;

            Cursor.Visible = false;
            UntoggleAllTools();
            switch (value)
            {
                case Tool.Select:
                    button_toolSelect.Checked = true;
                    break;
                case Tool.Pen:
                    Cursor.Visible = true;
                    button_toolPen.Checked = true;
                    break;
                case Tool.Eyedropper:
                    Cursor.Visible = true;
                    button_eyeDropper.Checked = true;
                    break;
            }

            // Paste selection if still there
            if (selectedColors is not null) PasteSelectedColors();

            FinishToolAction();
        }
    } = Tool.Pen;
    #endregion

    #region Constructor
    private FormPaletteNew()
    {
        InitializeComponent();

        ThemeSwitcher.ChangeTheme(Controls, this);
        ThemeSwitcher.InjectPaintOverrides(Controls);

        textBox_hex_color.TextChanged += TextBox_hex_color_TextChanged;

        KeyPreview = true;
        tileDisplay_pal.KeyDown += FormPaletteNew_KeyDown;

        button_copy.Enabled = false;
        button_copy.Click += (_, _) => Copy();
        button_paste.Click += (_, _) => Paste();

        status = new(statusLabel_changes, button_apply);

        updateZoom(1);
        tileDisplay_pal.ShowGrid = true;

        // Intialize Drawables
        Selection = new Drawable(Rectangle.Empty, DottedPenWhite, 1) { Visible = false };
        Selection.DrawPens.Add(DottedPenBlack);
        tileDisplay_pal.AddDrawable(Selection);
        Cursor = new Drawable(Rectangle.Empty, CursorPen, 0) { Visible = false };
        tileDisplay_pal.AddDrawable(Cursor);

        Timer dashAnimationTimer = new Timer { Interval = 100 };
        dashAnimationTimer.Tick += (_, _) =>
        {
            SelectionDashOffset += 1;
            if (SelectionVisible) Selection.InvalidateDrawable(Selection);
        };
        dashAnimationTimer.Start();
    }

    public FormPaletteNew(bool tileset, byte value) : this()
    {
        if (tileset) LoadPaletteFromTileset(value);
        else LoadPaletteFromSprite(value);
    }

    public FormPaletteNew(int offset, int rows) : this()
    {
        textBox_offset.Text = Hex.ToString(offset);
        numericUpDown_rows.Value = rows;

        LoadPalette();
    }
    #endregion

    #region Generic Helpers
    private void LoadPalette()
    {
        if (!CheckUnsaved()) return;

        try
        {
            int offset = Hex.ToInt(textBox_offset.Text);
            int rows = (int)numericUpDown_rows.Value;

            palette = new Palette(ROM.Stream, offset, rows);
            DrawPalette();
            status.LoadNew();
            UndoRedo = new();
            setUndoRedoButtons();
        }
        catch (Exception ex)
        {
            MessageBox.Show("The offset entered was not valid.\n\n" + ex.GetType().ToString() + '\n'
                    + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void LoadPaletteFromTileset(byte tileset)
    {
        int headerOffset = Version.TilesetOffset + tileset * 0x14;
        int BGpaletteOffset = ROM.Stream.ReadPtr(headerOffset + 0x4);

        textBox_offset.Text = Hex.ToString(BGpaletteOffset);
        numericUpDown_rows.Value = 14;
        LoadPalette();
    }

    private void LoadPaletteFromSprite(byte sprite)
    {
        if (sprite < 0x10) { return; }

        // TODO: reuse code
        int addVal = (sprite - 0x10) * 4;

        // get gfx rows
        int numGfxRows;
        if (Version.IsMF)
        {
            int offset = Version.SpriteGfxRowsOffset + addVal;
            numGfxRows = ROM.Stream.Read16(offset) / 0x800;
        }
        else
        {
            int offset = Version.SpriteGfxOffset + addVal;
            int gfxOffset = ROM.Stream.ReadPtr(offset);
            numGfxRows = Math.Max(ROM.Stream.Read16(gfxOffset + 1) / 0x800, 1);
        }

        // get palette
        int palPtr = Version.SpritePaletteOffset + addVal;
        int palOffset = ROM.Stream.ReadPtr(palPtr);
        // code to move ends here

        textBox_offset.Text = Hex.ToString(palOffset);
        numericUpDown_rows.Value = numGfxRows;
        LoadPalette();
    }

    private void Save()
    {
        palette.Write(ROM.Stream);
        status.Save();
        FormMain.UpdateEditors();
    }

    /// <summary>
    /// Prompts the user if they want to save the current changes or cancel.
    /// </summary>
    /// <returns>False if cancelled. True for other options. Saves if yes is clicked</returns>
    private bool CheckUnsaved()
    {
        if (!status.UnsavedChanges) return true;
        DialogResult result = MessageBox.Show("Do you want to save changes to Palette?",
            "Unsaved Changes", MessageBoxButtons.YesNoCancel);
        if (result == DialogResult.Cancel) return false;
        if (result == DialogResult.Yes) Save();
        return true;
    }

    private Rectangle GetRectangleFromPoints(Point p1, Point p2)
    {
        int left = Math.Min(p1.X, p2.X);
        int top = Math.Min(p1.Y, p2.Y);
        int right = Math.Max(p1.X, p2.X) + 1;
        int bottom = Math.Max(p1.Y, p2.Y) + 1;

        const int grid = 16;
        left = MathFunctions.FloorTo(left, grid);
        top = MathFunctions.FloorTo(top, grid);
        right = MathFunctions.CeilTo(right, grid);
        bottom = MathFunctions.CeilTo(bottom, grid);

        return new Rectangle(left, top, right - left, bottom - top);
    }

    private Color Rgb5ToColor(int r, int g, int b) => PaletteColor.Rgb5ToColor(r, g, b);
    private void ColorToRgb5(Color c, out int r, out int g, out int b) => PaletteColor.ColorToRgb5(c, out r, out g, out b);
    private ushort Rgb5ToArgb(int r, int g, int b, bool transparent = false) => PaletteColor.Rgb5ToArgb(r, g, b, transparent);
    #endregion

    #region Generic Events
    private void button_load_Click(object sender, EventArgs e) => LoadPalette();

    private void button_minus_Click(object sender, EventArgs e)
    {
        textBox_offset.Text = Hex.ToString(Hex.ToInt(textBox_offset.Text) - 0x20);
        LoadPalette();
    }

    private void button_plus_Click(object sender, EventArgs e)
    {
        textBox_offset.Text = Hex.ToString(Hex.ToInt(textBox_offset.Text) + 0x20);
        LoadPalette();
    }

    private void button_apply_Click(object sender, EventArgs e) => Save();

    private void button_grid_CheckStateChanged(object sender, EventArgs e) => tileDisplay_pal.ShowGrid = button_grid.Checked;

    private void FormPaletteNew_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (CheckUnsaved()) return;
        e.Cancel = true;
    }

    private void FormPaletteNew_KeyDown(object sender, KeyEventArgs e)
    {
        switch (e.KeyCode)
        {
            case Keys.B:
                button_toolPen_Click(this, e);
                break;

            case Keys.M:
                button_toolSelect_Click(this, e);
                break;

            case Keys.T:
                if (ModifierKeys != Keys.Control) break;
                button_gradient_Click(this, e);
                break;

            case Keys.C:
                if (ModifierKeys == Keys.Control)
                {
                    Copy();
                    break;
                }
                button_eyeDropper_Click(this, e);
                break;

            case Keys.V:
                if (ModifierKeys == Keys.Control)
                {
                    Paste(true);
                    break;
                }
                break;

            case Keys.Z:
                if (ModifierKeys == (Keys.Control | Keys.Shift))
                {
                    if (!UndoRedo.CanRedo) break;
                    Redo();
                    break;
                }
                else if (ModifierKeys == Keys.Control)
                {
                    if (!UndoRedo.CanUndo) break;
                    Undo();
                    break;
                }
                break;

            case Keys.X:
                if (ModifierKeys != Keys.Control) break;
                Cut();
                break;

            case Keys.Back:
            case Keys.Delete:
                Delete();
                break;
        }
    }
    #endregion

    #region Tool Events
    private void UntoggleAllTools()
    {
        button_toolSelect.Checked = false;
        button_toolPen.Checked = false;
        button_eyeDropper.Checked = false;
    }

    private void button_toolSelect_Click(object sender, EventArgs e) => SelectedTool = Tool.Select;
    private void button_toolPen_Click(object sender, EventArgs e) => SelectedTool = Tool.Pen;
    private void button_eyeDropper_Click(object sender, EventArgs e) => SelectedTool = Tool.Eyedropper;
    #endregion

    #region Color Controls
    private void SetSelectedColors()
    {
        int r, g, b;
        ColorToRgb5(colorSwatch.PrimaryColor, out r, out g, out b);
        colorPrimary = Rgb5ToArgb(r, g, b);
        ColorToRgb5(colorSwatch.SecondaryColor, out r, out g, out b);
        colorSecondary = Rgb5ToArgb(r, g, b);
    }

    private void UpdateSelectedColor(int r, int g, int b, bool preventColorPickerUpdate = false, bool preventTextBoxUpdate = false)
    {
        init = true;

        Color current = Rgb5ToColor(r, g, b);

        colorBar_red.SetColor(r, g, b);
        colorBar_green.SetColor(r, g, b);
        colorBar_blue.SetColor(r, g, b);

        numericUpDown_red.Value = r;
        numericUpDown_green.Value = g;
        numericUpDown_blue.Value = b;

        if (!preventTextBoxUpdate) textBox_hex_color.Text = ColorOperations.ToHexString(current);
        if (!preventColorPickerUpdate) colorPicker.SetRgb5(r, g, b);

        ignoreColorSwatchUpdate = true;
        colorSwatch.PrimaryColor = current;
        ignoreColorSwatchUpdate = false;

        // Update actual color selection
        SetSelectedColors();

        init = false;
    }

    private void colorBars_ValueChanged(object sender, EventArgs e)
    {
        if (init) return;
        var bar = sender as ColorBar;
        if (bar is null) return;

        UpdateSelectedColor(bar.Red, bar.Green, bar.Blue);
    }

    private void colorPicker_ColorChanged(object sender, EventArgs e)
    {
        if (init) return;
        int red, green, blue;
        colorPicker.GetRgb5(out red, out green, out blue);
        UpdateSelectedColor(red, green, blue, true);
    }

    private void numericUpDown_rgb_ValueChanged(object sender, EventArgs e)
    {
        if (init) return;
        int r = (int)numericUpDown_red.Value;
        int g = (int)numericUpDown_green.Value;
        int b = (int)numericUpDown_blue.Value;
        UpdateSelectedColor(r, g, b);
    }

    private void TextBox_hex_color_TextChanged(object? sender, EventArgs e)
    {
        if (init) return;

        //Do a Regex check if value is actually a hex number
        string text = textBox_hex_color.Text;
        text = Regex.Match(text, @"[0-9a-fA-F]+").Value;
        if (text.Length != 6) return; //if 6 numbers are not given
        text = text.Insert(0, "#");
        Color c = ColorTranslator.FromHtml(text);

        int r, g, b;
        ColorToRgb5(c, out r, out g, out b);

        UpdateSelectedColor(r, g, b, false, true);
    }

    private void colorSwatch_ColorsChanged(object sender, EventArgs e)
    {
        if (ignoreColorSwatchUpdate) return;
        int r, g, b;
        ColorToRgb5(colorSwatch.PrimaryColor, out r, out g, out b);
        UpdateSelectedColor(r, g, b);
    }
    #endregion

    #region Palette Display
    private void DrawPalette()
    {
        Bitmap bmp = palette.Draw(16, 0, palette.Rows, noGrid: true);
        if (selectedColors is not null) DrawColorsOntoBitmap(bmp, Selection.Location, selectedColors);
        if (displayPreview && transformationPreview is not null) DrawColorsOntoBitmap(bmp, Selection.Location, transformationPreview);

        tileDisplay_pal.TileImage = bmp;
    }

    private static Color ArgbToColor(ushort val) => PaletteColor.ArgbToColor(val);

    private static void DrawColorsOntoBitmap(Bitmap dest, Point pos, ushort[,] colors)
    {
        int width = colors.GetLength(0);
        int height = colors.GetLength(1);

        using Graphics g = Graphics.FromImage(dest);
        for (int x = 0; x < width; x++)
            for (int y = 0; y < height; y++)
                using (SolidBrush sb = new(ArgbToColor(colors[x, y])))
                    g.FillRectangle(sb, new Rectangle(pos.X + x * CellSize, pos.Y + y * CellSize, CellSize, CellSize));
    }

    private bool IsInSelection(Point p)
    {
        // Return true if no selection, since everything is "in" the selection
        if (!SelectionVisible) return true;
        return Selection.Rectangle.Contains(p);
    }

    private void PenDraw(ushort color, Point location)
    {
        if (!IsInSelection(new Point(location.X * CellSize, location.Y * CellSize))) return;

        EditPalettePixelAction a = new(palette, location, color);
        a.Do();
        if (latestActionGroup is not null) latestActionGroup.AddAction(a);
        else AddAction(a);
        DrawPalette();
    }

    private void CloseActionGroup()
    {
        // Finalise Action Group
        if (latestActionGroup != null && latestActionGroup.ActionCount > 0) AddAction(latestActionGroup);
        latestActionGroup = null;
    }

    private void FinishToolAction()
    {
        // Clear variables
        SelectionPivot = null;
        MovingPivot = null;
        movingSelection = false;
        ReachedMovingThreshold = false;
    }

    private void PickColor(Point location, bool rightClick)
    {
        Color pick = palette.GetOpaqueColor(location.Y, location.X);
        int r, g, b;
        ColorToRgb5(pick, out r, out g, out b);
        if (!rightClick) UpdateSelectedColor(r, g, b);
        else
        {
            colorSwatch.SecondaryColor = pick;
            SetSelectedColors();
        }
    }

    private void tileDisplay_pal_TileMouseDown(object sender, mage.Controls.TileDisplay.TileDisplayArgs e)
    {
        if (e.TileIndexPosition.X < 0 || e.TileIndexPosition.Y < 0 || e.PixelPosition.X > tileDisplay_pal.TileImage.Width || e.PixelPosition.Y > tileDisplay_pal.TileImage.Height) return;

        bool left = e.Button == MouseButtons.Left;
        bool right = e.Button == MouseButtons.Right;
        bool alt = ModifierKeys == Keys.Alt;

        if (!left && !right) return;

        switch (SelectedTool)
        {
            case Tool.Pen:
                if (alt)
                {
                    PickColor(e.TileIndexPosition, right);
                    break;
                }

                CloseActionGroup();
                latestActionGroup = new();
                ushort color = left ? colorPrimary : colorSecondary;
                PenDraw(color, e.TileIndexPosition);
                AddRecentColor(color);
                break;

            case Tool.Select:
                SelectionPivot = e.TilePixelPosition;

                // Check if pressing in already existing selection to start a move
                if (SelectionVisible && Selection.Rectangle.Contains(e.PixelPosition))
                {
                    movingSelection = true;
                    MovingPivot = Selection.Location;
                }
                // Clicking outside of existing selection or creating new one
                else
                {
                    // Placing moved selection if moved
                    if (selectedColors is not null) PasteSelectedColors();

                    SelectionVisible = !SelectionVisible; // Deselect selection or start new
                    Point cellOrigin = new(MathFunctions.FloorTo(e.PixelPosition.X, CellSize), MathFunctions.FloorTo(e.PixelPosition.Y, CellSize));
                    Selection.Rectangle = new Rectangle(cellOrigin, new Size(CellSize, CellSize));
                }
                break;

            case Tool.Eyedropper:
                PickColor(e.TileIndexPosition, right);
                break;
        }
    }

    private void tileDisplay_pal_TileMouseMove(object sender, mage.Controls.TileDisplay.TileDisplayArgs e)
    {
        if (e.TileIndexPosition.X == Cursor.X && e.TileIndexPosition.Y == Cursor.Y) return;
        if (e.TileIndexPosition.X < 0 || e.TileIndexPosition.Y < 0 || e.PixelPosition.X > tileDisplay_pal.TileImage.Width || e.PixelPosition.Y > tileDisplay_pal.TileImage.Height) return;
        Cursor.Rectangle = new Rectangle(e.TilePixelPosition.X, e.TilePixelPosition.Y, 16, 16);

        bool left = e.Button == MouseButtons.Left;
        bool right = e.Button == MouseButtons.Right;

        if (!left && !right) return;

        switch (SelectedTool)
        {
            case Tool.Pen:
                Cursor.Visible = true;
                ushort color = left ? colorPrimary : colorSecondary;
                if (latestActionGroup is null) latestActionGroup = new();
                PenDraw(color, e.TileIndexPosition);
                break;

            case Tool.Select:
                if (SelectionPivot == null) break;

                // Moving Selection
                if (movingSelection && MovingPivot is not null)
                {
                    Size movingDiff = new(e.PixelPosition.X - SelectionPivot.Value.X, e.PixelPosition.Y - SelectionPivot.Value.Y);
                    bool pastThreshold = Math.Abs(movingDiff.Width) > MovingThreshold || Math.Abs(movingDiff.Height) > MovingThreshold;

                    if (!ReachedMovingThreshold && pastThreshold && selectedColors is null) // This should ideally only trigger once
                    {
                        ReachedMovingThreshold = true;
                        latestActionGroup = new("Move");
                        selectedColors = EjectColors(Selection.Rectangle);
                    }
                    if (ReachedMovingThreshold || selectedColors is not null)
                    {
                        ReachedMovingThreshold = true;

                        // Colors are edited in whole cells, so movement always snaps to the color grid
                        Point moved = MovingPivot.Value + movingDiff;
                        Point final = new(MathFunctions.FloorTo(moved.X, CellSize), MathFunctions.FloorTo(moved.Y, CellSize));

                        Selection.Rectangle = new Rectangle(final, Selection.Rectangle.Size);
                        DrawPalette(); // Redrawing to show Preview
                    }
                }
                // Selecting
                else
                {
                    SelectionVisible = true;
                    Selection.Rectangle = GetRectangleFromPoints(SelectionPivot.Value, e.PixelPosition);
                }
                break;
        }
    }

    private void tileDisplay_pal_TileMouseUp(object sender, mage.Controls.TileDisplay.TileDisplayArgs e)
    {
        switch (SelectedTool)
        {
            case Tool.Pen:
                CloseActionGroup();
                break;

            case Tool.Select:
                // Check if we want to deselect if clicked in selection but not moved
                if (!movingSelection || ReachedMovingThreshold) break;
                if (selectedColors is not null) PasteSelectedColors();

                SelectionVisible = false;
                break;
        }

        FinishToolAction();
    }
    #endregion

    #region Recent Colors
    private void AddRecentColor(ushort color)
    {
        Color c = PaletteColor.ArgbToColor(color);
        recentColors.AddColor(c);
    }

    private void recentColors_ColorClicked(object sender, RecentColorClickedEventArgs e)
    {
        if (e.IsLeftClick) colorSwatch.PrimaryColor = e.Color;
        else if (e.IsRightClick) colorSwatch.SecondaryColor = e.Color;
        recentColors.AddColor(e.Color);
    }
    #endregion

    #region Copy/Paste
    private class FlatUshortArray
    {
        public FlatUshortArray() { }
        public FlatUshortArray(ushort[,] input)
        {
            Rows = input.GetLength(0);
            Cols = input.GetLength(1);
            Values = new ushort[Rows * Cols];

            int index = 0;
            for (int r = 0; r < Rows; r++)
                for (int c = 0; c < Cols; c++)
                    Values[index++] = input[r, c];
        }

        public int Rows { get; set; }
        public int Cols { get; set; }
        public ushort[] Values { get; set; }

        public ushort[,] Unpack()
        {
            ushort[,] result = new ushort[Rows, Cols];
            int index = 0;

            for (int r = 0; r < Rows; r++)
                for (int c = 0; c < Cols; c++)
                    result[r, c] = Values[index++];

            return result;
        }

        public static explicit operator FlatUshortArray(ushort[,] input) => new FlatUshortArray(input);
        public static implicit operator ushort[,](FlatUshortArray input) => input.Unpack();
    }

    private ushort[,] CopyColors(Rectangle cells)
    {
        ushort[,] colors = new ushort[cells.Width, cells.Height];
        for (int x = 0; x < cells.Width; x++)
            for (int y = 0; y < cells.Height; y++)
                colors[x, y] = palette.GetARGB(cells.Y + y, cells.X + x);
        return colors;
    }

    private ushort[,] EjectColors(Rectangle region, string actionText = "Cut")
    {
        Rectangle cells = new(region.X / CellSize, region.Y / CellSize, region.Width / CellSize, region.Height / CellSize);
        EditPaletteAreaAction clearAction = new(palette, cells, Rgb5ToArgb(0, 0, 0), actionText); // Fills the region with black (placeholder for moved-out colors)
        clearAction.Do();
        if (latestActionGroup is not null) latestActionGroup.AddAction(clearAction);
        else AddAction(clearAction);
        DrawPalette();
        return clearAction.GetOldColors(); // The fill replaces the data in the action with the old colors
    }

    private EditPaletteAreaAction PasteColors(Point cellLocation, ushort[,] colors)
    {
        EditPaletteAreaAction pasteAction = new(palette, cellLocation, colors, "Paste");
        pasteAction.Do();
        if (latestActionGroup is not null) latestActionGroup.AddAction(pasteAction);
        CloseActionGroup();
        DrawPalette();
        return pasteAction;
    }

    private void PasteSelectedColors()
    {
        if (selectedColors is null) return;
        PasteColors(new Point(Selection.X / CellSize, Selection.Y / CellSize), (ushort[,])selectedColors.Clone());
        selectedColors = null;
    }

    private void CopyArrayToClipboard(ushort[,] colors)
    {
        try { Clipboard.SetDataAsJson(ClipboardFormat, (FlatUshortArray)colors); }
        catch (ExternalException)
        {
            MessageBox.Show("Clipboard is busy. Please try copying again.");
        }
    }

    private ushort[,]? ColorsFromClipboard()
    {
        if (!Clipboard.ContainsData(ClipboardFormat)) return null;

        try
        {
            if (Clipboard.TryGetData(ClipboardFormat, out FlatUshortArray pastedArray)) return pastedArray;
        }
        catch (ExternalException)
        {
            MessageBox.Show("Clipboard is busy. Please try pasting again.");
        }

        return null;
    }

    private Point FindIdealPasteLocation(bool pressedButton, int width, int height)
    {
        Point mouseToTileDisplay = tileDisplay_pal.PointToClient(System.Windows.Forms.Cursor.Position);

        if (!pressedButton)
        {
            int x = (mouseToTileDisplay.X >> tileDisplay_pal.Zoom) - width / 2;
            int y = (mouseToTileDisplay.Y >> tileDisplay_pal.Zoom) - height / 2;
            return new Point(MathFunctions.FloorTo(x, CellSize), MathFunctions.FloorTo(y, CellSize));
        }

        int xOffset = Math.Abs(panel_palView.AutoScrollPosition.X >> tileDisplay_pal.Zoom);
        int yOffset = Math.Abs(panel_palView.AutoScrollPosition.Y >> tileDisplay_pal.Zoom);

        return new Point(MathFunctions.FloorTo(xOffset, CellSize), MathFunctions.FloorTo(yOffset, CellSize));
    }

    private void Copy()
    {
        if (!SelectionVisible) return;
        if (selectedColors is not null) PasteSelectedColors();
        ushort[,] copiedColors = CopyColors(SelectionCells);
        CopyArrayToClipboard(copiedColors);
    }

    private void Paste(bool throughShortcut = false)
    {
        ushort[,]? pasteColors = ColorsFromClipboard();
        if (pasteColors is null) return;

        if (selectedColors is not null) PasteSelectedColors();

        int width = pasteColors.GetLength(0) * CellSize;
        int height = pasteColors.GetLength(1) * CellSize;
        Point pastePoint = FindIdealPasteLocation(!throughShortcut, width, height);

        SelectedTool = Tool.Select;
        SelectionVisible = true;
        Selection.Rectangle = new Rectangle(pastePoint, new Size(width, height));
        selectedColors = pasteColors;
        latestActionGroup = new("Paste");

        DrawPalette();
    }

    private void Cut()
    {
        if (!SelectionVisible) return;
        if (selectedColors is not null) PasteSelectedColors();
        CloseActionGroup();
        ushort[,] cutColors = EjectColors(Selection.Rectangle, "Cut");
        CopyArrayToClipboard(cutColors);
        DrawPalette();
    }

    private void Delete()
    {
        if (!SelectionVisible) return;
        if (selectedColors is not null)
        {
            DiscardSelection();
            return;
        }
        CloseActionGroup();
        EjectColors(Selection.Rectangle, "Delete");
        DrawPalette();
    }

    private void button_cut_Click(object sender, EventArgs e) => Cut();
    #endregion

    #region Color Transformations
    private void dialog_previewChanged(ushort[,] colors, bool showPreview)
    {
        transformationPreview = colors;
        displayPreview = showPreview;
        DrawPalette();
    }

    private void button_gradient_Click(object sender, EventArgs e)
    {
        if (!SelectionVisible) return;
        if (selectedColors is not null) PasteSelectedColors();

        openTransformationDialog();

        displayPreview = false;
        transformationPreview = null;
        DrawPalette();
    }

    private void openTransformationDialog()
    {
        Rectangle cells = SelectionCells;
        ushort[,] colors = CopyColors(cells);

        using PaletteTransformationDialog dialog = new(colors, PaletteColor.ArgbToColor(colorPrimary));
        dialog.StartPosition = FormStartPosition.CenterParent;
        dialog.PreviewChanged += dialog_previewChanged;
        if (dialog.ShowDialog(this) != DialogResult.OK) return;

        latestActionGroup = new(dialog.ActionText);
        PasteColors(cells.Location, dialog.TransformedColors);
    }
    #endregion

    #region Undo Redo
    public void AddAction(EditorGridAction a)
    {
        UndoRedo.AddActionWithoutDo(a);
        setUndoRedoButtons();

        status.ChangeMade();
    }

    private void DiscardSelection()
    {
        if (selectedColors is null) return;
        if (latestActionGroup?.ActionCount == 1) latestActionGroup.Undo();
        latestActionGroup = null;
        selectedColors = null;
        SelectionVisible = false;
    }

    private void Undo()
    {
        DiscardSelection();
        FinishToolAction();
        UndoRedo.Undo();
        setUndoRedoButtons();
        status.ChangeMade();
    }

    private void Redo()
    {
        DiscardSelection();
        FinishToolAction();
        UndoRedo.Redo();
        setUndoRedoButtons();
        status.ChangeMade();
    }

    private void PopulateUndoRedoList(ToolStripSplitButton button, DropOutStack<EditorGridAction> stack)
    {
        int count = Math.Min(16, stack.Count);
        int lastIndex = stack.Count - 1;

        button.DropDownItems.Clear();
        for (int i = 0; i < count; i++)
        {
            ToolStripMenuItem item = new ToolStripMenuItem();
            item.Tag = i + 1;
            item.Text = stack[lastIndex - i].ActionText;
            button.DropDownItems.Add(item);
        }
    }

    private void setUndoRedoButtons()
    {
        button_undo.Enabled = UndoRedo.CanUndo;
        button_redo.Enabled = UndoRedo.CanRedo;
        if (palette is not null) DrawPalette();
    }

    private void button_undo_ButtonClick(object sender, EventArgs e) => Undo();

    private void button_redo_ButtonClick(object sender, EventArgs e) => Redo();

    private void button_undo_DropDownOpening(object sender, EventArgs e) => PopulateUndoRedoList(button_undo, UndoRedo.UndoStack);

    private void button_redo_DropDownOpening(object sender, EventArgs e) => PopulateUndoRedoList(button_redo, UndoRedo.RedoStack);

    private void button_undo_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {
        int num = (int)e.ClickedItem.Tag;
        for (int i = 0; i < num; i++) Undo();
    }

    private void button_redo_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {
        int num = (int)e.ClickedItem.Tag;
        for (int i = 0; i < num; i++) Redo();
    }
    #endregion

    #region Zoom
    const int maxZoom = 4;

    private void button_imageZoomIn_Click(object sender, EventArgs e) => updateZoom(tileDisplay_pal.Zoom + 1);
    private void button_imageZoomOut_Click(object sender, EventArgs e) => updateZoom(tileDisplay_pal.Zoom - 1);

    private void tileDisplay_pal_Scrolled(object sender, MouseEventArgs e)
    {
        if ((ModifierKeys & Keys.Control) == Keys.Control)
        {
            if (e.Delta > 0) updateZoom(tileDisplay_pal.Zoom + 1);
            if (e.Delta < 0) updateZoom(tileDisplay_pal.Zoom - 1);
        }
    }

    private void updateZoom(int value)
    {
        tileDisplay_pal.Zoom = Math.Clamp(value, 0, maxZoom);
        button_ZoomIn.Enabled = tileDisplay_pal.Zoom < maxZoom;
        button_ZoomOut.Enabled = tileDisplay_pal.Zoom > 0;
        label_Zoom.Text = $"{1 << tileDisplay_pal.Zoom}00%";
    }

    #endregion

    #region import/export

    private void statusStrip_importRaw_Click(object sender, EventArgs e) => Import(PalFileType.Raw);

    private void statusStrip_importTLP_Click(object sender, EventArgs e) => Import(PalFileType.TLP);

    private void statusStrip_importYY_Click(object sender, EventArgs e) => Import(PalFileType.YYCHR);

    private void statusStrip_exportRaw_Click(object sender, EventArgs e) => Export(PalFileType.Raw);

    private void statusStrip_exportTLP_Click(object sender, EventArgs e) => Export(PalFileType.TLP);

    private void statusStrip_exportYY_Click(object sender, EventArgs e) => Export(PalFileType.YYCHR);

    private void Import(PalFileType type)
    {
        OpenFileDialog import = new OpenFileDialog();
        import.Filter = GetFileFilter(type);
        if (import.ShowDialog() == DialogResult.OK)
        {
            palette.Import(import.FileName, type);
            palette.Write(ROM.Stream);
            DrawPalette();

            UndoRedo = new();
            setUndoRedoButtons();

            status.Import();
        }
    }

    private void Export(PalFileType type)
    {
        SaveFileDialog export = new SaveFileDialog();
        export.Filter = GetFileFilter(type);
        if (export.ShowDialog() == DialogResult.OK)
        {
            palette.Export(export.FileName, type);
        }
    }

    public static string GetFileFilter(PalFileType type)
    {
        string allFiles = "All files (*.*)|*.*";
        switch (type)
        {
            case PalFileType.Raw:
                return allFiles;
            case PalFileType.YYCHR:
                return $"YY-CHR palette (*.pal)|*.pal|{allFiles}";
            case PalFileType.TLP:
                return $"Tile Layer Pro palette (*.tpl)|*.tpl|{allFiles}";
        }
        throw new FormatException();
    }

    #endregion
}
