using mage.Bookmarks;
using mage.Controls;
using mage.Editors.NewEditors;
using mage.Properties;
using mage.Theming;
using mage.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace mage;

public partial class FormOam : Form
{
    // fields
    private GFX gfxObject;
    private Palette palette;
    private OAM oam;
    private int hoveredPartIndex = -1;
    private Bitmap gfxImage;
    private VramObj vram;

    private Status Status;

    private bool loading;
    private bool loadingPart;

    private FormMain main;
    private ByteStream romStream;

    private Timer animationTimer;

    // Drawables
    Pen partOutline = new Pen(Color.Aqua, 1);
    Pen partOutlineHovered = new Pen(Color.Orange, 1) { Alignment = PenAlignment.Inset };
    Pen partOutlineSelected = new Pen(Color.Red, 1);
    Pen CursorPen = new Pen(Color.Red, 1);
    Pen SelectionPenWhite = new Pen(Color.White, 1) { DashPattern = new float[] { 2, 3 } };
    Pen SelectionPenBlack = new Pen(Color.Black, 1) { DashPattern = new float[] { 2, 3 }, DashOffset = 2 };
    List<Drawable> partOutlines = new List<Drawable>();
    Drawable selectedDrawable;
    Drawable hoveredDrawable;
    Drawable gfxSelection;
    Drawable gfxCursor;
    private Drawable PaletteCursor;
    private Drawable PaletteSelection;

    // Data for saving
    int originalOamOffset;
    int originalNumOfFrames;

    // Context menu related
    Point ContextMenuOpenedAt = Point.Empty;

    // Moving related
    Point? PartStartLocation = null;
    Point? MouseStartLocation = null;

    // properties
    private bool PlayingAnimation
    {
        get => playingAnimation;
        set
        {
            playingAnimation = value;
            button_playAnimation.Image = playingAnimation ? Resources.control_pause_blue : Resources.toolbar_test;

            // Disable/enable controls
            groupBox_part.Enabled = !playingAnimation;
            comboBox_Frame.Enabled = !playingAnimation;
            label_OAMFrame.Enabled = !playingAnimation;
            textBox_duration.Enabled = !playingAnimation;
            label_frameDuration.Enabled = !playingAnimation;
            button_addFrame.Enabled = !playingAnimation;
            button_removeFrame.Enabled = !playingAnimation;
            button_frameDown.Enabled = !playingAnimation;
            button_frameUp.Enabled = !playingAnimation;
            button_duplicate.Enabled = !playingAnimation;

            // Stop timer if needed
            if (playingAnimation) return;
            if (animationTimer == null) return;
            animationTimer.Stop();
        }
    }
    private bool playingAnimation = false;

    private bool ViewOrigin
    {
        get => viewOrigin;
        set
        {
            viewOrigin = value;
            button_viewOrigin.Checked = value;
            Program.Config.OamEditorViewOrigin = value;

            oamView_oam.ShowOamOrigin = value;
            oamView_oam.Invalidate();
        }
    }
    private bool viewOrigin = true;

    private bool ViewPartOutline
    {
        get => viewPartOutline;
        set
        {
            viewPartOutline = value;
            button_viewOutline.Checked = value;
            Program.Config.OamEditorViewPartOutlines = value;

            foreach (Drawable d in partOutlines) d.Visible = value;
            oamView_oam.Invalidate();
        }
    }
    private bool viewPartOutline = false;

    private bool ViewPalette
    {
        get => viewPalette;
        set
        {
            viewPalette = value;
            Program.Config.OamEditorViewPalette = value;
            button_viewPalette.Checked = value;
            panel_palette.Visible = value;
        }
    }
    private bool viewPalette = true;

    private bool ViewVram
    {
        get => viewVram;
        set
        {
            viewVram = value;
            Program.Config.OamEditorViewVram = value;
            button_viewVram.Checked = value;

            DrawImage();
        }
    }
    private bool viewVram = false;

    private bool LoadCommonGraphics
    {
        get => loadCommonGraphics;
        set
        {
            bool old = loadCommonGraphics == value;
            loadCommonGraphics = value;
            Program.Config.OamEditorLoadCommonGraphics = value;
            button_loadCommonGraphics.Checked = value;

            if (!loading)
            {
                DrawNewGFX();
                LoadPalette(0);
            }

            if (old) return;
            SelectedPaletteRow = Math.Clamp(SelectedPaletteRow + (value == true ? 8 : -8), 0, 15);

        }
    }
    private bool loadCommonGraphics = true;

    private int SelectedPartIndex
    {
        get => selectedPartIndex;
        set
        {
            selectedPartIndex = value;
            comboBox_part.SelectedIndex = value;
            SetPartOutlines(oam.Frames[comboBox_Frame.SelectedIndex]);

            button_removePart.Enabled = value != -1;
            panel_partEditing.Enabled = selectedPartIndex != -1;
            HandleChangedPart(value);
        }
    }
    private int selectedPartIndex = -1;

    private int SelectedPaletteRow
    {
        get => selectedPaletteRow;
        set
        {
            selectedPaletteRow = value;
            if (value == -1)
            {
                PaletteSelection.Visible = false;
                return;
            }

            PaletteSelection.Visible = true;
            PaletteSelection.Rectangle = new Rectangle(0, value * 17, 16 * 16 + 17, 17);
            if (!loading)
            {
                DrawImage();
            }
        }
    }
    private int selectedPaletteRow = 8;

    private string PartErrorText
    {
        get => partErrorText;
        set
        {
            partErrorText = value;
            label_error.Visible = value != string.Empty;
        }
    }
    private string partErrorText;

    private int SelectedFrameIndex => comboBox_Frame.SelectedIndex;
    private OAM.Frame SelectedFrame => oam.Frames[comboBox_Frame.SelectedIndex];


