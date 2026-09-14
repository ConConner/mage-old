namespace mage
{
    partial class FormOam
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOam));
            groupBox_imageControl = new System.Windows.Forms.GroupBox();
            button_decreasePalette = new System.Windows.Forms.Button();
            button_increasePalette = new System.Windows.Forms.Button();
            checkBox_compressed = new System.Windows.Forms.CheckBox();
            button_imageGo = new System.Windows.Forms.Button();
            label_paletteOffset = new System.Windows.Forms.Label();
            textBox_imageOffset = new mage.Theming.CustomControls.FlatTextBox();
            label_imageOffset = new System.Windows.Forms.Label();
            label_OAMOffset = new System.Windows.Forms.Label();
            textBox_palOffset = new mage.Theming.CustomControls.FlatTextBox();
            textBox_oamOffset = new mage.Theming.CustomControls.FlatTextBox();
            groupBox_image = new System.Windows.Forms.GroupBox();
            panel_gfx = new mage.Controls.ExtendedPanel();
            gfxView_gfx = new mage.Controls.TileDisplay();
            statusStrip_gfx = new System.Windows.Forms.StatusStrip();
            statusLabel_coor = new System.Windows.Forms.ToolStripStatusLabel();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            button_viewPalette = new System.Windows.Forms.ToolStripButton();
            button_viewVram = new System.Windows.Forms.ToolStripButton();
            button_loadCommonGraphics = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            button_gfxZoomIn = new System.Windows.Forms.ToolStripButton();
            button_gfxZoomOut = new System.Windows.Forms.ToolStripButton();
            label_gfxZoom = new System.Windows.Forms.ToolStripLabel();
            groupBox_oam = new System.Windows.Forms.GroupBox();
            button_frameDown = new System.Windows.Forms.Button();
            button_frameUp = new System.Windows.Forms.Button();
            button_duplicate = new System.Windows.Forms.Button();
            button_removeFrame = new System.Windows.Forms.Button();
            button_addFrame = new System.Windows.Forms.Button();
            button_playAnimation = new System.Windows.Forms.Button();
            textBox_duration = new mage.Theming.CustomControls.FlatTextBox();
            label_frameDuration = new System.Windows.Forms.Label();
            comboBox_Frame = new mage.Theming.CustomControls.FlatComboBox();
            label_OAMFrame = new System.Windows.Forms.Label();
            groupBox_part = new System.Windows.Forms.GroupBox();
            panel_partEditing = new mage.Controls.ExtendedPanel();
            label_error = new System.Windows.Forms.Label();
            comboBox_size = new mage.Theming.CustomControls.FlatComboBox();
            comboBox_palette = new mage.Theming.CustomControls.FlatComboBox();
            label_size = new System.Windows.Forms.Label();
            textBox_tile = new mage.Theming.CustomControls.FlatTextBox();
            label_palette = new System.Windows.Forms.Label();
            label_tile = new System.Windows.Forms.Label();
            checkBox_yFlip = new System.Windows.Forms.CheckBox();
            checkBox_xFlip = new System.Windows.Forms.CheckBox();
            textBox_y = new mage.Theming.CustomControls.FlatTextBox();
            textBox_x = new mage.Theming.CustomControls.FlatTextBox();
            label_y = new System.Windows.Forms.Label();
            label_x = new System.Windows.Forms.Label();
            panel_partControl = new mage.Controls.ExtendedPanel();
            comboBox_part = new mage.Theming.CustomControls.FlatComboBox();
            label_part = new System.Windows.Forms.Label();
            button_removePart = new System.Windows.Forms.Button();
            button_addPart = new System.Windows.Forms.Button();
            groupBox_oamDisplay = new System.Windows.Forms.GroupBox();
            panel_oam = new mage.Controls.ExtendedPanel();
            oamView_oam = new mage.Controls.TileDisplay();
            toolStrip2 = new System.Windows.Forms.ToolStrip();
            button_viewOrigin = new System.Windows.Forms.ToolStripButton();
            button_viewOutline = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            button_oamZoomIn = new System.Windows.Forms.ToolStripButton();
            button_oamZoomOut = new System.Windows.Forms.ToolStripButton();
            label_oamZoom = new System.Windows.Forms.ToolStripLabel();
            splitContainer_views = new System.Windows.Forms.SplitContainer();
            panel_palette = new mage.Controls.ExtendedPanel();
            groupBox_palette = new System.Windows.Forms.GroupBox();
            paletteView = new mage.Controls.TileDisplay();
            splitContainer_controls = new System.Windows.Forms.SplitContainer();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            label_Status = new System.Windows.Forms.ToolStripStatusLabel();
            label_spring = new System.Windows.Forms.ToolStripStatusLabel();
            button_import = new System.Windows.Forms.ToolStripDropDownButton();
            button_importOam = new System.Windows.Forms.ToolStripMenuItem();
            button_importAssembly = new System.Windows.Forms.ToolStripMenuItem();
            button_export = new System.Windows.Forms.ToolStripDropDownButton();
            button_exportAnimation = new System.Windows.Forms.ToolStripMenuItem();
            button_exportAssembly = new System.Windows.Forms.ToolStripMenuItem();
            button_exportOam = new System.Windows.Forms.ToolStripMenuItem();
            button_save = new System.Windows.Forms.ToolStripDropDownButton();
            contextMenu_oam = new System.Windows.Forms.ContextMenuStrip(components);
            button_toFront = new System.Windows.Forms.ToolStripMenuItem();
            button_layerUp = new System.Windows.Forms.ToolStripMenuItem();
            button_layerDown = new System.Windows.Forms.ToolStripMenuItem();
            button_toBack = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            button_removePartCtx = new System.Windows.Forms.ToolStripMenuItem();
            contextMenu_oamNoSelection = new System.Windows.Forms.ContextMenuStrip(components);
            button_addPartHere = new System.Windows.Forms.ToolStripMenuItem();
            groupBox_imageControl.SuspendLayout();
            groupBox_image.SuspendLayout();
            panel_gfx.SuspendLayout();
            statusStrip_gfx.SuspendLayout();
            toolStrip1.SuspendLayout();
            groupBox_oam.SuspendLayout();
            groupBox_part.SuspendLayout();
            panel_partEditing.SuspendLayout();
            panel_partControl.SuspendLayout();
            groupBox_oamDisplay.SuspendLayout();
            panel_oam.SuspendLayout();
            toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer_views).BeginInit();
            splitContainer_views.Panel1.SuspendLayout();
            splitContainer_views.Panel2.SuspendLayout();
            splitContainer_views.SuspendLayout();
            panel_palette.SuspendLayout();
            groupBox_palette.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer_controls).BeginInit();
            splitContainer_controls.Panel1.SuspendLayout();
            splitContainer_controls.Panel2.SuspendLayout();
            splitContainer_controls.SuspendLayout();
            statusStrip1.SuspendLayout();
            contextMenu_oam.SuspendLayout();
            contextMenu_oamNoSelection.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox_imageControl
            // 
            groupBox_imageControl.Controls.Add(button_decreasePalette);
            groupBox_imageControl.Controls.Add(button_increasePalette);
            groupBox_imageControl.Controls.Add(checkBox_compressed);
            groupBox_imageControl.Controls.Add(button_imageGo);
            groupBox_imageControl.Controls.Add(label_paletteOffset);
            groupBox_imageControl.Controls.Add(textBox_imageOffset);
            groupBox_imageControl.Controls.Add(label_imageOffset);
            groupBox_imageControl.Controls.Add(label_OAMOffset);
            groupBox_imageControl.Controls.Add(textBox_palOffset);
            groupBox_imageControl.Controls.Add(textBox_oamOffset);
            groupBox_imageControl.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox_imageControl.Location = new System.Drawing.Point(6, 3);
            groupBox_imageControl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox_imageControl.Name = "groupBox_imageControl";
            groupBox_imageControl.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox_imageControl.Size = new System.Drawing.Size(250, 114);
            groupBox_imageControl.TabIndex = 0;
            groupBox_imageControl.TabStop = false;
            groupBox_imageControl.Text = "Data Control";
            // 
            // button_decreasePalette
            // 
            button_decreasePalette.Location = new System.Drawing.Point(179, 51);
            button_decreasePalette.Name = "button_decreasePalette";
            button_decreasePalette.Size = new System.Drawing.Size(23, 23);
            button_decreasePalette.TabIndex = 0;
            button_decreasePalette.Text = "-";
            button_decreasePalette.UseVisualStyleBackColor = true;
            button_decreasePalette.Click += button_decreasePalette_Click;
            // 
            // button_increasePalette
            // 
            button_increasePalette.Location = new System.Drawing.Point(150, 51);
            button_increasePalette.Name = "button_increasePalette";
            button_increasePalette.Size = new System.Drawing.Size(23, 23);
            button_increasePalette.TabIndex = 0;
            button_increasePalette.Text = "+";
            button_increasePalette.UseVisualStyleBackColor = true;
            button_increasePalette.Click += button_increasePalette_Click;
            // 
            // checkBox_compressed
            // 
            checkBox_compressed.AutoSize = true;
            checkBox_compressed.Location = new System.Drawing.Point(150, 24);
            checkBox_compressed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBox_compressed.Name = "checkBox_compressed";
            checkBox_compressed.Size = new System.Drawing.Size(92, 19);
            checkBox_compressed.TabIndex = 1;
            checkBox_compressed.Text = "Compressed";
            checkBox_compressed.UseVisualStyleBackColor = true;
            checkBox_compressed.CheckedChanged += checkBox_compressed_CheckedChanged;
            // 
            // button_imageGo
            // 
            button_imageGo.Location = new System.Drawing.Point(150, 78);
            button_imageGo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_imageGo.Name = "button_imageGo";
            button_imageGo.Size = new System.Drawing.Size(92, 25);
            button_imageGo.TabIndex = 4;
            button_imageGo.Text = "Go";
            button_imageGo.UseVisualStyleBackColor = true;
            button_imageGo.Click += button_go_Click;
            // 
            // label_paletteOffset
            // 
            label_paletteOffset.AutoSize = true;
            label_paletteOffset.Location = new System.Drawing.Point(8, 54);
            label_paletteOffset.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_paletteOffset.Name = "label_paletteOffset";
            label_paletteOffset.Size = new System.Drawing.Size(46, 15);
            label_paletteOffset.TabIndex = 0;
            label_paletteOffset.Text = "Palette:";
            // 
            // textBox_imageOffset
            // 
            textBox_imageOffset.BorderColor = System.Drawing.Color.FromArgb(188, 188, 188);
            textBox_imageOffset.DisplayBorder = true;
            textBox_imageOffset.HexSanitized = false;
            textBox_imageOffset.HexSanitizedMaxValue = -1;
            textBox_imageOffset.Location = new System.Drawing.Point(72, 22);
            textBox_imageOffset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox_imageOffset.MaxLength = 32767;
            textBox_imageOffset.Multiline = false;
            textBox_imageOffset.Name = "textBox_imageOffset";
            textBox_imageOffset.OnTextChanged = null;
            textBox_imageOffset.Padding = new System.Windows.Forms.Padding(4, 3, 1, 2);
            textBox_imageOffset.PlaceholderText = "";
            textBox_imageOffset.ReadOnly = false;
            textBox_imageOffset.ScrollBars = System.Windows.Forms.ScrollBars.None;
            textBox_imageOffset.SelectionStart = 0;
            textBox_imageOffset.Size = new System.Drawing.Size(70, 23);
            textBox_imageOffset.TabIndex = 0;
            textBox_imageOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            textBox_imageOffset.ValueBox = true;
            textBox_imageOffset.WordWrap = true;
            // 
            // label_imageOffset
            // 
            label_imageOffset.AutoSize = true;
            label_imageOffset.Location = new System.Drawing.Point(8, 25);
            label_imageOffset.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_imageOffset.Name = "label_imageOffset";
            label_imageOffset.Size = new System.Drawing.Size(56, 15);
            label_imageOffset.TabIndex = 0;
            label_imageOffset.Text = "Graphics:";
            // 
            // label_OAMOffset
            // 
            label_OAMOffset.AutoSize = true;
            label_OAMOffset.Location = new System.Drawing.Point(8, 85);
            label_OAMOffset.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_OAMOffset.Name = "label_OAMOffset";
            label_OAMOffset.Size = new System.Drawing.Size(38, 15);
            label_OAMOffset.TabIndex = 0;
            label_OAMOffset.Text = "OAM:";
            // 
            // textBox_palOffset
            // 
            textBox_palOffset.BorderColor = System.Drawing.Color.FromArgb(188, 188, 188);
            textBox_palOffset.DisplayBorder = true;
            textBox_palOffset.HexSanitized = false;
            textBox_palOffset.HexSanitizedMaxValue = -1;
            textBox_palOffset.Location = new System.Drawing.Point(72, 51);
            textBox_palOffset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox_palOffset.MaxLength = 32767;
            textBox_palOffset.Multiline = false;
            textBox_palOffset.Name = "textBox_palOffset";
            textBox_palOffset.OnTextChanged = null;
            textBox_palOffset.Padding = new System.Windows.Forms.Padding(4, 3, 1, 2);
            textBox_palOffset.PlaceholderText = "";
            textBox_palOffset.ReadOnly = false;
            textBox_palOffset.ScrollBars = System.Windows.Forms.ScrollBars.None;
            textBox_palOffset.SelectionStart = 0;
            textBox_palOffset.Size = new System.Drawing.Size(70, 23);
            textBox_palOffset.TabIndex = 2;
            textBox_palOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            textBox_palOffset.ValueBox = true;
            textBox_palOffset.WordWrap = true;
            // 
            // textBox_oamOffset
            // 
            textBox_oamOffset.BorderColor = System.Drawing.Color.FromArgb(188, 188, 188);
            textBox_oamOffset.DisplayBorder = true;
            textBox_oamOffset.HexSanitized = false;
            textBox_oamOffset.HexSanitizedMaxValue = -1;
            textBox_oamOffset.Location = new System.Drawing.Point(72, 80);
            textBox_oamOffset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox_oamOffset.MaxLength = 32767;
            textBox_oamOffset.Multiline = false;
            textBox_oamOffset.Name = "textBox_oamOffset";
            textBox_oamOffset.OnTextChanged = null;
            textBox_oamOffset.Padding = new System.Windows.Forms.Padding(4, 3, 1, 2);
            textBox_oamOffset.PlaceholderText = "";
            textBox_oamOffset.ReadOnly = false;
            textBox_oamOffset.ScrollBars = System.Windows.Forms.ScrollBars.None;
            textBox_oamOffset.SelectionStart = 0;
            textBox_oamOffset.Size = new System.Drawing.Size(70, 23);
            textBox_oamOffset.TabIndex = 3;
            textBox_oamOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            textBox_oamOffset.ValueBox = true;
            textBox_oamOffset.WordWrap = true;
            // 
            // groupBox_image
            // 
            groupBox_image.Controls.Add(panel_gfx);
            groupBox_image.Controls.Add(statusStrip_gfx);
            groupBox_image.Controls.Add(toolStrip1);
            groupBox_image.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox_image.Location = new System.Drawing.Point(294, 3);
            groupBox_image.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox_image.Name = "groupBox_image";
            groupBox_image.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox_image.Size = new System.Drawing.Size(537, 298);
            groupBox_image.TabIndex = 3;
            groupBox_image.TabStop = false;
            groupBox_image.Text = "Graphics";
            // 
            // panel_gfx
            // 
            panel_gfx.AutoScroll = true;
            panel_gfx.Controls.Add(gfxView_gfx);
            panel_gfx.Dock = System.Windows.Forms.DockStyle.Fill;
            panel_gfx.Location = new System.Drawing.Point(4, 44);
            panel_gfx.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel_gfx.Name = "panel_gfx";
            panel_gfx.Size = new System.Drawing.Size(529, 229);
            panel_gfx.TabIndex = 0;
            // 
            // gfxView_gfx
            // 
            gfxView_gfx.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            gfxView_gfx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            gfxView_gfx.GridCellHeight = 16;
            gfxView_gfx.GridCellWidth = 16;
            gfxView_gfx.Location = new System.Drawing.Point(0, 0);
            gfxView_gfx.Name = "gfxView_gfx";
            gfxView_gfx.ShowGrid = false;
            gfxView_gfx.ShowOamOrigin = false;
            gfxView_gfx.Size = new System.Drawing.Size(0, 0);
            gfxView_gfx.TabIndex = 0;
            gfxView_gfx.TabStop = false;
            gfxView_gfx.Tag = "unthemed";
            gfxView_gfx.Text = "tileDisplay1";
            gfxView_gfx.TileGridOrigin = new System.Drawing.Point(0, 0);
            gfxView_gfx.TileImage = null;
            gfxView_gfx.TileSize = 8;
            gfxView_gfx.Zoom = 0;
            gfxView_gfx.TileMouseDown += gfxView_gfx_TileMouseDown;
            gfxView_gfx.TileMouseMove += gfxView_gfx_MouseMove;
            gfxView_gfx.Scrolled += gfxView_gfx_Scrolled;
            // 
            // statusStrip_gfx
            // 
            statusStrip_gfx.ImageScalingSize = new System.Drawing.Size(40, 40);
            statusStrip_gfx.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { statusLabel_coor });
            statusStrip_gfx.Location = new System.Drawing.Point(4, 273);
            statusStrip_gfx.Name = "statusStrip_gfx";
            statusStrip_gfx.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            statusStrip_gfx.Size = new System.Drawing.Size(529, 22);
            statusStrip_gfx.SizingGrip = false;
            statusStrip_gfx.TabIndex = 0;
            statusStrip_gfx.Text = "statusStrip";
            // 
            // statusLabel_coor
            // 
            statusLabel_coor.AutoSize = false;
            statusLabel_coor.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            statusLabel_coor.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            statusLabel_coor.Name = "statusLabel_coor";
            statusLabel_coor.Size = new System.Drawing.Size(70, 17);
            statusLabel_coor.Text = "(0, 0)";
            statusLabel_coor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStrip1
            // 
            toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { button_viewPalette, button_viewVram, button_loadCommonGraphics, toolStripSeparator1, button_gfxZoomIn, button_gfxZoomOut, label_gfxZoom });
            toolStrip1.Location = new System.Drawing.Point(4, 19);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(529, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // button_viewPalette
            // 
            button_viewPalette.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            button_viewPalette.Image = Properties.Resources.toolbar_palette;
            button_viewPalette.ImageTransparentColor = System.Drawing.Color.Magenta;
            button_viewPalette.Name = "button_viewPalette";
            button_viewPalette.Size = new System.Drawing.Size(23, 22);
            button_viewPalette.Text = "View Palette";
            button_viewPalette.Click += button_viewPalette_Click;
            // 
            // button_viewVram
            // 
            button_viewVram.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            button_viewVram.Image = (System.Drawing.Image)resources.GetObject("button_viewVram.Image");
            button_viewVram.ImageTransparentColor = System.Drawing.Color.Magenta;
            button_viewVram.Name = "button_viewVram";
            button_viewVram.Size = new System.Drawing.Size(23, 22);
            button_viewVram.Text = "View entire VRAM";
            button_viewVram.Click += button_viewVram_Click;
            // 
            // button_loadCommonGraphics
            // 
            button_loadCommonGraphics.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            button_loadCommonGraphics.Image = Properties.Resources.toolbar_weapon;
            button_loadCommonGraphics.ImageTransparentColor = System.Drawing.Color.Magenta;
            button_loadCommonGraphics.Name = "button_loadCommonGraphics";
            button_loadCommonGraphics.Size = new System.Drawing.Size(23, 22);
            button_loadCommonGraphics.Text = "Load Common Graphics";
            button_loadCommonGraphics.Click += button_loadCommonGraphics_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // button_gfxZoomIn
            // 
            button_gfxZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            button_gfxZoomIn.Image = Properties.Resources.zoom_in;
            button_gfxZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            button_gfxZoomIn.Name = "button_gfxZoomIn";
            button_gfxZoomIn.Size = new System.Drawing.Size(23, 22);
            button_gfxZoomIn.Text = "Zoom In";
            button_gfxZoomIn.Click += button_gfxZoomIn_Click;
            // 
            // button_gfxZoomOut
            // 
            button_gfxZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            button_gfxZoomOut.Image = Properties.Resources.zoom_out;
            button_gfxZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            button_gfxZoomOut.Name = "button_gfxZoomOut";
            button_gfxZoomOut.Size = new System.Drawing.Size(23, 22);
            button_gfxZoomOut.Text = "Zoom Out";
            button_gfxZoomOut.Click += button_gfxZoomOut_Click;
            // 
            // label_gfxZoom
            // 
            label_gfxZoom.Name = "label_gfxZoom";
            label_gfxZoom.Size = new System.Drawing.Size(35, 22);
            label_gfxZoom.Text = "100%";
            // 
            // groupBox_oam
            // 
            groupBox_oam.Controls.Add(button_frameDown);
            groupBox_oam.Controls.Add(button_frameUp);
            groupBox_oam.Controls.Add(button_duplicate);
            groupBox_oam.Controls.Add(button_removeFrame);
            groupBox_oam.Controls.Add(button_addFrame);
            groupBox_oam.Controls.Add(button_playAnimation);
            groupBox_oam.Controls.Add(textBox_duration);
            groupBox_oam.Controls.Add(label_frameDuration);
            groupBox_oam.Controls.Add(comboBox_Frame);
            groupBox_oam.Controls.Add(label_OAMFrame);
            groupBox_oam.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox_oam.Location = new System.Drawing.Point(6, 117);
            groupBox_oam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox_oam.Name = "groupBox_oam";
            groupBox_oam.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox_oam.Size = new System.Drawing.Size(250, 113);
            groupBox_oam.TabIndex = 1;
            groupBox_oam.TabStop = false;
            groupBox_oam.Text = "OAM Control";
            // 
            // button_frameDown
            // 
            button_frameDown.Image = (System.Drawing.Image)resources.GetObject("button_frameDown.Image");
            button_frameDown.Location = new System.Drawing.Point(199, 51);
            button_frameDown.Name = "button_frameDown";
            button_frameDown.Size = new System.Drawing.Size(43, 23);
            button_frameDown.TabIndex = 8;
            button_frameDown.UseVisualStyleBackColor = true;
            button_frameDown.Click += button_frameDown_Click;
            // 
            // button_frameUp
            // 
            button_frameUp.Image = (System.Drawing.Image)resources.GetObject("button_frameUp.Image");
            button_frameUp.Location = new System.Drawing.Point(150, 51);
            button_frameUp.Name = "button_frameUp";
            button_frameUp.Size = new System.Drawing.Size(43, 23);
            button_frameUp.TabIndex = 7;
            button_frameUp.UseVisualStyleBackColor = true;
            button_frameUp.Click += button_frameUp_Click;
            // 
            // button_duplicate
            // 
            button_duplicate.Location = new System.Drawing.Point(72, 51);
            button_duplicate.Name = "button_duplicate";
            button_duplicate.Size = new System.Drawing.Size(70, 23);
            button_duplicate.TabIndex = 6;
            button_duplicate.Text = "Duplicate";
            button_duplicate.UseVisualStyleBackColor = true;
            button_duplicate.Click += button_duplicate_Click;
            // 
            // button_removeFrame
            // 
            button_removeFrame.Image = Properties.Resources.delete;
            button_removeFrame.Location = new System.Drawing.Point(199, 21);
            button_removeFrame.Name = "button_removeFrame";
            button_removeFrame.Size = new System.Drawing.Size(43, 23);
            button_removeFrame.TabIndex = 2;
            button_removeFrame.UseVisualStyleBackColor = true;
            button_removeFrame.Click += button_removeFrame_Click;
            // 
            // button_addFrame
            // 
            button_addFrame.Image = Properties.Resources.toolbar_add;
            button_addFrame.Location = new System.Drawing.Point(150, 21);
            button_addFrame.Name = "button_addFrame";
            button_addFrame.Size = new System.Drawing.Size(43, 23);
            button_addFrame.TabIndex = 1;
            button_addFrame.UseVisualStyleBackColor = true;
            button_addFrame.Click += button_addFrame_Click;
            // 
            // button_playAnimation
            // 
            button_playAnimation.Image = Properties.Resources.toolbar_test;
            button_playAnimation.Location = new System.Drawing.Point(150, 80);
            button_playAnimation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_playAnimation.Name = "button_playAnimation";
            button_playAnimation.Size = new System.Drawing.Size(92, 25);
            button_playAnimation.TabIndex = 4;
            button_playAnimation.UseVisualStyleBackColor = true;
            button_playAnimation.Click += button_playAnimation_Click;
            // 
            // textBox_duration
            // 
            textBox_duration.BorderColor = System.Drawing.Color.FromArgb(188, 188, 188);
            textBox_duration.DisplayBorder = true;
            textBox_duration.HexSanitized = false;
            textBox_duration.HexSanitizedMaxValue = -1;
            textBox_duration.Location = new System.Drawing.Point(72, 80);
            textBox_duration.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox_duration.MaxLength = 32767;
            textBox_duration.Multiline = false;
            textBox_duration.Name = "textBox_duration";
            textBox_duration.OnTextChanged = null;
            textBox_duration.Padding = new System.Windows.Forms.Padding(4, 3, 1, 2);
            textBox_duration.PlaceholderText = "";
            textBox_duration.ReadOnly = false;
            textBox_duration.ScrollBars = System.Windows.Forms.ScrollBars.None;
            textBox_duration.SelectionStart = 0;
            textBox_duration.Size = new System.Drawing.Size(70, 23);
            textBox_duration.TabIndex = 3;
            textBox_duration.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            textBox_duration.ValueBox = false;
            textBox_duration.WordWrap = true;
            // 
            // label_frameDuration
            // 
            label_frameDuration.AutoSize = true;
            label_frameDuration.Location = new System.Drawing.Point(9, 85);
            label_frameDuration.Name = "label_frameDuration";
            label_frameDuration.Size = new System.Drawing.Size(56, 15);
            label_frameDuration.TabIndex = 5;
            label_frameDuration.Text = "Duration:";
            // 
            // comboBox_Frame
            // 
            comboBox_Frame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox_Frame.FormattingEnabled = true;
            comboBox_Frame.Location = new System.Drawing.Point(72, 22);
            comboBox_Frame.Name = "comboBox_Frame";
            comboBox_Frame.Size = new System.Drawing.Size(70, 23);
            comboBox_Frame.TabIndex = 0;
            comboBox_Frame.SelectedIndexChanged += comboBox_Frame_SelectedIndexChanged;
            // 
            // label_OAMFrame
            // 
            label_OAMFrame.AutoSize = true;
            label_OAMFrame.Location = new System.Drawing.Point(8, 25);
            label_OAMFrame.Name = "label_OAMFrame";
            label_OAMFrame.Size = new System.Drawing.Size(43, 15);
            label_OAMFrame.TabIndex = 3;
            label_OAMFrame.Text = "Frame:";
            // 
            // groupBox_part
            // 
            groupBox_part.Controls.Add(panel_partEditing);
            groupBox_part.Controls.Add(panel_partControl);
            groupBox_part.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox_part.Location = new System.Drawing.Point(6, 230);
            groupBox_part.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox_part.Name = "groupBox_part";
            groupBox_part.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox_part.Size = new System.Drawing.Size(250, 446);
            groupBox_part.TabIndex = 2;
            groupBox_part.TabStop = false;
            groupBox_part.Text = "Part Details";
            // 
            // panel_partEditing
            // 
            panel_partEditing.Controls.Add(label_error);
            panel_partEditing.Controls.Add(comboBox_size);
            panel_partEditing.Controls.Add(comboBox_palette);
            panel_partEditing.Controls.Add(label_size);
            panel_partEditing.Controls.Add(textBox_tile);
            panel_partEditing.Controls.Add(label_palette);
            panel_partEditing.Controls.Add(label_tile);
            panel_partEditing.Controls.Add(checkBox_yFlip);
            panel_partEditing.Controls.Add(checkBox_xFlip);
            panel_partEditing.Controls.Add(textBox_y);
            panel_partEditing.Controls.Add(textBox_x);
            panel_partEditing.Controls.Add(label_y);
            panel_partEditing.Controls.Add(label_x);
            panel_partEditing.Dock = System.Windows.Forms.DockStyle.Fill;
            panel_partEditing.Location = new System.Drawing.Point(4, 48);
            panel_partEditing.Name = "panel_partEditing";
            panel_partEditing.Size = new System.Drawing.Size(242, 395);
            panel_partEditing.TabIndex = 11;
            // 
            // label_error
            // 
            label_error.AutoSize = true;
            label_error.Location = new System.Drawing.Point(4, 11);
            label_error.Name = "label_error";
            label_error.Size = new System.Drawing.Size(183, 15);
            label_error.TabIndex = 18;
            label_error.Text = "One of the values below is invalid";
            label_error.Visible = false;
            // 
            // comboBox_size
            // 
            comboBox_size.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox_size.FormattingEnabled = true;
            comboBox_size.Items.AddRange(new object[] { "1x1 Tiles", "2x2 Tiles", "4x4 Tiles", "8x8 Tiles", "2x1 Tiles", "4x1 Tiles", "4x2 Tiles", "8x4 Tiles", "1x2 Tiles", "1x4 Tiles", "2x4 Tiles", "4x8 Tiles" });
            comboBox_size.Location = new System.Drawing.Point(68, 151);
            comboBox_size.Name = "comboBox_size";
            comboBox_size.Size = new System.Drawing.Size(70, 23);
            comboBox_size.TabIndex = 17;
            comboBox_size.SelectedIndexChanged += controlElements_changeMade;
            // 
            // comboBox_palette
            // 
            comboBox_palette.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox_palette.FormattingEnabled = true;
            comboBox_palette.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" });
            comboBox_palette.Location = new System.Drawing.Point(68, 64);
            comboBox_palette.Name = "comboBox_palette";
            comboBox_palette.Size = new System.Drawing.Size(70, 23);
            comboBox_palette.TabIndex = 16;
            comboBox_palette.SelectedIndexChanged += controlElements_changeMade;
            // 
            // label_size
            // 
            label_size.AutoSize = true;
            label_size.Location = new System.Drawing.Point(4, 154);
            label_size.Name = "label_size";
            label_size.Size = new System.Drawing.Size(30, 15);
            label_size.TabIndex = 15;
            label_size.Text = "Size:";
            // 
            // textBox_tile
            // 
            textBox_tile.BorderColor = System.Drawing.Color.FromArgb(188, 188, 188);
            textBox_tile.DisplayBorder = true;
            textBox_tile.HexSanitized = false;
            textBox_tile.HexSanitizedMaxValue = -1;
            textBox_tile.Location = new System.Drawing.Point(68, 35);
            textBox_tile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox_tile.MaxLength = 32767;
            textBox_tile.Multiline = false;
            textBox_tile.Name = "textBox_tile";
            textBox_tile.OnTextChanged = null;
            textBox_tile.Padding = new System.Windows.Forms.Padding(4, 3, 1, 2);
            textBox_tile.PlaceholderText = "";
            textBox_tile.ReadOnly = false;
            textBox_tile.ScrollBars = System.Windows.Forms.ScrollBars.None;
            textBox_tile.SelectionStart = 0;
            textBox_tile.Size = new System.Drawing.Size(70, 23);
            textBox_tile.TabIndex = 12;
            textBox_tile.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            textBox_tile.ValueBox = false;
            textBox_tile.WordWrap = true;
            // 
            // label_palette
            // 
            label_palette.AutoSize = true;
            label_palette.Location = new System.Drawing.Point(4, 67);
            label_palette.Name = "label_palette";
            label_palette.Size = new System.Drawing.Size(46, 15);
            label_palette.TabIndex = 10;
            label_palette.Text = "Palette:";
            // 
            // label_tile
            // 
            label_tile.AutoSize = true;
            label_tile.Location = new System.Drawing.Point(4, 39);
            label_tile.Name = "label_tile";
            label_tile.Size = new System.Drawing.Size(29, 15);
            label_tile.TabIndex = 9;
            label_tile.Text = "Tile:";
            // 
            // checkBox_yFlip
            // 
            checkBox_yFlip.AutoSize = true;
            checkBox_yFlip.Location = new System.Drawing.Point(146, 123);
            checkBox_yFlip.Name = "checkBox_yFlip";
            checkBox_yFlip.Size = new System.Drawing.Size(72, 19);
            checkBox_yFlip.TabIndex = 5;
            checkBox_yFlip.Text = "Flip on Y";
            checkBox_yFlip.UseVisualStyleBackColor = true;
            checkBox_yFlip.CheckedChanged += controlElements_changeMade;
            // 
            // checkBox_xFlip
            // 
            checkBox_xFlip.AutoSize = true;
            checkBox_xFlip.Location = new System.Drawing.Point(146, 94);
            checkBox_xFlip.Name = "checkBox_xFlip";
            checkBox_xFlip.Size = new System.Drawing.Size(72, 19);
            checkBox_xFlip.TabIndex = 3;
            checkBox_xFlip.Text = "Flip on X";
            checkBox_xFlip.UseVisualStyleBackColor = true;
            checkBox_xFlip.CheckedChanged += controlElements_changeMade;
            // 
            // textBox_y
            // 
            textBox_y.BorderColor = System.Drawing.Color.FromArgb(188, 188, 188);
            textBox_y.DisplayBorder = true;
            textBox_y.HexSanitized = false;
            textBox_y.HexSanitizedMaxValue = -1;
            textBox_y.Location = new System.Drawing.Point(68, 122);
            textBox_y.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox_y.MaxLength = 32767;
            textBox_y.Multiline = false;
            textBox_y.Name = "textBox_y";
            textBox_y.OnTextChanged = null;
            textBox_y.Padding = new System.Windows.Forms.Padding(4, 3, 1, 2);
            textBox_y.PlaceholderText = "";
            textBox_y.ReadOnly = false;
            textBox_y.ScrollBars = System.Windows.Forms.ScrollBars.None;
            textBox_y.SelectionStart = 0;
            textBox_y.Size = new System.Drawing.Size(70, 23);
            textBox_y.TabIndex = 4;
            textBox_y.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            textBox_y.ValueBox = false;
            textBox_y.WordWrap = true;
            // 
            // textBox_x
            // 
            textBox_x.BorderColor = System.Drawing.Color.FromArgb(188, 188, 188);
            textBox_x.DisplayBorder = true;
            textBox_x.HexSanitized = false;
            textBox_x.HexSanitizedMaxValue = -1;
            textBox_x.Location = new System.Drawing.Point(68, 93);
            textBox_x.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox_x.MaxLength = 32767;
            textBox_x.Multiline = false;
            textBox_x.Name = "textBox_x";
            textBox_x.OnTextChanged = null;
            textBox_x.Padding = new System.Windows.Forms.Padding(4, 3, 1, 2);
            textBox_x.PlaceholderText = "";
            textBox_x.ReadOnly = false;
            textBox_x.ScrollBars = System.Windows.Forms.ScrollBars.None;
            textBox_x.SelectionStart = 0;
            textBox_x.Size = new System.Drawing.Size(70, 23);
            textBox_x.TabIndex = 2;
            textBox_x.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            textBox_x.ValueBox = false;
            textBox_x.WordWrap = true;
            // 
            // label_y
            // 
            label_y.AutoSize = true;
            label_y.Location = new System.Drawing.Point(4, 124);
            label_y.Name = "label_y";
            label_y.Size = new System.Drawing.Size(17, 15);
            label_y.TabIndex = 1;
            label_y.Text = "Y:";
            // 
            // label_x
            // 
            label_x.AutoSize = true;
            label_x.Location = new System.Drawing.Point(4, 95);
            label_x.Name = "label_x";
            label_x.Size = new System.Drawing.Size(17, 15);
            label_x.TabIndex = 0;
            label_x.Text = "X:";
            // 
            // panel_partControl
            // 
            panel_partControl.Controls.Add(comboBox_part);
            panel_partControl.Controls.Add(label_part);
            panel_partControl.Controls.Add(button_removePart);
            panel_partControl.Controls.Add(button_addPart);
            panel_partControl.Dock = System.Windows.Forms.DockStyle.Top;
            panel_partControl.Location = new System.Drawing.Point(4, 19);
            panel_partControl.Name = "panel_partControl";
            panel_partControl.Size = new System.Drawing.Size(242, 29);
            panel_partControl.TabIndex = 12;
            // 
            // comboBox_part
            // 
            comboBox_part.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox_part.FormattingEnabled = true;
            comboBox_part.Location = new System.Drawing.Point(68, 3);
            comboBox_part.Name = "comboBox_part";
            comboBox_part.Size = new System.Drawing.Size(70, 23);
            comboBox_part.TabIndex = 0;
            comboBox_part.SelectedIndexChanged += comboBox_part_SelectedIndexChanged;
            // 
            // label_part
            // 
            label_part.AutoSize = true;
            label_part.Location = new System.Drawing.Point(4, 6);
            label_part.Name = "label_part";
            label_part.Size = new System.Drawing.Size(31, 15);
            label_part.TabIndex = 10;
            label_part.Text = "Part:";
            // 
            // button_removePart
            // 
            button_removePart.Image = Properties.Resources.delete;
            button_removePart.Location = new System.Drawing.Point(195, 3);
            button_removePart.Name = "button_removePart";
            button_removePart.Size = new System.Drawing.Size(43, 23);
            button_removePart.TabIndex = 2;
            button_removePart.UseVisualStyleBackColor = true;
            button_removePart.Click += button_removePart_Click;
            // 
            // button_addPart
            // 
            button_addPart.Image = Properties.Resources.toolbar_add;
            button_addPart.Location = new System.Drawing.Point(146, 3);
            button_addPart.Name = "button_addPart";
            button_addPart.Size = new System.Drawing.Size(43, 23);
            button_addPart.TabIndex = 1;
            button_addPart.UseVisualStyleBackColor = true;
            button_addPart.Click += button_addPart_Click;
            // 
            // groupBox_oamDisplay
            // 
            groupBox_oamDisplay.Controls.Add(panel_oam);
            groupBox_oamDisplay.Controls.Add(toolStrip2);
            groupBox_oamDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox_oamDisplay.Location = new System.Drawing.Point(3, 3);
            groupBox_oamDisplay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox_oamDisplay.Name = "groupBox_oamDisplay";
            groupBox_oamDisplay.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox_oamDisplay.Size = new System.Drawing.Size(828, 360);
            groupBox_oamDisplay.TabIndex = 4;
            groupBox_oamDisplay.TabStop = false;
            groupBox_oamDisplay.Text = "OAM Frame";
            // 
            // panel_oam
            // 
            panel_oam.AutoScroll = true;
            panel_oam.Controls.Add(oamView_oam);
            panel_oam.Dock = System.Windows.Forms.DockStyle.Fill;
            panel_oam.Location = new System.Drawing.Point(4, 44);
            panel_oam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel_oam.Name = "panel_oam";
            panel_oam.Size = new System.Drawing.Size(820, 313);
            panel_oam.TabIndex = 0;
            // 
            // oamView_oam
            // 
            oamView_oam.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            oamView_oam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            oamView_oam.GridCellHeight = 16;
            oamView_oam.GridCellWidth = 16;
            oamView_oam.Location = new System.Drawing.Point(0, 0);
            oamView_oam.Name = "oamView_oam";
            oamView_oam.ShowGrid = false;
            oamView_oam.ShowOamOrigin = false;
            oamView_oam.Size = new System.Drawing.Size(0, 0);
            oamView_oam.TabIndex = 0;
            oamView_oam.TabStop = false;
            oamView_oam.Tag = "unthemed";
            oamView_oam.Text = "tileDisplay1";
            oamView_oam.TileGridOrigin = new System.Drawing.Point(0, 0);
            oamView_oam.TileImage = null;
            oamView_oam.TileSize = 16;
            oamView_oam.Zoom = 0;
            oamView_oam.TileMouseDown += oamView_oam_TileMouseDown;
            oamView_oam.TileMouseUp += oamView_oam_TileMouseUp;
            oamView_oam.TileMouseMove += oamView_oam_TileMouseMove;
            oamView_oam.Scrolled += oamView_oam_Scrolled;
            oamView_oam.KeyDown += KeyPressed;
            // 
            // toolStrip2
            // 
            toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { button_viewOrigin, button_viewOutline, toolStripSeparator2, button_oamZoomIn, button_oamZoomOut, label_oamZoom });
            toolStrip2.Location = new System.Drawing.Point(4, 19);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new System.Drawing.Size(820, 25);
            toolStrip2.TabIndex = 0;
            toolStrip2.Text = "toolStrip2";
            // 
            // button_viewOrigin
            // 
            button_viewOrigin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            button_viewOrigin.Image = (System.Drawing.Image)resources.GetObject("button_viewOrigin.Image");
            button_viewOrigin.ImageTransparentColor = System.Drawing.Color.Magenta;
            button_viewOrigin.Name = "button_viewOrigin";
            button_viewOrigin.Size = new System.Drawing.Size(23, 22);
            button_viewOrigin.Text = "View Origin";
            button_viewOrigin.Click += button_viewOrigin_Click;
            // 
            // button_viewOutline
            // 
            button_viewOutline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            button_viewOutline.Image = (System.Drawing.Image)resources.GetObject("button_viewOutline.Image");
            button_viewOutline.ImageTransparentColor = System.Drawing.Color.Magenta;
            button_viewOutline.Name = "button_viewOutline";
            button_viewOutline.Size = new System.Drawing.Size(23, 22);
            button_viewOutline.Text = "View Part Outlines";
            button_viewOutline.Click += button_viewOutline_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // button_oamZoomIn
            // 
            button_oamZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            button_oamZoomIn.Image = Properties.Resources.zoom_in;
            button_oamZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            button_oamZoomIn.Name = "button_oamZoomIn";
            button_oamZoomIn.Size = new System.Drawing.Size(23, 22);
            button_oamZoomIn.Text = "Zoom In";
            button_oamZoomIn.Click += button_oamZoomIn_Click;
            // 
            // button_oamZoomOut
            // 
            button_oamZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            button_oamZoomOut.Image = Properties.Resources.zoom_out;
            button_oamZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            button_oamZoomOut.Name = "button_oamZoomOut";
            button_oamZoomOut.Size = new System.Drawing.Size(23, 22);
            button_oamZoomOut.Text = "Zoom Out";
            button_oamZoomOut.Click += button_oamZoomOut_Click;
            // 
            // label_oamZoom
            // 
            label_oamZoom.Name = "label_oamZoom";
            label_oamZoom.Size = new System.Drawing.Size(35, 22);
            label_oamZoom.Text = "100%";
            // 
            // splitContainer_views
            // 
            splitContainer_views.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer_views.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            splitContainer_views.Location = new System.Drawing.Point(0, 0);
            splitContainer_views.Name = "splitContainer_views";
            splitContainer_views.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_views.Panel1
            // 
            splitContainer_views.Panel1.Controls.Add(groupBox_image);
            splitContainer_views.Panel1.Controls.Add(panel_palette);
            splitContainer_views.Panel1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 6);
            // 
            // splitContainer_views.Panel2
            // 
            splitContainer_views.Panel2.Controls.Add(groupBox_oamDisplay);
            splitContainer_views.Panel2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 6);
            splitContainer_views.Size = new System.Drawing.Size(834, 679);
            splitContainer_views.SplitterDistance = 307;
            splitContainer_views.SplitterWidth = 3;
            splitContainer_views.TabIndex = 6;
            // 
            // panel_palette
            // 
            panel_palette.Controls.Add(groupBox_palette);
            panel_palette.Dock = System.Windows.Forms.DockStyle.Left;
            panel_palette.Location = new System.Drawing.Point(3, 3);
            panel_palette.Name = "panel_palette";
            panel_palette.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            panel_palette.Size = new System.Drawing.Size(291, 298);
            panel_palette.TabIndex = 3;
            // 
            // groupBox_palette
            // 
            groupBox_palette.Controls.Add(paletteView);
            groupBox_palette.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox_palette.Location = new System.Drawing.Point(0, 0);
            groupBox_palette.Name = "groupBox_palette";
            groupBox_palette.Size = new System.Drawing.Size(285, 298);
            groupBox_palette.TabIndex = 5;
            groupBox_palette.TabStop = false;
            groupBox_palette.Text = "Palette";
            // 
            // paletteView
            // 
            paletteView.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            paletteView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            paletteView.GridCellHeight = 16;
            paletteView.GridCellWidth = 16;
            paletteView.Location = new System.Drawing.Point(6, 19);
            paletteView.Name = "paletteView";
            paletteView.ShowGrid = false;
            paletteView.ShowOamOrigin = false;
            paletteView.Size = new System.Drawing.Size(0, 0);
            paletteView.TabIndex = 0;
            paletteView.TabStop = false;
            paletteView.Text = "tileDisplay1";
            paletteView.TileGridOrigin = new System.Drawing.Point(0, 0);
            paletteView.TileImage = null;
            paletteView.TileSize = 17;
            paletteView.Zoom = 0;
            paletteView.TileMouseDown += paletteView_TileMouseDown;
            paletteView.TileMouseMove += paletteView_TileMouseMove;
            // 
            // splitContainer_controls
            // 
            splitContainer_controls.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer_controls.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            splitContainer_controls.IsSplitterFixed = true;
            splitContainer_controls.Location = new System.Drawing.Point(0, 0);
            splitContainer_controls.Name = "splitContainer_controls";
            // 
            // splitContainer_controls.Panel1
            // 
            splitContainer_controls.Panel1.Controls.Add(groupBox_part);
            splitContainer_controls.Panel1.Controls.Add(groupBox_oam);
            splitContainer_controls.Panel1.Controls.Add(groupBox_imageControl);
            splitContainer_controls.Panel1.Padding = new System.Windows.Forms.Padding(6, 3, 3, 3);
            // 
            // splitContainer_controls.Panel2
            // 
            splitContainer_controls.Panel2.Controls.Add(splitContainer_views);
            splitContainer_controls.Size = new System.Drawing.Size(1097, 679);
            splitContainer_controls.SplitterDistance = 259;
            splitContainer_controls.TabIndex = 7;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { label_Status, label_spring, button_import, button_export, button_save });
            statusStrip1.Location = new System.Drawing.Point(0, 679);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new System.Drawing.Size(1097, 22);
            statusStrip1.TabIndex = 8;
            statusStrip1.Text = "statusStrip1";
            // 
            // label_Status
            // 
            label_Status.Name = "label_Status";
            label_Status.Size = new System.Drawing.Size(12, 17);
            label_Status.Text = "-";
            // 
            // label_spring
            // 
            label_spring.Name = "label_spring";
            label_spring.Size = new System.Drawing.Size(903, 17);
            label_spring.Spring = true;
            // 
            // button_import
            // 
            button_import.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            button_import.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { button_importOam, button_importAssembly });
            button_import.Image = (System.Drawing.Image)resources.GetObject("button_import.Image");
            button_import.ImageTransparentColor = System.Drawing.Color.Magenta;
            button_import.Name = "button_import";
            button_import.Size = new System.Drawing.Size(56, 20);
            button_import.Text = "Import";
            // 
            // button_importOam
            // 
            button_importOam.Name = "button_importOam";
            button_importOam.Size = new System.Drawing.Size(134, 22);
            button_importOam.Text = "OAM...";
            button_importOam.Click += button_importOam_Click;
            // 
            // button_importAssembly
            // 
            button_importAssembly.Name = "button_importAssembly";
            button_importAssembly.Size = new System.Drawing.Size(134, 22);
            button_importAssembly.Text = "Assembly...";
            button_importAssembly.Click += button_importAssembly_Click;
            // 
            // button_export
            // 
            button_export.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            button_export.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { button_exportAnimation, button_exportAssembly, button_exportOam });
            button_export.Image = (System.Drawing.Image)resources.GetObject("button_export.Image");
            button_export.ImageTransparentColor = System.Drawing.Color.Magenta;
            button_export.Name = "button_export";
            button_export.Size = new System.Drawing.Size(53, 20);
            button_export.Text = "Export";
            // 
            // button_exportAnimation
            // 
            button_exportAnimation.Name = "button_exportAnimation";
            button_exportAnimation.Size = new System.Drawing.Size(139, 22);
            button_exportAnimation.Text = "Animation...";
            button_exportAnimation.Click += button_exportAnimation_Click;
            // 
            // button_exportAssembly
            // 
            button_exportAssembly.Name = "button_exportAssembly";
            button_exportAssembly.Size = new System.Drawing.Size(139, 22);
            button_exportAssembly.Text = "Assembly...";
            button_exportAssembly.Click += button_exportAssembly_Click;
            // 
            // button_exportOam
            // 
            button_exportOam.Name = "button_exportOam";
            button_exportOam.Size = new System.Drawing.Size(139, 22);
            button_exportOam.Text = "OAM...";
            button_exportOam.Click += button_exportOam_Click;
            // 
            // button_save
            // 
            button_save.Enabled = false;
            button_save.Image = Properties.Resources.toolbar_save;
            button_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            button_save.Name = "button_save";
            button_save.ShowDropDownArrow = false;
            button_save.Size = new System.Drawing.Size(58, 20);
            button_save.Text = "Apply";
            button_save.Click += button_save_Click;
            // 
            // contextMenu_oam
            // 
            contextMenu_oam.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { button_toFront, button_layerUp, button_layerDown, button_toBack, toolStripSeparator3, button_removePartCtx });
            contextMenu_oam.Name = "contextMenu_oam";
            contextMenu_oam.Size = new System.Drawing.Size(164, 120);
            contextMenu_oam.Opening += contextMenu_oam_Opening;
            // 
            // button_toFront
            // 
            button_toFront.Image = (System.Drawing.Image)resources.GetObject("button_toFront.Image");
            button_toFront.Name = "button_toFront";
            button_toFront.Size = new System.Drawing.Size(163, 22);
            button_toFront.Text = "Bring to Front";
            button_toFront.Click += button_toFront_Click;
            // 
            // button_layerUp
            // 
            button_layerUp.Image = (System.Drawing.Image)resources.GetObject("button_layerUp.Image");
            button_layerUp.Name = "button_layerUp";
            button_layerUp.Size = new System.Drawing.Size(163, 22);
            button_layerUp.Text = "Move forwards";
            button_layerUp.Click += button_layerUp_Click;
            // 
            // button_layerDown
            // 
            button_layerDown.Image = (System.Drawing.Image)resources.GetObject("button_layerDown.Image");
            button_layerDown.Name = "button_layerDown";
            button_layerDown.Size = new System.Drawing.Size(163, 22);
            button_layerDown.Text = "Move backwards";
            button_layerDown.Click += button_layerDown_Click;
            // 
            // button_toBack
            // 
            button_toBack.Image = (System.Drawing.Image)resources.GetObject("button_toBack.Image");
            button_toBack.Name = "button_toBack";
            button_toBack.Size = new System.Drawing.Size(163, 22);
            button_toBack.Text = "Send to Back";
            button_toBack.Click += button_toBack_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(160, 6);
            // 
            // button_removePartCtx
            // 
            button_removePartCtx.Image = Properties.Resources.delete;
            button_removePartCtx.Name = "button_removePartCtx";
            button_removePartCtx.Size = new System.Drawing.Size(163, 22);
            button_removePartCtx.Text = "Delete";
            button_removePartCtx.Click += button_removePart_Click;
            // 
            // contextMenu_oamNoSelection
            // 
            contextMenu_oamNoSelection.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { button_addPartHere });
            contextMenu_oamNoSelection.Name = "contextMenu_oamNoSelection";
            contextMenu_oamNoSelection.Size = new System.Drawing.Size(146, 26);
            // 
            // button_addPartHere
            // 
            button_addPartHere.Image = Properties.Resources.toolbar_add;
            button_addPartHere.Name = "button_addPartHere";
            button_addPartHere.Size = new System.Drawing.Size(145, 22);
            button_addPartHere.Text = "Add new Part";
            button_addPartHere.Click += button_addPartHere_Click;
            // 
            // FormOam
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            ClientSize = new System.Drawing.Size(1097, 701);
            Controls.Add(splitContainer_controls);
            Controls.Add(statusStrip1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MinimumSize = new System.Drawing.Size(822, 670);
            Name = "FormOam";
            Text = "OAM Editor";
            FormClosing += FormOam_FormClosing;
            groupBox_imageControl.ResumeLayout(false);
            groupBox_imageControl.PerformLayout();
            groupBox_image.ResumeLayout(false);
            groupBox_image.PerformLayout();
            panel_gfx.ResumeLayout(false);
            statusStrip_gfx.ResumeLayout(false);
            statusStrip_gfx.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            groupBox_oam.ResumeLayout(false);
            groupBox_oam.PerformLayout();
            groupBox_part.ResumeLayout(false);
            panel_partEditing.ResumeLayout(false);
            panel_partEditing.PerformLayout();
            panel_partControl.ResumeLayout(false);
            panel_partControl.PerformLayout();
            groupBox_oamDisplay.ResumeLayout(false);
            groupBox_oamDisplay.PerformLayout();
            panel_oam.ResumeLayout(false);
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            splitContainer_views.Panel1.ResumeLayout(false);
            splitContainer_views.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer_views).EndInit();
            splitContainer_views.ResumeLayout(false);
            panel_palette.ResumeLayout(false);
            groupBox_palette.ResumeLayout(false);
            splitContainer_controls.Panel1.ResumeLayout(false);
            splitContainer_controls.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer_controls).EndInit();
            splitContainer_controls.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            contextMenu_oam.ResumeLayout(false);
            contextMenu_oamNoSelection.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_imageControl;
        private mage.Theming.CustomControls.FlatTextBox textBox_palOffset;
        private System.Windows.Forms.Label label_paletteOffset;
        private mage.Theming.CustomControls.FlatTextBox textBox_imageOffset;
        private System.Windows.Forms.Label label_imageOffset;
        private System.Windows.Forms.GroupBox groupBox_image;
        private System.Windows.Forms.Button button_imageGo;
        private System.Windows.Forms.StatusStrip statusStrip_gfx;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel_coor;
        private System.Windows.Forms.CheckBox checkBox_compressed;
        private System.Windows.Forms.GroupBox groupBox_oam;
        private mage.Theming.CustomControls.FlatComboBox comboBox_Frame;
        private System.Windows.Forms.Label label_OAMFrame;
        private Theming.CustomControls.FlatTextBox textBox_oamOffset;
        private System.Windows.Forms.Label label_OAMOffset;
        private System.Windows.Forms.GroupBox groupBox_part;
        private System.Windows.Forms.GroupBox groupBox_oamDisplay;
        private System.Windows.Forms.SplitContainer splitContainer_views;
        private System.Windows.Forms.Label label_frameDuration;
        private Theming.CustomControls.FlatTextBox textBox_duration;
        private System.Windows.Forms.Button button_playAnimation;
        private Controls.TileDisplay gfxView_gfx;
        private Controls.TileDisplay oamView_oam;
        private System.Windows.Forms.Button button_removeFrame;
        private System.Windows.Forms.Button button_addFrame;
        private System.Windows.Forms.SplitContainer splitContainer_controls;
        private System.Windows.Forms.GroupBox groupBox_palette;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton button_gfxZoomIn;
        private System.Windows.Forms.ToolStripButton button_gfxZoomOut;
        private System.Windows.Forms.ToolStripLabel label_gfxZoom;
        private System.Windows.Forms.ToolStripButton button_viewPalette;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private Theming.CustomControls.FlatComboBox comboBox_part;
        private System.Windows.Forms.Button button_removePart;
        private System.Windows.Forms.Button button_addPart;
        private System.Windows.Forms.Label label_part;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton button_oamZoomIn;
        private System.Windows.Forms.ToolStripButton button_oamZoomOut;
        private System.Windows.Forms.ToolStripLabel label_oamZoom;
        private System.Windows.Forms.ToolStripButton button_viewOrigin;
        private System.Windows.Forms.ToolStripButton button_viewOutline;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private Controls.TileDisplay paletteView;
        private System.Windows.Forms.Button button_decreasePalette;
        private System.Windows.Forms.Button button_increasePalette;
        private System.Windows.Forms.ToolStripButton button_viewVram;
        private System.Windows.Forms.ToolStripStatusLabel label_Status;
        private System.Windows.Forms.ToolStripStatusLabel label_spring;
        private System.Windows.Forms.ToolStripDropDownButton button_save;
        private System.Windows.Forms.Label label_y;
        private System.Windows.Forms.Label label_x;
        private Theming.CustomControls.FlatTextBox textBox_y;
        private Theming.CustomControls.FlatTextBox textBox_x;
        private System.Windows.Forms.CheckBox checkBox_yFlip;
        private System.Windows.Forms.CheckBox checkBox_xFlip;
        private System.Windows.Forms.Label label_tile;
        private Theming.CustomControls.FlatTextBox textBox_tile;
        private System.Windows.Forms.Label label_palette;
        private System.Windows.Forms.Label label_size;
        private Theming.CustomControls.FlatComboBox comboBox_size;
        private Theming.CustomControls.FlatComboBox comboBox_palette;
        private System.Windows.Forms.Label label_error;
        private System.Windows.Forms.ContextMenuStrip contextMenu_oam;
        private System.Windows.Forms.ToolStripMenuItem button_toBack;
        private System.Windows.Forms.ToolStripMenuItem button_toFront;
        private System.Windows.Forms.ToolStripMenuItem button_layerDown;
        private System.Windows.Forms.ToolStripMenuItem button_layerUp;
        private System.Windows.Forms.ContextMenuStrip contextMenu_oamNoSelection;
        private System.Windows.Forms.ToolStripMenuItem button_addPartHere;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem button_removePartCtx;
        private System.Windows.Forms.Button button_frameUp;
        private System.Windows.Forms.Button button_duplicate;
        private System.Windows.Forms.Button button_frameDown;
        private System.Windows.Forms.ToolStripDropDownButton button_import;
        private System.Windows.Forms.ToolStripDropDownButton button_export;
        private Controls.ExtendedPanel panel_gfx;
        private Controls.ExtendedPanel panel_oam;
        private Controls.ExtendedPanel panel_palette;
        private Controls.ExtendedPanel panel_partEditing;
        private Controls.ExtendedPanel panel_partControl;
        private System.Windows.Forms.ToolStripMenuItem button_exportOam;
        private System.Windows.Forms.ToolStripMenuItem button_exportAnimation;
        private System.Windows.Forms.ToolStripMenuItem button_importOam;
        private System.Windows.Forms.ToolStripMenuItem button_exportAssembly;
        private System.Windows.Forms.ToolStripButton button_loadCommonGraphics;
        private System.Windows.Forms.ToolStripMenuItem button_importAssembly;
    }
}