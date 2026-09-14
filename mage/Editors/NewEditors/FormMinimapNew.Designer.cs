namespace mage.Editors.NewEditors
{
    partial class FormMinimapNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMinimapNew));
            statusStrip = new System.Windows.Forms.StatusStrip();
            statusLabel_coor = new System.Windows.Forms.ToolStripStatusLabel();
            statusLabel_changes = new System.Windows.Forms.ToolStripStatusLabel();
            statusStrip_spring = new System.Windows.Forms.ToolStripStatusLabel();
            statusStrip_import = new System.Windows.Forms.ToolStripDropDownButton();
            statusStrip_importRaw = new System.Windows.Forms.ToolStripMenuItem();
            statusStrip_export = new System.Windows.Forms.ToolStripDropDownButton();
            statusStrip_exportRaw = new System.Windows.Forms.ToolStripMenuItem();
            statusStrip_exportImage = new System.Windows.Forms.ToolStripMenuItem();
            button_apply = new System.Windows.Forms.ToolStripDropDownButton();
            group_selection = new System.Windows.Forms.GroupBox();
            comboBox_area = new mage.Theming.CustomControls.FlatComboBox();
            comboBox_state = new mage.Theming.CustomControls.FlatComboBox();
            label_area = new System.Windows.Forms.Label();
            label_state = new System.Windows.Forms.Label();
            splitContainer_main = new System.Windows.Forms.SplitContainer();
            groupBox_mapTiles = new System.Windows.Forms.GroupBox();
            panel_tileView = new mage.Controls.ExtendedPanel();
            tileDisplay_tiles = new mage.Controls.TileDisplay();
            toolStrip_tiles = new System.Windows.Forms.ToolStrip();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            button_flipTilesH = new System.Windows.Forms.ToolStripButton();
            button_flipTilesV = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            button_tilesZoomIn = new System.Windows.Forms.ToolStripButton();
            button_tilesZoomOut = new System.Windows.Forms.ToolStripButton();
            label_tilesZoom = new System.Windows.Forms.ToolStripLabel();
            toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            button_expandTiles = new System.Windows.Forms.ToolStripButton();
            groupBox_map = new System.Windows.Forms.GroupBox();
            panel_mapView = new mage.Controls.ExtendedPanel();
            tileDisplay_map = new mage.Controls.TileDisplay();
            toolStrip_map = new System.Windows.Forms.ToolStrip();
            button_undo = new System.Windows.Forms.ToolStripSplitButton();
            button_redo = new System.Windows.Forms.ToolStripSplitButton();
            toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            button_flipMapH = new System.Windows.Forms.ToolStripButton();
            button_flipMapV = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            button_viewRooms = new System.Windows.Forms.ToolStripButton();
            button_grid = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            button_mapZoomIn = new System.Windows.Forms.ToolStripButton();
            button_mapZoomOut = new System.Windows.Forms.ToolStripButton();
            label_mapZoom = new System.Windows.Forms.ToolStripLabel();
            statusStrip.SuspendLayout();
            group_selection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer_main).BeginInit();
            splitContainer_main.Panel1.SuspendLayout();
            splitContainer_main.Panel2.SuspendLayout();
            splitContainer_main.SuspendLayout();
            groupBox_mapTiles.SuspendLayout();
            panel_tileView.SuspendLayout();
            toolStrip_tiles.SuspendLayout();
            groupBox_map.SuspendLayout();
            panel_mapView.SuspendLayout();
            toolStrip_map.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { statusLabel_coor, statusLabel_changes, statusStrip_spring, statusStrip_import, statusStrip_export, button_apply });
            statusStrip.Location = new System.Drawing.Point(0, 569);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            statusStrip.Size = new System.Drawing.Size(973, 24);
            statusStrip.TabIndex = 12;
            statusStrip.Text = "statusStrip1";
            // 
            // statusLabel_coor
            // 
            statusLabel_coor.AutoSize = false;
            statusLabel_coor.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            statusLabel_coor.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            statusLabel_coor.Name = "statusLabel_coor";
            statusLabel_coor.Size = new System.Drawing.Size(70, 19);
            statusLabel_coor.Text = "(0, 0)";
            statusLabel_coor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusLabel_changes
            // 
            statusLabel_changes.Name = "statusLabel_changes";
            statusLabel_changes.Size = new System.Drawing.Size(12, 19);
            statusLabel_changes.Text = "-";
            // 
            // statusStrip_spring
            // 
            statusStrip_spring.Name = "statusStrip_spring";
            statusStrip_spring.Size = new System.Drawing.Size(707, 19);
            statusStrip_spring.Spring = true;
            // 
            // statusStrip_import
            // 
            statusStrip_import.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            statusStrip_import.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { statusStrip_importRaw });
            statusStrip_import.Name = "statusStrip_import";
            statusStrip_import.Size = new System.Drawing.Size(56, 22);
            statusStrip_import.Text = "Import";
            // 
            // statusStrip_importRaw
            // 
            statusStrip_importRaw.Name = "statusStrip_importRaw";
            statusStrip_importRaw.Size = new System.Drawing.Size(105, 22);
            statusStrip_importRaw.Text = "Raw...";
            statusStrip_importRaw.Click += statusStrip_importRaw_Click;
            // 
            // statusStrip_export
            // 
            statusStrip_export.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            statusStrip_export.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { statusStrip_exportRaw, statusStrip_exportImage });
            statusStrip_export.Name = "statusStrip_export";
            statusStrip_export.Size = new System.Drawing.Size(53, 22);
            statusStrip_export.Text = "Export";
            // 
            // statusStrip_exportRaw
            // 
            statusStrip_exportRaw.Name = "statusStrip_exportRaw";
            statusStrip_exportRaw.Size = new System.Drawing.Size(116, 22);
            statusStrip_exportRaw.Text = "Raw...";
            statusStrip_exportRaw.Click += statusStrip_exportRaw_Click;
            // 
            // statusStrip_exportImage
            // 
            statusStrip_exportImage.Name = "statusStrip_exportImage";
            statusStrip_exportImage.Size = new System.Drawing.Size(116, 22);
            statusStrip_exportImage.Text = "Image...";
            statusStrip_exportImage.Click += statusStrip_exportImage_Click;
            // 
            // button_apply
            // 
            button_apply.Enabled = false;
            button_apply.Image = Properties.Resources.toolbar_save;
            button_apply.ImageTransparentColor = System.Drawing.Color.Magenta;
            button_apply.Name = "button_apply";
            button_apply.ShowDropDownArrow = false;
            button_apply.Size = new System.Drawing.Size(58, 22);
            button_apply.Text = "Apply";
            button_apply.Click += button_apply_Click;
            // 
            // group_selection
            // 
            group_selection.Controls.Add(comboBox_area);
            group_selection.Controls.Add(comboBox_state);
            group_selection.Controls.Add(label_area);
            group_selection.Controls.Add(label_state);
            group_selection.Dock = System.Windows.Forms.DockStyle.Top;
            group_selection.Location = new System.Drawing.Point(6, 3);
            group_selection.Name = "group_selection";
            group_selection.Size = new System.Drawing.Size(451, 87);
            group_selection.TabIndex = 13;
            group_selection.TabStop = false;
            group_selection.Text = "Selection";
            // 
            // comboBox_area
            // 
            comboBox_area.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox_area.FormattingEnabled = true;
            comboBox_area.Location = new System.Drawing.Point(92, 22);
            comboBox_area.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            comboBox_area.Name = "comboBox_area";
            comboBox_area.Size = new System.Drawing.Size(98, 23);
            comboBox_area.TabIndex = 2;
            comboBox_area.SelectedIndexChanged += comboBox_area_SelectedIndexChanged;
            // 
            // comboBox_state
            // 
            comboBox_state.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox_state.FormattingEnabled = true;
            comboBox_state.Location = new System.Drawing.Point(92, 51);
            comboBox_state.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            comboBox_state.Name = "comboBox_state";
            comboBox_state.Size = new System.Drawing.Size(98, 23);
            comboBox_state.TabIndex = 5;
            comboBox_state.SelectedIndexChanged += comboBox_state_SelectedIndexChanged;
            // 
            // label_area
            // 
            label_area.AutoSize = true;
            label_area.Location = new System.Drawing.Point(7, 25);
            label_area.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_area.Name = "label_area";
            label_area.Size = new System.Drawing.Size(34, 15);
            label_area.TabIndex = 3;
            label_area.Text = "Area:";
            // 
            // label_state
            // 
            label_state.AutoSize = true;
            label_state.Location = new System.Drawing.Point(7, 54);
            label_state.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_state.Name = "label_state";
            label_state.Size = new System.Drawing.Size(77, 15);
            label_state.TabIndex = 4;
            label_state.Text = "Display State:";
            // 
            // splitContainer_main
            // 
            splitContainer_main.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer_main.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            splitContainer_main.Location = new System.Drawing.Point(0, 0);
            splitContainer_main.Name = "splitContainer_main";
            // 
            // splitContainer_main.Panel1
            // 
            splitContainer_main.Panel1.Controls.Add(groupBox_mapTiles);
            splitContainer_main.Panel1.Controls.Add(group_selection);
            splitContainer_main.Panel1.Padding = new System.Windows.Forms.Padding(6, 3, 3, 3);
            splitContainer_main.Panel1MinSize = 285;
            // 
            // splitContainer_main.Panel2
            // 
            splitContainer_main.Panel2.Controls.Add(groupBox_map);
            splitContainer_main.Panel2.Padding = new System.Windows.Forms.Padding(3, 3, 6, 3);
            splitContainer_main.Size = new System.Drawing.Size(973, 569);
            splitContainer_main.SplitterDistance = 460;
            splitContainer_main.SplitterWidth = 3;
            splitContainer_main.TabIndex = 14;
            // 
            // groupBox_mapTiles
            // 
            groupBox_mapTiles.Controls.Add(panel_tileView);
            groupBox_mapTiles.Controls.Add(toolStrip_tiles);
            groupBox_mapTiles.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox_mapTiles.Location = new System.Drawing.Point(6, 90);
            groupBox_mapTiles.Name = "groupBox_mapTiles";
            groupBox_mapTiles.Size = new System.Drawing.Size(451, 476);
            groupBox_mapTiles.TabIndex = 14;
            groupBox_mapTiles.TabStop = false;
            groupBox_mapTiles.Text = "Tiles";
            // 
            // panel_tileView
            // 
            panel_tileView.AutoScroll = true;
            panel_tileView.Controls.Add(tileDisplay_tiles);
            panel_tileView.Dock = System.Windows.Forms.DockStyle.Fill;
            panel_tileView.Location = new System.Drawing.Point(3, 44);
            panel_tileView.Name = "panel_tileView";
            panel_tileView.Size = new System.Drawing.Size(445, 429);
            panel_tileView.TabIndex = 2;
            // 
            // tileDisplay_tiles
            // 
            tileDisplay_tiles.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            tileDisplay_tiles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            tileDisplay_tiles.GridCellHeight = 16;
            tileDisplay_tiles.GridCellWidth = 16;
            tileDisplay_tiles.Location = new System.Drawing.Point(0, 6);
            tileDisplay_tiles.Name = "tileDisplay_tiles";
            tileDisplay_tiles.ShowGrid = false;
            tileDisplay_tiles.ShowOamOrigin = false;
            tileDisplay_tiles.Size = new System.Drawing.Size(0, 0);
            tileDisplay_tiles.TabIndex = 0;
            tileDisplay_tiles.TabStop = false;
            tileDisplay_tiles.Tag = "unthemed";
            tileDisplay_tiles.Text = "tileDisplay1";
            tileDisplay_tiles.TileGridOrigin = new System.Drawing.Point(1, 1);
            tileDisplay_tiles.TileImage = null;
            tileDisplay_tiles.TileSize = 10;
            tileDisplay_tiles.Zoom = 1;
            tileDisplay_tiles.TileMouseDown += tileDisplay_tiles_TileMouseDown;
            tileDisplay_tiles.TileMouseUp += tileDisplay_tiles_TileMouseUp;
            tileDisplay_tiles.TileMouseMove += tileDisplay_tiles_TileMouseMove;
            tileDisplay_tiles.Scrolled += tileDisplay_tiles_Scrolled;
            tileDisplay_tiles.KeyDown += FormMinimapNew_KeyDown;
            // 
            // toolStrip_tiles
            // 
            toolStrip_tiles.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            toolStrip_tiles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripSeparator3, button_flipTilesH, button_flipTilesV, toolStripSeparator1, button_tilesZoomIn, button_tilesZoomOut, label_tilesZoom, toolStripSeparator7, toolStripButton1, button_expandTiles });
            toolStrip_tiles.Location = new System.Drawing.Point(3, 19);
            toolStrip_tiles.Name = "toolStrip_tiles";
            toolStrip_tiles.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            toolStrip_tiles.Size = new System.Drawing.Size(445, 25);
            toolStrip_tiles.TabIndex = 1;
            toolStrip_tiles.Text = "toolStrip1";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // button_flipTilesH
            // 
            button_flipTilesH.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            button_flipTilesH.Image = Properties.Resources.shape_flip_horizontal;
            button_flipTilesH.ImageTransparentColor = System.Drawing.Color.Magenta;
            button_flipTilesH.Name = "button_flipTilesH";
            button_flipTilesH.Size = new System.Drawing.Size(23, 22);
            button_flipTilesH.Text = "Flip Horizontally (H, X)";
            button_flipTilesH.Click += button_flipTilesH_Click;
            // 
            // button_flipTilesV
            // 
            button_flipTilesV.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            button_flipTilesV.Image = Properties.Resources.shape_flip_vertical;
            button_flipTilesV.ImageTransparentColor = System.Drawing.Color.Magenta;
            button_flipTilesV.Name = "button_flipTilesV";
            button_flipTilesV.Size = new System.Drawing.Size(23, 22);
            button_flipTilesV.Text = "Flip Vertically (V, Y)";
            button_flipTilesV.Click += button_flipTilesV_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // button_tilesZoomIn
            // 
            button_tilesZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            button_tilesZoomIn.Image = Properties.Resources.zoom_in;
            button_tilesZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            button_tilesZoomIn.Name = "button_tilesZoomIn";
            button_tilesZoomIn.Size = new System.Drawing.Size(23, 22);
            button_tilesZoomIn.Text = "Zoom In";
            button_tilesZoomIn.Click += button_tilesZoomIn_Click;
            // 
            // button_tilesZoomOut
            // 
            button_tilesZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            button_tilesZoomOut.Image = Properties.Resources.zoom_out;
            button_tilesZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            button_tilesZoomOut.Name = "button_tilesZoomOut";
            button_tilesZoomOut.Size = new System.Drawing.Size(23, 22);
            button_tilesZoomOut.Text = "Zoom Out";
            button_tilesZoomOut.Click += button_tilesZoomOut_Click;
            // 
            // label_tilesZoom
            // 
            label_tilesZoom.AutoSize = false;
            label_tilesZoom.Name = "label_tilesZoom";
            label_tilesZoom.Size = new System.Drawing.Size(42, 22);
            label_tilesZoom.Text = "1600%";
            label_tilesZoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            toolStripButton1.Image = Properties.Resources.toolbar_graphics;
            toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new System.Drawing.Size(71, 22);
            toolStripButton1.Text = "Edit GFX";
            toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            toolStripButton1.Click += button_editGfx_Click;
            // 
            // button_expandTiles
            // 
            button_expandTiles.Image = Properties.Resources.toolbar_add;
            button_expandTiles.ImageTransparentColor = System.Drawing.Color.Magenta;
            button_expandTiles.Name = "button_expandTiles";
            button_expandTiles.Size = new System.Drawing.Size(92, 22);
            button_expandTiles.Text = "Expand Tiles";
            button_expandTiles.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            button_expandTiles.Click += button_expandTiles_Click;
            // 
            // groupBox_map
            // 
            groupBox_map.Controls.Add(panel_mapView);
            groupBox_map.Controls.Add(toolStrip_map);
            groupBox_map.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox_map.Location = new System.Drawing.Point(3, 3);
            groupBox_map.Name = "groupBox_map";
            groupBox_map.Size = new System.Drawing.Size(501, 563);
            groupBox_map.TabIndex = 0;
            groupBox_map.TabStop = false;
            groupBox_map.Text = "Map";
            // 
            // panel_mapView
            // 
            panel_mapView.AutoScroll = true;
            panel_mapView.Controls.Add(tileDisplay_map);
            panel_mapView.Dock = System.Windows.Forms.DockStyle.Fill;
            panel_mapView.Location = new System.Drawing.Point(3, 44);
            panel_mapView.Name = "panel_mapView";
            panel_mapView.Size = new System.Drawing.Size(495, 516);
            panel_mapView.TabIndex = 2;
            // 
            // tileDisplay_map
            // 
            tileDisplay_map.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            tileDisplay_map.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            tileDisplay_map.GridCellHeight = 8;
            tileDisplay_map.GridCellWidth = 8;
            tileDisplay_map.Location = new System.Drawing.Point(0, 6);
            tileDisplay_map.Name = "tileDisplay_map";
            tileDisplay_map.ShowGrid = false;
            tileDisplay_map.ShowOamOrigin = false;
            tileDisplay_map.Size = new System.Drawing.Size(0, 0);
            tileDisplay_map.TabIndex = 0;
            tileDisplay_map.TabStop = false;
            tileDisplay_map.Tag = "unthemed";
            tileDisplay_map.Text = "tileDisplay1";
            tileDisplay_map.TileGridOrigin = new System.Drawing.Point(0, 0);
            tileDisplay_map.TileImage = null;
            tileDisplay_map.TileSize = 8;
            tileDisplay_map.Zoom = 1;
            tileDisplay_map.TileMouseDown += tileDisplay_map_TileMouseDown;
            tileDisplay_map.TileMouseUp += tileDisplay_map_TileMouseUp;
            tileDisplay_map.TileMouseMove += tileDisplay_map_TileMouseMove;
            tileDisplay_map.Scrolled += tileDisplay_map_Scrolled;
            tileDisplay_map.KeyDown += FormMinimapNew_KeyDown;
            // 
            // toolStrip_map
            // 
            toolStrip_map.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            toolStrip_map.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { button_undo, button_redo, toolStripSeparator8, toolStripSeparator6, button_flipMapH, button_flipMapV, toolStripSeparator4, button_viewRooms, button_grid, toolStripSeparator5, button_mapZoomIn, button_mapZoomOut, label_mapZoom });
            toolStrip_map.Location = new System.Drawing.Point(3, 19);
            toolStrip_map.Name = "toolStrip_map";
            toolStrip_map.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            toolStrip_map.Size = new System.Drawing.Size(495, 25);
            toolStrip_map.TabIndex = 1;
            toolStrip_map.Text = "toolStrip1";
            // 
            // button_undo
            // 
            button_undo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            button_undo.Enabled = false;
            button_undo.Image = Properties.Resources.toolbar_undo;
            button_undo.ImageTransparentColor = System.Drawing.Color.Magenta;
            button_undo.Name = "button_undo";
            button_undo.Size = new System.Drawing.Size(32, 22);
            button_undo.Text = "Undo";
            button_undo.ButtonClick += button_undo_ButtonClick;
            button_undo.DropDownOpening += button_undo_DropDownOpening;
            button_undo.DropDownItemClicked += button_undo_DropDownItemClicked;
            // 
            // button_redo
            // 
            button_redo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            button_redo.Enabled = false;
            button_redo.Image = Properties.Resources.toolbar_redo;
            button_redo.ImageTransparentColor = System.Drawing.Color.Magenta;
            button_redo.Name = "button_redo";
            button_redo.Size = new System.Drawing.Size(32, 22);
            button_redo.Text = "Redo";
            button_redo.ButtonClick += button_redo_ButtonClick;
            button_redo.DropDownOpening += button_redo_DropDownOpening;
            button_redo.DropDownItemClicked += button_redo_DropDownItemClicked;
            // 
            // toolStripSeparator8
            // 
            toolStripSeparator8.Name = "toolStripSeparator8";
            toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // button_flipMapH
            // 
            button_flipMapH.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            button_flipMapH.Enabled = false;
            button_flipMapH.Image = Properties.Resources.shape_flip_horizontal;
            button_flipMapH.ImageTransparentColor = System.Drawing.Color.Magenta;
            button_flipMapH.Name = "button_flipMapH";
            button_flipMapH.Size = new System.Drawing.Size(23, 22);
            button_flipMapH.Text = "Flip Horizontally (H, X)";
            button_flipMapH.Click += button_flipMapH_Click;
            // 
            // button_flipMapV
            // 
            button_flipMapV.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            button_flipMapV.Enabled = false;
            button_flipMapV.Image = Properties.Resources.shape_flip_vertical;
            button_flipMapV.ImageTransparentColor = System.Drawing.Color.Magenta;
            button_flipMapV.Name = "button_flipMapV";
            button_flipMapV.Size = new System.Drawing.Size(23, 22);
            button_flipMapV.Text = "Flip Vertically (V, Y)";
            button_flipMapV.Click += button_flipMapV_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // button_viewRooms
            // 
            button_viewRooms.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            button_viewRooms.Image = Properties.Resources.toolbar_header;
            button_viewRooms.ImageTransparentColor = System.Drawing.Color.Magenta;
            button_viewRooms.Name = "button_viewRooms";
            button_viewRooms.Size = new System.Drawing.Size(23, 22);
            button_viewRooms.Text = "Room Outlines";
            button_viewRooms.Click += button_viewRooms_Click;
            // 
            // button_grid
            // 
            button_grid.CheckOnClick = true;
            button_grid.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            button_grid.Image = (System.Drawing.Image)resources.GetObject("button_grid.Image");
            button_grid.ImageTransparentColor = System.Drawing.Color.Magenta;
            button_grid.Name = "button_grid";
            button_grid.Size = new System.Drawing.Size(23, 22);
            button_grid.Text = "Grid";
            button_grid.CheckStateChanged += button_grid_CheckStateChanged;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // button_mapZoomIn
            // 
            button_mapZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            button_mapZoomIn.Image = Properties.Resources.zoom_in;
            button_mapZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            button_mapZoomIn.Name = "button_mapZoomIn";
            button_mapZoomIn.Size = new System.Drawing.Size(23, 22);
            button_mapZoomIn.Text = "Zoom In";
            button_mapZoomIn.Click += button_mapZoomIn_Click;
            // 
            // button_mapZoomOut
            // 
            button_mapZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            button_mapZoomOut.Image = Properties.Resources.zoom_out;
            button_mapZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            button_mapZoomOut.Name = "button_mapZoomOut";
            button_mapZoomOut.Size = new System.Drawing.Size(23, 22);
            button_mapZoomOut.Text = "Zoom Out";
            button_mapZoomOut.Click += button_mapZoomOut_Click;
            // 
            // label_mapZoom
            // 
            label_mapZoom.AutoSize = false;
            label_mapZoom.Name = "label_mapZoom";
            label_mapZoom.Size = new System.Drawing.Size(42, 22);
            label_mapZoom.Text = "1600%";
            label_mapZoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormMinimapNew
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            ClientSize = new System.Drawing.Size(973, 593);
            Controls.Add(splitContainer_main);
            Controls.Add(statusStrip);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MinimumSize = new System.Drawing.Size(625, 420);
            Name = "FormMinimapNew";
            Text = "Map Editor";
            FormClosing += FormMinimapNew_FormClosing;
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            group_selection.ResumeLayout(false);
            group_selection.PerformLayout();
            splitContainer_main.Panel1.ResumeLayout(false);
            splitContainer_main.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer_main).EndInit();
            splitContainer_main.ResumeLayout(false);
            groupBox_mapTiles.ResumeLayout(false);
            groupBox_mapTiles.PerformLayout();
            panel_tileView.ResumeLayout(false);
            toolStrip_tiles.ResumeLayout(false);
            toolStrip_tiles.PerformLayout();
            groupBox_map.ResumeLayout(false);
            groupBox_map.PerformLayout();
            panel_mapView.ResumeLayout(false);
            toolStrip_map.ResumeLayout(false);
            toolStrip_map.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel_coor;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel_changes;
        private System.Windows.Forms.ToolStripStatusLabel statusStrip_spring;
        private System.Windows.Forms.ToolStripDropDownButton statusStrip_import;
        private System.Windows.Forms.ToolStripMenuItem statusStrip_importRaw;
        private System.Windows.Forms.ToolStripDropDownButton statusStrip_export;
        private System.Windows.Forms.ToolStripMenuItem statusStrip_exportRaw;
        private System.Windows.Forms.ToolStripMenuItem statusStrip_exportImage;
        private System.Windows.Forms.ToolStripDropDownButton button_apply;
        private System.Windows.Forms.GroupBox group_selection;
        private System.Windows.Forms.SplitContainer splitContainer_main;
        private Theming.CustomControls.FlatComboBox comboBox_area;
        private Theming.CustomControls.FlatComboBox comboBox_state;
        private System.Windows.Forms.Label label_area;
        private System.Windows.Forms.Label label_state;
        private System.Windows.Forms.GroupBox groupBox_mapTiles;
        private System.Windows.Forms.GroupBox groupBox_map;
        private System.Windows.Forms.ToolStrip toolStrip_tiles;
        private System.Windows.Forms.ToolStripButton button_flipTilesH;
        private System.Windows.Forms.ToolStripButton button_flipTilesV;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton button_tilesGrid;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton button_tilesZoomIn;
        private System.Windows.Forms.ToolStripButton button_tilesZoomOut;
        private System.Windows.Forms.ToolStripLabel label_tilesZoom;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStrip toolStrip_map;
        private System.Windows.Forms.ToolStripButton button_flipMapH;
        private System.Windows.Forms.ToolStripButton button_flipMapV;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton button_grid;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton button_mapZoomIn;
        private System.Windows.Forms.ToolStripButton button_mapZoomOut;
        private System.Windows.Forms.ToolStripLabel label_mapZoom;
        private Controls.ExtendedPanel panel_tileView;
        private Controls.TileDisplay tileDisplay_tiles;
        private Controls.ExtendedPanel panel_mapView;
        private Controls.TileDisplay tileDisplay_map;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton button_viewRooms;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton button_expandTiles;
        private System.Windows.Forms.ToolStripSplitButton button_undo;
        private System.Windows.Forms.ToolStripSplitButton button_redo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}