    // constructor
    public FormOam(FormMain main, int gfxOffset, int palOffset, int oamOffset, bool compressed = true)
    {
        InitializeComponent();

        //Theming
        ThemeSwitcher.ChangeTheme(Controls, this);
        ThemeSwitcher.InjectPaintOverrides(Controls);

        this.main = main;
        this.romStream = ROM.Stream;
        this.palette = new Palette(romStream, palOffset, 1);

        // Load Settings
        ViewOrigin = Program.Config.OamEditorViewOrigin;
        ViewPartOutline = Program.Config.OamEditorViewPartOutlines;
        ViewPalette = Program.Config.OamEditorViewPalette;
        UpdateGfxZoom(Program.Config.OamEditorGfxZoom);
        UpdateOamZoom(Program.Config.OamEditorOamZoom);

        loading = true;

        textBox_imageOffset.Text = Hex.ToString(gfxOffset);
        textBox_palOffset.Text = Hex.ToString(palOffset);
        textBox_oamOffset.Text = Hex.ToString(oamOffset);
        checkBox_compressed.Checked = compressed;

        //Event based
        textBox_duration.TextChanged += textBox_duration_TextChanged;
        textBox_tile.TextChanged += controlElements_changeMade;
        textBox_x.TextChanged += controlElements_changeMade;
        textBox_y.TextChanged += controlElements_changeMade;

        animationTimer = new Timer();
        animationTimer.Tick += AnimationTimer_Tick;

        //Creating Drawables
        gfxSelection = new Drawable(Rectangle.Empty, SelectionPenWhite, 1) { Visible = false };
        gfxSelection.DrawPens.Add(SelectionPenBlack);
        gfxCursor = new Drawable(Rectangle.Empty, CursorPen, 1) { Visible = false };
        gfxView_gfx.AddDrawable(gfxSelection);
        gfxView_gfx.AddDrawable(gfxCursor);

        //Palette Drawables
        PaletteCursor = new Drawable(Rectangle.Empty, CursorPen, 1) { Visible = true };
        PaletteSelection = new Drawable(Rectangle.Empty, SelectionPenWhite, 1) { Visible = true };
        PaletteSelection.DrawPens.Add(SelectionPenBlack);
        paletteView.AddDrawable(PaletteCursor);
        paletteView.AddDrawable(PaletteSelection);

        LoadCommonGraphics = true; // We don't want to draw/reload graphics during initalization so this must come after `loading = true`

        Status = new Status(label_Status, button_save);

        loading = false;
        DrawNewGFX();
        LoadPalette(0);
        DrawPalette();
        SetOAM();
    }


    #region general
    private void ChangePen(Drawable drawable, Pen pen)
    {
        drawable.DrawPens.Clear();
        drawable.DrawPens.Add(pen);
    }

    private void Save()
    {
        if (oam == null)
        {
            MessageBox.Show("No OAM data to save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        // Get the original frame pointers to find the old frame data
        List<int> originalFramePointers = new List<int>();
        for (int i = 0; i < originalNumOfFrames; i++)
        {
            originalFramePointers.Add(ROM.Stream.ReadPtr(originalOamOffset + 8 * i));
        }

        ByteStream BuildFrameData(OAM.Frame frame)
        {
            ByteStream frameData = new ByteStream();
            frameData.Write16((ushort)frame.numParts);
            foreach (OAM.Part part in frame.parts)
            {
                ushort[] partData = part.GetAttributes();
                frameData.Write16(partData[0]); // Attr0
                frameData.Write16(partData[1]); // Attr1
                frameData.Write16(partData[2]); // Attr2
            }
            return frameData;
        }

        /// STEP 0: Mark unused frame lists as freespace
        for (int i = oam.NumFrames; i < originalNumOfFrames; i++)
        {
            int unusedFramePtr = originalFramePointers[i];
            int unusedNumOfParts = ROM.Stream.Read16(unusedFramePtr);
            int unusedLength = 2 + unusedNumOfParts * 6;

            ROM.Stream.MarkFreeSpace(unusedFramePtr, unusedLength, 0);
        }
        if (oam.NumFrames < originalNumOfFrames) originalNumOfFrames = oam.NumFrames;

        /// STEP 1: SAVE FRAME DATA
        // Overlapping/old frame data
        List<int> newFramePointers = new List<int>();
        for (int i = 0; i < originalNumOfFrames; i++)
        {
            OAM.Frame frame = oam.Frames[i];
            int offset = originalFramePointers[i];
            int originalNumOfParts = ROM.Stream.Read16(offset);

            //Calculate length of old data
            int oldLength = 2 + originalNumOfParts * 6; // 2 for numParts, 6 for each part (3x16 bits)

            // Build frame data up
            ByteStream frameData = BuildFrameData(frame);

            //Write data to the ROM
            ROM.Stream.Write2(frameData, oldLength, ref offset, false);
            newFramePointers.Add(offset);
        }

        // New frame data
        for (int i = originalNumOfFrames; i < oam.NumFrames; i++)
        {
            OAM.Frame frame = oam.Frames[i];
            ByteStream frameData = BuildFrameData(frame);
            int writtenTo = ROM.Stream.WriteNewData(frameData);

            newFramePointers.Add(writtenTo);
        }

        /// STEP 3: SAVE FRAME POINTERS / FRAME LIST
        int oldPointerLength = originalNumOfFrames * 8 + 8;
        ByteStream framePointerData = new ByteStream();
        for (int i = 0; i < oam.NumFrames; i++)
        {
            framePointerData.WritePtr(newFramePointers[i]);
            framePointerData.Write32(oam.Frames[i].duration);
        }
        framePointerData.Write32(0);
        framePointerData.Write32(0); // 8 empty bytes to end the frame list
        int writeOffset = originalOamOffset;
        ROM.Stream.Write2(framePointerData, oldPointerLength, ref writeOffset, true);

        // Display message with the new offset
        if (writeOffset != originalOamOffset)
        {
            if (
                MessageBox.Show(
                    "OAM data needs to be repointed.\n\nDo you want to save the new location as a Bookmark?",
                    "Repointing required", MessageBoxButtons.YesNo, MessageBoxIcon.Information
                )
                != DialogResult.Yes
                || !BookmarkManager.RepointedDataCreateBookmark(originalOamOffset, writeOffset)
            )
            {
                MessageBox.Show($"OAM data was repointed to: {Hex.ToString(writeOffset)}", "Repointed OAM",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Version.RepointedOAM(originalOamOffset, writeOffset);
            textBox_oamOffset.Text = Hex.ToString(writeOffset);
            SetOAM();
        }

        Status.Save();
    }

    private bool CheckUnsaved()
    {
        DialogResult result = MessageBox.Show("Do you want to save changes to the OAM?",
            "Unsaved Changes", MessageBoxButtons.YesNoCancel);
        if (result == DialogResult.Cancel) return false;
        if (result == DialogResult.Yes) Save();
        return true;
    }

    private void KeyPressed(object sender, KeyEventArgs e)
    {
        switch (e.KeyCode)
        {
            case Keys.H:
            case Keys.X:
                if (SelectedPartIndex == -1) break;
                checkBox_xFlip.Checked = !checkBox_xFlip.Checked;
                break;

            case Keys.V:
            case Keys.Y:
                if (SelectedPartIndex == -1) break;
                checkBox_yFlip.Checked = !checkBox_yFlip.Checked;
                break;

            case Keys.P:
                ViewPartOutline = !ViewPartOutline;
                break;

            case Keys.O:
                ViewOrigin = !ViewOrigin;
                break;

            default:
                break;
        }
    }

    private void button_save_Click(object sender, EventArgs e) => Save();

    private void FormOam_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (!Status.UnsavedChanges) return;
        if (!CheckUnsaved()) e.Cancel = true;
    }
    #endregion

    #region ZOOM
    int maxZoom = 4;

    private void button_gfxZoomIn_Click(object sender, EventArgs e) => UpdateGfxZoom(gfxView_gfx.Zoom + 1);
    private void button_gfxZoomOut_Click(object sender, EventArgs e) => UpdateGfxZoom(gfxView_gfx.Zoom - 1);

    private void button_oamZoomIn_Click(object sender, EventArgs e) => UpdateOamZoom(oamView_oam.Zoom + 1);
    private void button_oamZoomOut_Click(object sender, EventArgs e) => UpdateOamZoom(oamView_oam.Zoom - 1);

    #endregion

    #region GFX
    private void DrawNewGFX()
    {
        int offset;
        try
        {
            offset = Hex.ToInt(textBox_imageOffset.Text);
        }
        catch (Exception ex)
        {
            MessageBox.Show("The offset entered was not valid.\n\n" + ex.GetType().ToString() + '\n'
                    + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        int width = 32;

        if (checkBox_compressed.Checked)
        {
            try
            {
                int len = romStream.Read32(offset) >> 8;
                if (romStream.Read8(offset) != 0x10 || len == 0)
                {
                    throw new FormatException();
                }
                gfxObject = new GFX(romStream, offset, width);
                if (gfxObject.origLen == 0)
                {
                    throw new FormatException();
                }
            }
            catch
            {
                MessageBox.Show("There are no compressed graphics at the given offset.",
                    "Compressed graphics error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        else
        {
            int height = 16;
            gfxObject = new GFX(romStream, offset, width, height);
        }

        CreateVram(button_loadCommonGraphics.Checked);
        DrawFrame(comboBox_Frame.SelectedIndex);
        DrawImage();
        UpdateGfxZoom(gfxView_gfx.Zoom);
    }

    private void DrawImage()
    {
        if (!ViewVram && LoadCommonGraphics) gfxImage = gfxObject.Draw4bpp(vram.palette, SelectedPaletteRow, true);
        else if (!ViewVram && !LoadCommonGraphics) gfxImage = gfxObject.Draw4bpp(vram.palette, SelectedPaletteRow, true);
        else if (ViewVram && !LoadCommonGraphics) gfxImage = gfxObject.Draw4bpp(vram.palette, SelectedPaletteRow, true); // A weird edge-case where this condition would render a blank Vram Viewer
        else gfxImage = vram.VramGFX.Draw15bpp(vram.palette, SelectedPaletteRow, true);
        gfxView_gfx.TileImage = gfxImage;
    }

    private void UpdateGfxZoom(int zoom)
    {
        zoom = Math.Clamp(zoom, 0, 4);
        gfxView_gfx.Zoom = zoom;
        Program.Config.OamEditorGfxZoom = zoom;
        button_gfxZoomIn.Enabled = zoom < maxZoom;
        button_gfxZoomOut.Enabled = zoom > 0;
        label_gfxZoom.Text = $"{1 << zoom}00%";
    }

    private void button_viewPalette_Click(object sender, EventArgs e) => ViewPalette = !button_viewPalette.Checked;
    private void button_viewVram_Click(object sender, EventArgs e) => ViewVram = !button_viewVram.Checked;
    private void button_loadCommonGraphics_Click(object sender, EventArgs e) => LoadCommonGraphics = !button_loadCommonGraphics.Checked;


    private void checkBox_compressed_CheckedChanged(object sender, EventArgs e)
    {
        if (!loading)
        {
            LoadPalette(0);
            DrawNewGFX();
        }
    }

    private void gfxView_gfx_MouseMove(object sender, TileDisplay.TileDisplayArgs e)
    {
        int offset = ViewVram ? 0 : 16;
        if (!ViewVram)
        {
            if (LoadCommonGraphics) offset = 16;
            else offset = 0;
        }
        int tileNum = e.TileIndexPosition.X + (e.TileIndexPosition.Y + offset) * 32;
        statusLabel_coor.Text = Hex.ToString(tileNum);

        if (SelectedPartIndex == -1)
        {
            gfxCursor.Visible = false;
            return;
        }
        OAM.Part selectedPart = SelectedFrame.parts[SelectedPartIndex];

        // Set Cursor
        gfxCursor.Visible = true;
        gfxCursor.Rectangle = new Rectangle(
            e.TilePixelPosition.X,
            e.TilePixelPosition.Y,
            selectedPart.Dimensions.Width,
            selectedPart.Dimensions.Height
        );
    }

    private void gfxView_gfx_Scrolled(object sender, MouseEventArgs e)
    {
        if ((ModifierKeys & Keys.Control) == Keys.Control)
        {
            if (e.Delta > 0) UpdateGfxZoom(gfxView_gfx.Zoom + 1);
            if (e.Delta < 0) UpdateGfxZoom(gfxView_gfx.Zoom - 1);
        }
    }

    private void gfxView_gfx_TileMouseDown(object sender, mage.Controls.TileDisplay.TileDisplayArgs e)
    {
        int offset = ViewVram ? 0 : 16;
        if (!ViewVram)
        {
            if (LoadCommonGraphics) offset = 16;
            else offset = 0;
        }
        int tileNum = e.TileIndexPosition.X + (e.TileIndexPosition.Y + offset) * 32;

        if (SelectedPartIndex == -1) return;
        textBox_tile.Text = Hex.ToString(tileNum);
    }
    #endregion

    #region PAL
    private void DrawPalette()
    {
        CreateVram(button_loadCommonGraphics.Checked);
        paletteView.TileImage = vram.palette.Draw(16, 0, 16, 0);
        DrawFrame(comboBox_Frame.SelectedIndex);
    }

    private void LoadPalette(int diff)
    {
        try
        {
            int offset = Hex.ToInt(textBox_palOffset.Text);
            if (diff != 0)
            {
                offset += diff;
                textBox_palOffset.Text = Hex.ToString(offset);
            }

            int count = !checkBox_compressed.Checked ? 8 : (gfxObject.height / 2);

            palette = new Palette(romStream, offset, count);
            CreateVram(button_loadCommonGraphics.Checked);
            DrawImage();
            DrawPalette();
        }
        catch (Exception ex)
        {
            MessageBox.Show("The offset entered was not valid.\n\n" + ex.GetType().ToString() + '\n'
                    + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void button_increasePalette_Click(object sender, EventArgs e) => LoadPalette(32);
    private void button_decreasePalette_Click(object sender, EventArgs e) => LoadPalette(-32);

    private void button_editPal_Click(object sender, EventArgs e)
    {
        try
        {
            int offset = Hex.ToInt(textBox_palOffset.Text);

            FormPaletteNew.OpenPaletteEditor(offset, 1);
        }
        catch (Exception ex)
        {
            MessageBox.Show("The offset entered was not valid.\n\n" + ex.GetType().ToString() + '\n'
                    + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }


    #endregion

    #region OAM
    private void UpdateOamZoom(int zoom)
    {
        zoom = Math.Clamp(zoom, 0, 4);
        if (zoom == oamView_oam.Zoom) return;

        oamView_oam.Zoom = zoom;
        Program.Config.OamEditorOamZoom = zoom;
        button_oamZoomIn.Enabled = zoom < maxZoom;
        button_oamZoomOut.Enabled = zoom > 0;
        label_oamZoom.Text = $"{1 << zoom}00%";

        //Update Pen Width
        switch (zoom)
        {
            case 0:
            case 1:
                partOutlineHovered.Width = 1;
                partOutlineSelected.Width = 2;
                break;
            case 2:
                partOutlineHovered.Width = 1;
                partOutlineSelected.Width = 3;
                break;
            case 3:
            case 4:
                partOutlineHovered.Width = 1;
                partOutlineSelected.Width = 4;
                break;
        }

        // Center view
        int centerX = (panel_oam.DisplayRectangle.Width - panel_oam.ClientSize.Width) / 2;
        int centerY = (panel_oam.DisplayRectangle.Height - panel_oam.ClientSize.Height) / 2;

        panel_oam.AutoScrollPosition = new Point(centerX, centerY);
    }

    private void button_go_Click(object sender, EventArgs e)
    {
        if (Status.UnsavedChanges && !CheckUnsaved())
        {
            return;
        }

        Status.LoadNew();
        DrawNewGFX();
        LoadPalette(0);
        SetOAM();
    }

    private void SetOAM()
    {
        PlayingAnimation = false;
        try
        {
            int offset = Hex.ToInt(textBox_oamOffset.Text);
            oam = new OAM(offset);

            originalOamOffset = offset;
            originalNumOfFrames = oam.NumFrames;

            //Populate frame selection
            SetFrameSelectionCombobox();
            comboBox_Frame.SelectedIndex = 0;
        }
        catch
        {
            MessageBox.Show("No valid OAM found.", "Invalid OAM", MessageBoxButtons.OK, MessageBoxIcon.Error);
            oam = null;
        }
    }

    private void CreateVram(Boolean loadCommonGraphics)
    {
        vram = new VramObj(gfxObject, palette, loadCommonGraphics);
    }

    private void DrawFrame(int frameNumber)
    {
        if (oam == null || vram == null) return;
        Bitmap frame = oam.DrawReal(vram.objTiles, vram.palette, 0, frameNumber);
        oamView_oam.TileImage = frame;

        // Display Part boxes
        SetPartOutlines(SelectedFrame);
    }

    private void SetPartOutlines(OAM.Frame frame)
    {
        partOutlines.Clear();
        oamView_oam.ResetDrawables();
        selectedDrawable = null;
        hoveredDrawable = null;

        for (int i = frame.parts.Count - 1; i >= 0; i--)
        {
            OAM.Part p = frame.parts[i];
            bool hovered = hoveredPartIndex == i;
            bool selected = SelectedPartIndex == i;

            Size s = p.Dimensions;
            Rectangle r = new Rectangle(p.xPos + OAM.FrameOriginX, p.yPos + OAM.FrameOriginY, s.Width, s.Height);
            Drawable outline = new(r, partOutline)
            {
                Visible = ViewPartOutline,
            };

            if (selected)
            {
                ChangePen(outline, partOutlineSelected);
                selectedDrawable = outline;
                selectedDrawable.Visible = true;
                continue;
            }
            if (hovered)
            {
                ChangePen(outline, partOutlineHovered);
                hoveredDrawable = outline;
                hoveredDrawable.Visible = true;
                continue;
            }

            partOutlines.Add(outline);
            oamView_oam.AddDrawable(outline);
        }

        if (selectedDrawable != null)
        {
            partOutlines.Add(selectedDrawable);
            oamView_oam.AddDrawable(selectedDrawable);
        }
        if (hoveredDrawable != null)
        {
            partOutlines.Add(hoveredDrawable);
            oamView_oam.AddDrawable(hoveredDrawable);
        }

        oamView_oam.Invalidate();
    }

    private void SetTimerInterval(int frame)
    {
        OAM.Frame f = oam.Frames[frame];
        int timeInMs = (int)(16.67f * f.duration);
        animationTimer.Interval = Math.Max(1, timeInMs);
    }

    private void SetFrameSelectionCombobox()
    {
        int old = SelectedFrameIndex;

        comboBox_Frame.Items.Clear();
        for (int i = 0; i < oam.NumFrames; i++) comboBox_Frame.Items.Add(i);
        if (old >= 0 && old < comboBox_Frame.Items.Count) comboBox_Frame.SelectedIndex = old;
        else comboBox_Frame.SelectedIndex = oam.NumFrames - 1;
    }

    private void SetPartSelectionCombobox()
    {
        int old = SelectedPartIndex;

        comboBox_part.Items.Clear();
        for (int i = 0; i < oam.Frames[comboBox_Frame.SelectedIndex].parts.Count; i++) comboBox_part.Items.Add(Hex.ToString(i));
        if (old >= 0 && old < comboBox_part.Items.Count) comboBox_part.SelectedIndex = old;
    }

    private void comboBox_Frame_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (loading) return;
        DrawFrame(comboBox_Frame.SelectedIndex);
        loading = true;
        textBox_duration.Text = Hex.ToString(oam.Frames[comboBox_Frame.SelectedIndex].duration);
        loading = false;
        SelectedPartIndex = -1;

        // Enable/disable move buttons
        if (!playingAnimation)
        {
            button_frameDown.Enabled = oam.Frames.Count > 1 && SelectedFrameIndex != oam.Frames.Count - 1;
            button_frameUp.Enabled = oam.Frames.Count > 1 && SelectedFrameIndex != 0;
        }

        //if (playingAnimation) return;
        SetPartSelectionCombobox();
    }

    private void button_playAnimation_Click(object sender, EventArgs e)
    {
        PlayingAnimation = !PlayingAnimation;
        if (!PlayingAnimation) return;

        SetTimerInterval(comboBox_Frame.SelectedIndex);
        animationTimer.Start();
    }

    private void AnimationTimer_Tick(object? sender, EventArgs e)
    {
        comboBox_Frame.SelectedIndex = (comboBox_Frame.SelectedIndex + 1) % oam.NumFrames;
        SetTimerInterval(comboBox_Frame.SelectedIndex);
    }

    private void button_viewOrigin_Click(object sender, EventArgs e) => ViewOrigin = !button_viewOrigin.Checked;

    private void button_viewOutline_Click(object sender, EventArgs e) => ViewPartOutline = !button_viewOutline.Checked;


    #region FRAME EDITING
    private void button_addFrame_Click(object sender, EventArgs e)
    {
        oam.Frames.Add(OAM.Frame.Empty);
        oam.NumFrames++;
        SetFrameSelectionCombobox();
        comboBox_Frame.SelectedIndex = oam.NumFrames - 1;
        Status.ChangeMade();
    }
    private void button_duplicate_Click(object sender, EventArgs e)
    {
        // Create copy of frame
        OAM.Frame copy = OAM.Frame.Empty;
        copy.duration = SelectedFrame.duration;
        copy.numParts = SelectedFrame.numParts;
        foreach (OAM.Part part in SelectedFrame.parts) copy.parts.Add(part);

        oam.Frames.Add(copy);
        oam.NumFrames++;
        SetFrameSelectionCombobox();
        comboBox_Frame.SelectedIndex = oam.NumFrames - 1;
        Status.ChangeMade();
    }
    private void button_removeFrame_Click(object sender, EventArgs e)
    {
        if (SelectedFrameIndex == -1) return;
        if (oam.NumFrames <= 1)
        {
            MessageBox.Show("Cannot remove the last frame.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        oam.Frames.RemoveAt(SelectedFrameIndex);
        oam.NumFrames--;
        SetFrameSelectionCombobox();
        Status.ChangeMade();
    }

    private void textBox_duration_TextChanged(object? sender, EventArgs e)
    {
        if (loading || SelectedFrameIndex == -1) return;

        // Validate duration input
        try
        {
            int duration = Hex.ToByte(textBox_duration.Text);
            if (duration <= 0 || duration > 0xFF)
            {
                throw new ArgumentOutOfRangeException(nameof(duration), "Duration must be between 1 and 0xFF.");
            }

            OAM.Frame frame = SelectedFrame;
            frame.duration = duration;
            oam.Frames[SelectedFrameIndex] = frame;
            Status.ChangeMade();
        }
        catch { }
    }

    private void button_frameUp_Click(object sender, EventArgs e)
    {
        if (SelectedFrameIndex <= 0) return;
        // Swap frames
        OAM.Frame temp = oam.Frames[SelectedFrameIndex];
        oam.Frames[SelectedFrameIndex] = oam.Frames[SelectedFrameIndex - 1];
        oam.Frames[SelectedFrameIndex - 1] = temp;
        // Update selection
        comboBox_Frame.SelectedIndex--;
        Status.ChangeMade();
    }
    private void button_frameDown_Click(object sender, EventArgs e)
    {
        if (SelectedFrameIndex >= oam.NumFrames - 1) return;
        // Swap frames
        OAM.Frame temp = oam.Frames[SelectedFrameIndex];
        oam.Frames[SelectedFrameIndex] = oam.Frames[SelectedFrameIndex + 1];
        oam.Frames[SelectedFrameIndex + 1] = temp;
        // Update selection
        comboBox_Frame.SelectedIndex++;
        Status.ChangeMade();
    }
    #endregion

    #region PART EDITING
    private int FindPart(OAM.Frame frame, int pixelX, int pixelY)
    {
        Point position = new Point(
            pixelX - OAM.FrameOriginX,
            pixelY - OAM.FrameOriginY
        );

        for (int i = 0; i < frame.parts.Count; i++)
        {
            OAM.Part p = frame.parts[i];
            if (p.Area.Contains(position)) return i;
        }

        return -1;
    }

    private bool CheckPartHovered(OAM.Part part, int pixelX, int pixelY)
    {
        Point position = new Point(
            pixelX - OAM.FrameOriginX,
            pixelY - OAM.FrameOriginY
        );
        return part.Area.Contains(position);
    }

    #region Moving Parts
    private void MovePart(int oldIndex, int newIndex)
    {
        if (oldIndex < 0 || oldIndex >= SelectedFrame.parts.Count || newIndex < 0 || newIndex >= SelectedFrame.parts.Count)
            return;

        OAM.Part temp = SelectedFrame.parts[oldIndex];
        SelectedFrame.parts.RemoveAt(oldIndex);
        if (newIndex == SelectedFrame.parts.Count)
            SelectedFrame.parts.Add(temp);
        else
            SelectedFrame.parts.Insert(newIndex, temp);

        SelectedPartIndex = newIndex;

        DrawFrame(SelectedFrameIndex);
        Status.ChangeMade();
    }

    private void contextMenu_oam_Opening(object sender, CancelEventArgs e)
    {
        if (SelectedPartIndex == -1)
        {
            contextMenu_oam.Close();
            return;
        }

        // Enable/disable context menu items based on selected part
        int parts = SelectedFrame.parts.Count;
        button_toFront.Enabled = SelectedPartIndex != 0;
        button_toBack.Enabled = SelectedPartIndex != parts - 1;
        button_layerDown.Enabled = SelectedPartIndex != parts - 1 && parts > 1;
        button_layerUp.Enabled = SelectedPartIndex != 0 && parts > 1;
    }
    private void button_toFront_Click(object sender, EventArgs e)
    {
        if (SelectedPartIndex == -1) return;
        MovePart(SelectedPartIndex, 0);
    }
    private void button_layerUp_Click(object sender, EventArgs e)
    {
        if (SelectedPartIndex == -1) return;
        MovePart(SelectedPartIndex, SelectedPartIndex - 1);
    }
    private void button_layerDown_Click(object sender, EventArgs e)
    {
        if (SelectedPartIndex == -1) return;
        MovePart(SelectedPartIndex, SelectedPartIndex + 1);
    }
    private void button_toBack_Click(object sender, EventArgs e)
    {
        if (SelectedPartIndex == -1) return;
        MovePart(SelectedPartIndex, SelectedFrame.parts.Count - 1);
    }
    #endregion

    #region Adding / Removing
    private void button_addPart_Click(object sender, EventArgs e) => AddPart(0, 0);
    private void button_addPartHere_Click(object sender, EventArgs e) => AddPart(ContextMenuOpenedAt.X - OAM.FrameOriginX, ContextMenuOpenedAt.Y - OAM.FrameOriginY);
    private void AddPart(int x, int y)
    {
        if (SelectedFrame.parts.Count == 0xFF)
        {
            MessageBox.Show("Cannot add more parts to this frame, maximum reached (0xFF).", "Maximum Parts Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        OAM.Frame newFrame = SelectedFrame;

        OAM.Part p = OAM.Part.Empty;
        p.tileNum = 0x200;
        p.palRow = 0x8;
        p.xPos = x;
        p.yPos = y;

        newFrame.parts.Insert(0, p);
        newFrame.numParts++;

        oam.Frames[SelectedFrameIndex] = newFrame;
        SetPartSelectionCombobox();
        DrawFrame(SelectedFrameIndex);
        SelectedPartIndex = 0;
        Status.ChangeMade();
    }

    private void button_removePart_Click(object sender, EventArgs e)
    {
        if (SelectedPartIndex == -1) return;
        OAM.Frame newFrame = SelectedFrame;
        newFrame.parts.RemoveAt(SelectedPartIndex);
        newFrame.numParts--;
        oam.Frames[SelectedFrameIndex] = newFrame;
        SetPartSelectionCombobox();
        DrawFrame(SelectedFrameIndex);
        SelectedPartIndex = -1;
        Status.ChangeMade();
    }
    #endregion

    private void ResetPartData()
    {
        textBox_tile.Text = string.Empty;
        comboBox_palette.SelectedIndex = -1;
        textBox_x.Text = string.Empty;
        textBox_y.Text = string.Empty;
        checkBox_xFlip.Checked = false;
        checkBox_yFlip.Checked = false;
        comboBox_size.SelectedIndex = -1;
    }

    private void DisplayPartData(OAM.Part p)
    {
        textBox_tile.Text = Hex.ToString(p.tileNum);
        comboBox_palette.SelectedIndex = p.palRow;
        int xVal = p.xPos;
        if (xVal < 0) xVal += 512;
        textBox_x.Text = Hex.ToString(xVal);
        int yVal = p.yPos;
        if (yVal < 0) yVal += 256;
        textBox_y.Text = Hex.ToString(yVal);
        checkBox_xFlip.Checked = p.Xflip;
        checkBox_yFlip.Checked = p.Yflip;
        comboBox_size.SelectedIndex = p.shape * 4 + p.size;
    }

    private void HighlightPartInGfx(OAM.Part part)
    {
        // Display Part on GFX View
        int subtract = ViewVram ? 0 : 16;
        Point gfxPosition = new(part.tileNum % 32 * gfxView_gfx.TileSize, (part.tileNum / 32 - subtract) * gfxView_gfx.TileSize);
        gfxSelection.Rectangle = new Rectangle(gfxPosition, part.Dimensions);
        gfxSelection.Visible = true;
    }

    private void HandleChangedPart(int partIndex)
    {
        if (partIndex == -1)
        {
            loadingPart = false;
            ResetPartData();
            gfxSelection.Visible = false;
            gfxCursor.Visible = false;
            partErrorText = string.Empty;
            return;
        }

        OAM.Part part = SelectedFrame.parts[partIndex];

        HighlightPartInGfx(part);

        // Load Part data
        loadingPart = true;
        DisplayPartData(part);
        loadingPart = false;
    }

    private void comboBox_part_SelectedIndexChanged(object sender, EventArgs e)
    {
        SelectedPartIndex = comboBox_part.SelectedIndex;
    }

    private void controlElements_changeMade(object? sender, EventArgs e)
    {
        if (loadingPart || SelectedPartIndex == -1) return;
        OAM.Part part = SelectedFrame.parts[SelectedPartIndex];

        //Validate values or throw error
        try
        {
            int tileNum = Hex.ToInt(textBox_tile.Text);
            if (tileNum < 0 || tileNum > 0x3FF) throw new ArgumentOutOfRangeException(nameof(tileNum), "Tile number must be between 0 and 0x3FF.");
            int temp_xPos = Hex.ToUshort(textBox_x.Text);
            if (temp_xPos < 0 || temp_xPos > 0x1FF) throw new ArgumentOutOfRangeException(nameof(temp_xPos), "X position must be between 0 and 0x1FF.");
            int temp_yPos = Hex.ToByte(textBox_y.Text);

            // Convert to signed int
            int xPos = temp_xPos < 256 ? temp_xPos : temp_xPos - 512;
            int yPos = temp_yPos < 128 ? temp_yPos : temp_yPos - 256;

            byte palRow = (byte)comboBox_palette.SelectedIndex;
            bool xFlip = checkBox_xFlip.Checked;
            bool yFlip = checkBox_yFlip.Checked;
            byte shape = (byte)(comboBox_size.SelectedIndex / 4);
            byte size = (byte)(comboBox_size.SelectedIndex % 4);

            // Update Part
            part.tileNum = tileNum;
            part.xPos = xPos;
            part.yPos = yPos;
            part.palRow = palRow;
            part.flip = (byte)((xFlip ? 0b01 : 0) | (yFlip ? 0b10 : 0));
            part.shape = shape;
            part.size = size;

            SelectedFrame.parts[SelectedPartIndex] = part;
            DrawFrame(SelectedFrameIndex);
            HighlightPartInGfx(part);
            PartErrorText = string.Empty;
            Status.ChangeMade();
        }
        catch (Exception exc)
        {
            PartErrorText = exc.Message;
        }
    }
    #endregion


    private void oamView_oam_Scrolled(object sender, MouseEventArgs e)
    {
        if ((ModifierKeys & Keys.Control) == Keys.Control)
        {
            if (e.Delta > 0) UpdateOamZoom(oamView_oam.Zoom + 1);
            if (e.Delta < 0) UpdateOamZoom(oamView_oam.Zoom - 1);
        }
    }

    private void oamView_oam_TileMouseDown(object sender, mage.Controls.TileDisplay.TileDisplayArgs e)
    {
        if (oam == null) return;

        // General Part selection code
        if (PlayingAnimation) return;
        OAM.Frame selectedFrame = oam.Frames[comboBox_Frame.SelectedIndex];
        int hovered = FindPart(selectedFrame, e.PixelPosition.X, e.PixelPosition.Y);

        // Check if hovered part overlaps with selected
        if (SelectedPartIndex != -1 && hovered != SelectedPartIndex)
        {
            if (CheckPartHovered(selectedFrame.parts[SelectedPartIndex], e.PixelPosition.X, e.PixelPosition.Y))
                hovered = SelectedPartIndex;
        }

        // Set Cursor
        if (hovered == -1) Cursor = Cursors.Default;
        else if (hovered == SelectedPartIndex) Cursor = Cursors.SizeAll;
        else if (hovered != -1) Cursor = Cursors.Hand;

        // Deselect old selection
        if (SelectedPartIndex != -1 && hovered == -1)
        {
            SelectedPartIndex = -1;
            return;
        }
        else if (hovered != -1 && SelectedPartIndex != hovered) SelectedPartIndex = hovered;

        // Context Menu
        if (e.Button == MouseButtons.Right)
        {
            ContextMenuOpenedAt = e.PixelPosition;
            if (SelectedPartIndex != -1) oamView_oam.ContextMenuStrip = contextMenu_oam;
            else oamView_oam.ContextMenuStrip = contextMenu_oamNoSelection;
        }

        // SPECIFIC EDITING CODE
        if (SelectedPartIndex == -1) return;
        OAM.Part part = selectedFrame.parts[SelectedPartIndex];

        MouseStartLocation = e.PixelPosition;
        PartStartLocation = new Point(
            part.xPos,
            part.yPos
        );
    }

    private void oamView_oam_TileMouseMove(object sender, TileDisplay.TileDisplayArgs e)
    {
        if (oam == null) return;

        // General Part selection code
        if (PlayingAnimation) return;
        OAM.Frame selectedFrame = oam.Frames[comboBox_Frame.SelectedIndex];
        int hovered = FindPart(selectedFrame, e.PixelPosition.X, e.PixelPosition.Y);

        // Check if hovered part overlaps with selected
        if (SelectedPartIndex != -1 && hovered != SelectedPartIndex)
        {
            if (CheckPartHovered(selectedFrame.parts[SelectedPartIndex], e.PixelPosition.X, e.PixelPosition.Y))
                hovered = SelectedPartIndex;
        }

        // Set Cursor
        if (hovered == -1) Cursor = Cursors.Default;
        else if (hovered == SelectedPartIndex) Cursor = Cursors.SizeAll;
        else if (hovered != -1) Cursor = Cursors.Hand;

        if (hovered != hoveredPartIndex && MouseStartLocation == null)
        {
            hoveredPartIndex = hovered;
            SetPartOutlines(selectedFrame);
        }


        // SPECIFIC EDITING CODE
        if (SelectedPartIndex == -1) return;
        OAM.Part part = selectedFrame.parts[SelectedPartIndex];

        if (MouseStartLocation == null || PartStartLocation == null || e.Button != MouseButtons.Left) return;
        Point diff = new Point(
            e.PixelPosition.X - MouseStartLocation.Value.X,
            e.PixelPosition.Y - MouseStartLocation.Value.Y
        );
        Point newPartLocation = new Point(
            Math.Clamp(PartStartLocation.Value.X + diff.X, -256, 255),
            Math.Clamp(PartStartLocation.Value.Y + diff.Y, -128, 127)
        );
        textBox_x.Text = Hex.ToString(newPartLocation.X < 0 ? newPartLocation.X + 512 : newPartLocation.X);
        textBox_y.Text = Hex.ToString(newPartLocation.Y < 0 ? newPartLocation.Y + 256 : newPartLocation.Y);
    }

    private void oamView_oam_TileMouseUp(object sender, mage.Controls.TileDisplay.TileDisplayArgs e)
    {
        MouseStartLocation = null;
        PartStartLocation = null;
    }

    #endregion

    #region Export / Import
    private void button_exportAnimation_Click(object sender, EventArgs e)
    {
        SaveFileDialog saveAnimation = new SaveFileDialog();
        saveAnimation.Filter = "GIF files (*.gif)|*.gif";
        if (saveAnimation.ShowDialog() != DialogResult.OK) return;
        if (oam == null)
        {
            MessageBox.Show("No OAM loaded", "OAM Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        if (vram == null)
        {
            MessageBox.Show("No VRAM loaded", "VRAM Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        Rectangle oamBounds = oam.Bounds;
        oamBounds.X += OAM.FrameOriginX;
        oamBounds.Y += OAM.FrameOriginY;

        using (GifWriter writer = new GifWriter(saveAnimation.FileName, 500, 0))
        {
            for (int i = 0; i < oam.NumFrames; i++)
            {
                OAM.Frame frame = oam.Frames[i];

                Bitmap frameImage = oam.DrawReal(vram.objTiles, vram.palette, 0, i);
                frameImage = frameImage.Crop(oamBounds);

                int frameDurationInMs = (int)(16.67f * frame.duration);
                writer.WriteFrame(frameImage, frameDurationInMs);
            }
        }
    }

    private void button_exportOam_Click(object sender, EventArgs e)
    {
        SaveFileDialog saveOAM = new SaveFileDialog();
        saveOAM.Filter = "MAGE OAM files (*.mgo)|*.mgo";
        if (saveOAM.ShowDialog() != DialogResult.OK) return;
        if (oam == null)
        {
            MessageBox.Show("No OAM loaded", "OAM Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        File.WriteAllText(saveOAM.FileName, OamSerializer.Serialize(oam));
    }

    private void button_exportAssembly_Click(object sender, EventArgs e)
    {
        SaveFileDialog saveASM = new SaveFileDialog();
        saveASM.Filter = "Assembly files (*.asm)|*.asm";
        if (saveASM.ShowDialog() != DialogResult.OK) return;
        if (oam == null)
        {
            MessageBox.Show("No OAM loaded", "OAM Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        string animationName = Path.GetFileName(saveASM.FileName);
        animationName = Path.GetFileNameWithoutExtension(animationName);
        File.WriteAllText(saveASM.FileName, OamSerializer.ToASM(oam, animationName));
    }

    void button_importOam_Click(object sender, EventArgs e)
    {
        OpenFileDialog openOAM = new OpenFileDialog();
        openOAM.Filter = "MAGE OAM files (*.mgo)|*.mgo";
        if (openOAM.ShowDialog() != DialogResult.OK) return;
        if (oam == null)
        {
            MessageBox.Show("No OAM loaded. Please load the OAM that you want to replace.", "OAM Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        string json = File.ReadAllText(openOAM.FileName);
        OAM? imported = OamSerializer.Deserialize(json);
        if (imported == null) return;

        oam = imported;
        Save();
        SetOAM();
    }

    private void button_importAssembly_Click(object sender, EventArgs e)
    {
        OpenFileDialog openASM = new OpenFileDialog();
        openASM.Filter = "Assembly files (*.asm)|*.asm";
        if (openASM.ShowDialog() != DialogResult.OK) return;
        if (oam == null)
        {
            MessageBox.Show("No OAM loaded. Please load the OAM that you want to replace.", "OAM Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        string assembly = File.ReadAllText(openASM.FileName);
        OAM? imported = OamSerializer.FromASM(assembly);
        if (imported == null) return;

        oam = imported;
        Save();
        SetOAM();

    }

    #endregion

    private void paletteView_TileMouseMove(object sender, mage.Controls.TileDisplay.TileDisplayArgs e)
    {
        if (PaletteCursor.Y == e.TilePixelPosition.Y) return;
        PaletteCursor.Visible = true;
        PaletteCursor.Rectangle = new Rectangle(0, Math.Min(e.TilePixelPosition.Y, 17 * 15), 16 * 16 + 17, 17);

    }

    private void paletteView_TileMouseDown(object sender, mage.Controls.TileDisplay.TileDisplayArgs e)
    {
        PaletteCursor.Visible = false;
        SelectedPaletteRow = e.TilePixelPosition.Y / 17;

    }
}
