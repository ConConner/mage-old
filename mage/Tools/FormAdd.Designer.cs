namespace mage
{
    partial class FormAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdd));
            tabControl = new Theming.CustomControls.FlatTabControl();
            tabPage_bg = new System.Windows.Forms.TabPage();
            groupBox_bgOptions = new System.Windows.Forms.GroupBox();
            radioButton_bgBlank = new System.Windows.Forms.RadioButton();
            radioButton_bgCopy = new System.Windows.Forms.RadioButton();
            textBox_bgOffset = new Theming.CustomControls.FlatTextBox();
            groupBox_bgSelect = new System.Windows.Forms.GroupBox();
            comboBox_bg = new Theming.CustomControls.FlatComboBox();
            radioButton_bgLZ77 = new System.Windows.Forms.RadioButton();
            radioButton_bgRLE = new System.Windows.Forms.RadioButton();
            tabPage_roomSprites = new System.Windows.Forms.TabPage();
            label_enemySpriteset = new System.Windows.Forms.Label();
            radioButton_enemyBlank = new System.Windows.Forms.RadioButton();
            radioButton_enemyCopy = new System.Windows.Forms.RadioButton();
            textBox_enemyOffset = new Theming.CustomControls.FlatTextBox();
            comboBox_enemySet = new Theming.CustomControls.FlatComboBox();
            tabPage_room = new System.Windows.Forms.TabPage();
            chb_screens = new System.Windows.Forms.CheckBox();
            label_roomArea = new System.Windows.Forms.Label();
            label_roomHeight = new System.Windows.Forms.Label();
            label_roomWidth = new System.Windows.Forms.Label();
            comboBox_roomCopyRoom = new Theming.CustomControls.FlatComboBox();
            textBox_roomHeight = new Theming.CustomControls.FlatTextBox();
            textBox_roomWidth = new Theming.CustomControls.FlatTextBox();
            comboBox_roomCopyArea = new Theming.CustomControls.FlatComboBox();
            comboBox_roomArea = new Theming.CustomControls.FlatComboBox();
            radioButton_roomBlank = new System.Windows.Forms.RadioButton();
            radioButton_roomCopy = new System.Windows.Forms.RadioButton();
            tabPage_tileset = new System.Windows.Forms.TabPage();
            comboBox_tileset = new Theming.CustomControls.FlatComboBox();
            radioButton_tilesetBlank = new System.Windows.Forms.RadioButton();
            radioButton_tilesetCopy = new System.Windows.Forms.RadioButton();
            tabPage_spriteset = new System.Windows.Forms.TabPage();
            comboBox_spriteset = new Theming.CustomControls.FlatComboBox();
            radioButton_spritesetBlank = new System.Windows.Forms.RadioButton();
            radioButton_spritesetCopy = new System.Windows.Forms.RadioButton();
            tabPage_anim = new System.Windows.Forms.TabPage();
            groupBox_animOptions = new System.Windows.Forms.GroupBox();
            comboBox_animNum = new Theming.CustomControls.FlatComboBox();
            radioButton_animBlank = new System.Windows.Forms.RadioButton();
            radioButton_animCopy = new System.Windows.Forms.RadioButton();
            groupBox_animSelect = new System.Windows.Forms.GroupBox();
            radioButton_animTileset = new System.Windows.Forms.RadioButton();
            radioButton_animGfx = new System.Windows.Forms.RadioButton();
            radioButton_animPalette = new System.Windows.Forms.RadioButton();
            button_add = new System.Windows.Forms.Button();
            button_close = new System.Windows.Forms.Button();
            tabControl.SuspendLayout();
            tabPage_bg.SuspendLayout();
            groupBox_bgOptions.SuspendLayout();
            groupBox_bgSelect.SuspendLayout();
            tabPage_roomSprites.SuspendLayout();
            tabPage_room.SuspendLayout();
            tabPage_tileset.SuspendLayout();
            tabPage_spriteset.SuspendLayout();
            tabPage_anim.SuspendLayout();
            groupBox_animOptions.SuspendLayout();
            groupBox_animSelect.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.BorderColor = System.Drawing.Color.Empty;
            tabControl.Controls.Add(tabPage_bg);
            tabControl.Controls.Add(tabPage_roomSprites);
            tabControl.Controls.Add(tabPage_room);
            tabControl.Controls.Add(tabPage_tileset);
            tabControl.Controls.Add(tabPage_spriteset);
            tabControl.Controls.Add(tabPage_anim);
            tabControl.Location = new System.Drawing.Point(14, 14);
            tabControl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new System.Drawing.Size(286, 171);
            tabControl.TabIndex = 0;
            tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;
            // 
            // tabPage_bg
            // 
            tabPage_bg.Controls.Add(groupBox_bgOptions);
            tabPage_bg.Controls.Add(groupBox_bgSelect);
            tabPage_bg.Location = new System.Drawing.Point(4, 25);
            tabPage_bg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPage_bg.Name = "tabPage_bg";
            tabPage_bg.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPage_bg.Size = new System.Drawing.Size(278, 142);
            tabPage_bg.TabIndex = 0;
            tabPage_bg.Text = "Background";
            // 
            // groupBox_bgOptions
            // 
            groupBox_bgOptions.Controls.Add(radioButton_bgBlank);
            groupBox_bgOptions.Controls.Add(radioButton_bgCopy);
            groupBox_bgOptions.Controls.Add(textBox_bgOffset);
            groupBox_bgOptions.Location = new System.Drawing.Point(121, 7);
            groupBox_bgOptions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox_bgOptions.Name = "groupBox_bgOptions";
            groupBox_bgOptions.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox_bgOptions.Size = new System.Drawing.Size(148, 106);
            groupBox_bgOptions.TabIndex = 9;
            groupBox_bgOptions.TabStop = false;
            groupBox_bgOptions.Text = "Options";
            // 
            // radioButton_bgBlank
            // 
            radioButton_bgBlank.AutoSize = true;
            radioButton_bgBlank.Location = new System.Drawing.Point(7, 22);
            radioButton_bgBlank.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioButton_bgBlank.Name = "radioButton_bgBlank";
            radioButton_bgBlank.Size = new System.Drawing.Size(54, 19);
            radioButton_bgBlank.TabIndex = 2;
            radioButton_bgBlank.Text = "Blank";
            radioButton_bgBlank.UseVisualStyleBackColor = true;
            radioButton_bgBlank.CheckedChanged += radioButton_option_CheckedChanged;
            // 
            // radioButton_bgCopy
            // 
            radioButton_bgCopy.AutoSize = true;
            radioButton_bgCopy.Location = new System.Drawing.Point(7, 51);
            radioButton_bgCopy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioButton_bgCopy.Name = "radioButton_bgCopy";
            radioButton_bgCopy.Size = new System.Drawing.Size(53, 19);
            radioButton_bgCopy.TabIndex = 3;
            radioButton_bgCopy.Text = "Copy";
            radioButton_bgCopy.UseVisualStyleBackColor = true;
            radioButton_bgCopy.CheckedChanged += radioButton_option_CheckedChanged;
            // 
            // textBox_bgOffset
            // 
            textBox_bgOffset.BorderColor = System.Drawing.Color.Black;
            textBox_bgOffset.DisplayBorder = true;
            textBox_bgOffset.Location = new System.Drawing.Point(71, 50);
            textBox_bgOffset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox_bgOffset.MaxLength = 32767;
            textBox_bgOffset.Multiline = false;
            textBox_bgOffset.Name = "textBox_bgOffset";
            textBox_bgOffset.OnTextChanged = null;
            textBox_bgOffset.Padding = new System.Windows.Forms.Padding(4, 3, 1, 2);
            textBox_bgOffset.ReadOnly = false;
            textBox_bgOffset.ScrollBars = System.Windows.Forms.ScrollBars.None;
            textBox_bgOffset.SelectionStart = 0;
            textBox_bgOffset.Size = new System.Drawing.Size(70, 23);
            textBox_bgOffset.TabIndex = 5;
            textBox_bgOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            textBox_bgOffset.WordWrap = true;
            // 
            // groupBox_bgSelect
            // 
            groupBox_bgSelect.Controls.Add(comboBox_bg);
            groupBox_bgSelect.Controls.Add(radioButton_bgLZ77);
            groupBox_bgSelect.Controls.Add(radioButton_bgRLE);
            groupBox_bgSelect.Location = new System.Drawing.Point(7, 7);
            groupBox_bgSelect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox_bgSelect.Name = "groupBox_bgSelect";
            groupBox_bgSelect.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox_bgSelect.Size = new System.Drawing.Size(107, 106);
            groupBox_bgSelect.TabIndex = 8;
            groupBox_bgSelect.TabStop = false;
            groupBox_bgSelect.Text = "Select";
            // 
            // comboBox_bg
            // 
            comboBox_bg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox_bg.FormattingEnabled = true;
            comboBox_bg.Items.AddRange(new object[] { "BG 0", "BG 1", "BG 2", "BG 3", "Clipdata" });
            comboBox_bg.Location = new System.Drawing.Point(7, 22);
            comboBox_bg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            comboBox_bg.Name = "comboBox_bg";
            comboBox_bg.Size = new System.Drawing.Size(93, 23);
            comboBox_bg.TabIndex = 0;
            comboBox_bg.SelectedIndexChanged += comboBox_bg_SelectedIndexChanged;
            // 
            // radioButton_bgLZ77
            // 
            radioButton_bgLZ77.AutoSize = true;
            radioButton_bgLZ77.Location = new System.Drawing.Point(7, 80);
            radioButton_bgLZ77.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioButton_bgLZ77.Name = "radioButton_bgLZ77";
            radioButton_bgLZ77.Size = new System.Drawing.Size(50, 19);
            radioButton_bgLZ77.TabIndex = 7;
            radioButton_bgLZ77.TabStop = true;
            radioButton_bgLZ77.Text = "LZ77";
            radioButton_bgLZ77.UseVisualStyleBackColor = true;
            // 
            // radioButton_bgRLE
            // 
            radioButton_bgRLE.AutoSize = true;
            radioButton_bgRLE.Location = new System.Drawing.Point(7, 53);
            radioButton_bgRLE.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioButton_bgRLE.Name = "radioButton_bgRLE";
            radioButton_bgRLE.Size = new System.Drawing.Size(44, 19);
            radioButton_bgRLE.TabIndex = 6;
            radioButton_bgRLE.TabStop = true;
            radioButton_bgRLE.Text = "RLE";
            radioButton_bgRLE.UseVisualStyleBackColor = true;
            // 
            // tabPage_roomSprites
            // 
            tabPage_roomSprites.BackColor = System.Drawing.SystemColors.Control;
            tabPage_roomSprites.Controls.Add(label_enemySpriteset);
            tabPage_roomSprites.Controls.Add(radioButton_enemyBlank);
            tabPage_roomSprites.Controls.Add(radioButton_enemyCopy);
            tabPage_roomSprites.Controls.Add(textBox_enemyOffset);
            tabPage_roomSprites.Controls.Add(comboBox_enemySet);
            tabPage_roomSprites.Location = new System.Drawing.Point(4, 25);
            tabPage_roomSprites.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPage_roomSprites.Name = "tabPage_roomSprites";
            tabPage_roomSprites.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPage_roomSprites.Size = new System.Drawing.Size(192, 71);
            tabPage_roomSprites.TabIndex = 5;
            tabPage_roomSprites.Text = "Room Sprites";
            // 
            // label_enemySpriteset
            // 
            label_enemySpriteset.AutoSize = true;
            label_enemySpriteset.Location = new System.Drawing.Point(7, 10);
            label_enemySpriteset.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_enemySpriteset.Name = "label_enemySpriteset";
            label_enemySpriteset.Size = new System.Drawing.Size(55, 15);
            label_enemySpriteset.TabIndex = 9;
            label_enemySpriteset.Text = "Spriteset:";
            // 
            // radioButton_enemyBlank
            // 
            radioButton_enemyBlank.AutoSize = true;
            radioButton_enemyBlank.Location = new System.Drawing.Point(7, 39);
            radioButton_enemyBlank.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioButton_enemyBlank.Name = "radioButton_enemyBlank";
            radioButton_enemyBlank.Size = new System.Drawing.Size(54, 19);
            radioButton_enemyBlank.TabIndex = 6;
            radioButton_enemyBlank.Text = "Blank";
            radioButton_enemyBlank.UseVisualStyleBackColor = true;
            radioButton_enemyBlank.CheckedChanged += radioButton_option_CheckedChanged;
            // 
            // radioButton_enemyCopy
            // 
            radioButton_enemyCopy.AutoSize = true;
            radioButton_enemyCopy.Location = new System.Drawing.Point(7, 69);
            radioButton_enemyCopy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioButton_enemyCopy.Name = "radioButton_enemyCopy";
            radioButton_enemyCopy.Size = new System.Drawing.Size(53, 19);
            radioButton_enemyCopy.TabIndex = 7;
            radioButton_enemyCopy.Text = "Copy";
            radioButton_enemyCopy.UseVisualStyleBackColor = true;
            radioButton_enemyCopy.CheckedChanged += radioButton_option_CheckedChanged;
            // 
            // textBox_enemyOffset
            // 
            textBox_enemyOffset.BorderColor = System.Drawing.Color.Black;
            textBox_enemyOffset.DisplayBorder = true;
            textBox_enemyOffset.Location = new System.Drawing.Point(71, 68);
            textBox_enemyOffset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox_enemyOffset.MaxLength = 32767;
            textBox_enemyOffset.Multiline = false;
            textBox_enemyOffset.Name = "textBox_enemyOffset";
            textBox_enemyOffset.OnTextChanged = null;
            textBox_enemyOffset.Padding = new System.Windows.Forms.Padding(4, 3, 1, 2);
            textBox_enemyOffset.ReadOnly = false;
            textBox_enemyOffset.ScrollBars = System.Windows.Forms.ScrollBars.None;
            textBox_enemyOffset.SelectionStart = 0;
            textBox_enemyOffset.Size = new System.Drawing.Size(70, 23);
            textBox_enemyOffset.TabIndex = 8;
            textBox_enemyOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            textBox_enemyOffset.WordWrap = true;
            // 
            // comboBox_enemySet
            // 
            comboBox_enemySet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox_enemySet.FormattingEnabled = true;
            comboBox_enemySet.Items.AddRange(new object[] { "Default", "First", "Second" });
            comboBox_enemySet.Location = new System.Drawing.Point(74, 7);
            comboBox_enemySet.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            comboBox_enemySet.Name = "comboBox_enemySet";
            comboBox_enemySet.Size = new System.Drawing.Size(81, 23);
            comboBox_enemySet.TabIndex = 0;
            // 
            // tabPage_room
            // 
            tabPage_room.BackColor = System.Drawing.SystemColors.Control;
            tabPage_room.Controls.Add(chb_screens);
            tabPage_room.Controls.Add(label_roomArea);
            tabPage_room.Controls.Add(label_roomHeight);
            tabPage_room.Controls.Add(label_roomWidth);
            tabPage_room.Controls.Add(comboBox_roomCopyRoom);
            tabPage_room.Controls.Add(textBox_roomHeight);
            tabPage_room.Controls.Add(textBox_roomWidth);
            tabPage_room.Controls.Add(comboBox_roomCopyArea);
            tabPage_room.Controls.Add(comboBox_roomArea);
            tabPage_room.Controls.Add(radioButton_roomBlank);
            tabPage_room.Controls.Add(radioButton_roomCopy);
            tabPage_room.Location = new System.Drawing.Point(4, 25);
            tabPage_room.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPage_room.Name = "tabPage_room";
            tabPage_room.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPage_room.Size = new System.Drawing.Size(278, 142);
            tabPage_room.TabIndex = 1;
            tabPage_room.Text = "Room";
            // 
            // chb_screens
            // 
            chb_screens.AutoSize = true;
            chb_screens.Checked = true;
            chb_screens.CheckState = System.Windows.Forms.CheckState.Checked;
            chb_screens.Location = new System.Drawing.Point(78, 71);
            chb_screens.Name = "chb_screens";
            chb_screens.Size = new System.Drawing.Size(80, 19);
            chb_screens.TabIndex = 18;
            chb_screens.Text = "as Screens";
            chb_screens.UseVisualStyleBackColor = true;
            // 
            // label_roomArea
            // 
            label_roomArea.AutoSize = true;
            label_roomArea.Location = new System.Drawing.Point(7, 10);
            label_roomArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_roomArea.Name = "label_roomArea";
            label_roomArea.Size = new System.Drawing.Size(34, 15);
            label_roomArea.TabIndex = 17;
            label_roomArea.Text = "Area:";
            // 
            // label_roomHeight
            // 
            label_roomHeight.AutoSize = true;
            label_roomHeight.Location = new System.Drawing.Point(177, 42);
            label_roomHeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_roomHeight.Name = "label_roomHeight";
            label_roomHeight.Size = new System.Drawing.Size(46, 15);
            label_roomHeight.TabIndex = 16;
            label_roomHeight.Text = "Height:";
            // 
            // label_roomWidth
            // 
            label_roomWidth.AutoSize = true;
            label_roomWidth.Location = new System.Drawing.Point(75, 42);
            label_roomWidth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_roomWidth.Name = "label_roomWidth";
            label_roomWidth.Size = new System.Drawing.Size(42, 15);
            label_roomWidth.TabIndex = 15;
            label_roomWidth.Text = "Width:";
            // 
            // comboBox_roomCopyRoom
            // 
            comboBox_roomCopyRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox_roomCopyRoom.FormattingEnabled = true;
            comboBox_roomCopyRoom.Location = new System.Drawing.Point(178, 107);
            comboBox_roomCopyRoom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            comboBox_roomCopyRoom.Name = "comboBox_roomCopyRoom";
            comboBox_roomCopyRoom.Size = new System.Drawing.Size(52, 23);
            comboBox_roomCopyRoom.TabIndex = 14;
            // 
            // textBox_roomHeight
            // 
            textBox_roomHeight.BorderColor = System.Drawing.Color.Black;
            textBox_roomHeight.DisplayBorder = true;
            textBox_roomHeight.Location = new System.Drawing.Point(230, 38);
            textBox_roomHeight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox_roomHeight.MaxLength = 32767;
            textBox_roomHeight.Multiline = false;
            textBox_roomHeight.Name = "textBox_roomHeight";
            textBox_roomHeight.OnTextChanged = null;
            textBox_roomHeight.Padding = new System.Windows.Forms.Padding(4, 3, 1, 2);
            textBox_roomHeight.ReadOnly = false;
            textBox_roomHeight.ScrollBars = System.Windows.Forms.ScrollBars.None;
            textBox_roomHeight.SelectionStart = 0;
            textBox_roomHeight.Size = new System.Drawing.Size(35, 23);
            textBox_roomHeight.TabIndex = 13;
            textBox_roomHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            textBox_roomHeight.WordWrap = true;
            // 
            // textBox_roomWidth
            // 
            textBox_roomWidth.BorderColor = System.Drawing.Color.Black;
            textBox_roomWidth.DisplayBorder = true;
            textBox_roomWidth.Location = new System.Drawing.Point(124, 38);
            textBox_roomWidth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox_roomWidth.MaxLength = 32767;
            textBox_roomWidth.Multiline = false;
            textBox_roomWidth.Name = "textBox_roomWidth";
            textBox_roomWidth.OnTextChanged = null;
            textBox_roomWidth.Padding = new System.Windows.Forms.Padding(4, 3, 1, 2);
            textBox_roomWidth.ReadOnly = false;
            textBox_roomWidth.ScrollBars = System.Windows.Forms.ScrollBars.None;
            textBox_roomWidth.SelectionStart = 0;
            textBox_roomWidth.Size = new System.Drawing.Size(35, 23);
            textBox_roomWidth.TabIndex = 12;
            textBox_roomWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            textBox_roomWidth.WordWrap = true;
            // 
            // comboBox_roomCopyArea
            // 
            comboBox_roomCopyArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox_roomCopyArea.FormattingEnabled = true;
            comboBox_roomCopyArea.Location = new System.Drawing.Point(78, 107);
            comboBox_roomCopyArea.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            comboBox_roomCopyArea.Name = "comboBox_roomCopyArea";
            comboBox_roomCopyArea.Size = new System.Drawing.Size(93, 23);
            comboBox_roomCopyArea.TabIndex = 11;
            comboBox_roomCopyArea.SelectedIndexChanged += comboBox_roomCopyArea_SelectedIndexChanged;
            // 
            // comboBox_roomArea
            // 
            comboBox_roomArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox_roomArea.FormattingEnabled = true;
            comboBox_roomArea.Location = new System.Drawing.Point(51, 7);
            comboBox_roomArea.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            comboBox_roomArea.Name = "comboBox_roomArea";
            comboBox_roomArea.Size = new System.Drawing.Size(93, 23);
            comboBox_roomArea.TabIndex = 10;
            // 
            // radioButton_roomBlank
            // 
            radioButton_roomBlank.AutoSize = true;
            radioButton_roomBlank.Location = new System.Drawing.Point(7, 39);
            radioButton_roomBlank.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioButton_roomBlank.Name = "radioButton_roomBlank";
            radioButton_roomBlank.Size = new System.Drawing.Size(54, 19);
            radioButton_roomBlank.TabIndex = 8;
            radioButton_roomBlank.Text = "Blank";
            radioButton_roomBlank.UseVisualStyleBackColor = true;
            radioButton_roomBlank.CheckedChanged += radioButton_option_CheckedChanged;
            // 
            // radioButton_roomCopy
            // 
            radioButton_roomCopy.AutoSize = true;
            radioButton_roomCopy.Location = new System.Drawing.Point(7, 108);
            radioButton_roomCopy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioButton_roomCopy.Name = "radioButton_roomCopy";
            radioButton_roomCopy.Size = new System.Drawing.Size(53, 19);
            radioButton_roomCopy.TabIndex = 9;
            radioButton_roomCopy.Text = "Copy";
            radioButton_roomCopy.UseVisualStyleBackColor = true;
            radioButton_roomCopy.CheckedChanged += radioButton_option_CheckedChanged;
            // 
            // tabPage_tileset
            // 
            tabPage_tileset.BackColor = System.Drawing.SystemColors.Control;
            tabPage_tileset.Controls.Add(comboBox_tileset);
            tabPage_tileset.Controls.Add(radioButton_tilesetBlank);
            tabPage_tileset.Controls.Add(radioButton_tilesetCopy);
            tabPage_tileset.Location = new System.Drawing.Point(4, 25);
            tabPage_tileset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPage_tileset.Name = "tabPage_tileset";
            tabPage_tileset.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPage_tileset.Size = new System.Drawing.Size(192, 71);
            tabPage_tileset.TabIndex = 2;
            tabPage_tileset.Text = "Tileset";
            // 
            // comboBox_tileset
            // 
            comboBox_tileset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox_tileset.FormattingEnabled = true;
            comboBox_tileset.Location = new System.Drawing.Point(71, 33);
            comboBox_tileset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            comboBox_tileset.Name = "comboBox_tileset";
            comboBox_tileset.Size = new System.Drawing.Size(58, 23);
            comboBox_tileset.TabIndex = 11;
            // 
            // radioButton_tilesetBlank
            // 
            radioButton_tilesetBlank.AutoSize = true;
            radioButton_tilesetBlank.Location = new System.Drawing.Point(7, 7);
            radioButton_tilesetBlank.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioButton_tilesetBlank.Name = "radioButton_tilesetBlank";
            radioButton_tilesetBlank.Size = new System.Drawing.Size(54, 19);
            radioButton_tilesetBlank.TabIndex = 9;
            radioButton_tilesetBlank.Text = "Blank";
            radioButton_tilesetBlank.UseVisualStyleBackColor = true;
            radioButton_tilesetBlank.CheckedChanged += radioButton_option_CheckedChanged;
            // 
            // radioButton_tilesetCopy
            // 
            radioButton_tilesetCopy.AutoSize = true;
            radioButton_tilesetCopy.Location = new System.Drawing.Point(7, 35);
            radioButton_tilesetCopy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioButton_tilesetCopy.Name = "radioButton_tilesetCopy";
            radioButton_tilesetCopy.Size = new System.Drawing.Size(53, 19);
            radioButton_tilesetCopy.TabIndex = 10;
            radioButton_tilesetCopy.Text = "Copy";
            radioButton_tilesetCopy.UseVisualStyleBackColor = true;
            radioButton_tilesetCopy.CheckedChanged += radioButton_option_CheckedChanged;
            // 
            // tabPage_spriteset
            // 
            tabPage_spriteset.BackColor = System.Drawing.SystemColors.Control;
            tabPage_spriteset.Controls.Add(comboBox_spriteset);
            tabPage_spriteset.Controls.Add(radioButton_spritesetBlank);
            tabPage_spriteset.Controls.Add(radioButton_spritesetCopy);
            tabPage_spriteset.Location = new System.Drawing.Point(4, 25);
            tabPage_spriteset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPage_spriteset.Name = "tabPage_spriteset";
            tabPage_spriteset.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPage_spriteset.Size = new System.Drawing.Size(192, 71);
            tabPage_spriteset.TabIndex = 3;
            tabPage_spriteset.Text = "Spriteset";
            // 
            // comboBox_spriteset
            // 
            comboBox_spriteset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox_spriteset.FormattingEnabled = true;
            comboBox_spriteset.Location = new System.Drawing.Point(71, 33);
            comboBox_spriteset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            comboBox_spriteset.Name = "comboBox_spriteset";
            comboBox_spriteset.Size = new System.Drawing.Size(58, 23);
            comboBox_spriteset.TabIndex = 14;
            // 
            // radioButton_spritesetBlank
            // 
            radioButton_spritesetBlank.AutoSize = true;
            radioButton_spritesetBlank.Location = new System.Drawing.Point(7, 7);
            radioButton_spritesetBlank.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioButton_spritesetBlank.Name = "radioButton_spritesetBlank";
            radioButton_spritesetBlank.Size = new System.Drawing.Size(54, 19);
            radioButton_spritesetBlank.TabIndex = 12;
            radioButton_spritesetBlank.Text = "Blank";
            radioButton_spritesetBlank.UseVisualStyleBackColor = true;
            radioButton_spritesetBlank.CheckedChanged += radioButton_option_CheckedChanged;
            // 
            // radioButton_spritesetCopy
            // 
            radioButton_spritesetCopy.AutoSize = true;
            radioButton_spritesetCopy.Location = new System.Drawing.Point(7, 35);
            radioButton_spritesetCopy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioButton_spritesetCopy.Name = "radioButton_spritesetCopy";
            radioButton_spritesetCopy.Size = new System.Drawing.Size(53, 19);
            radioButton_spritesetCopy.TabIndex = 13;
            radioButton_spritesetCopy.Text = "Copy";
            radioButton_spritesetCopy.UseVisualStyleBackColor = true;
            radioButton_spritesetCopy.CheckedChanged += radioButton_option_CheckedChanged;
            // 
            // tabPage_anim
            // 
            tabPage_anim.BackColor = System.Drawing.SystemColors.Control;
            tabPage_anim.Controls.Add(groupBox_animOptions);
            tabPage_anim.Controls.Add(groupBox_animSelect);
            tabPage_anim.Location = new System.Drawing.Point(4, 25);
            tabPage_anim.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPage_anim.Name = "tabPage_anim";
            tabPage_anim.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPage_anim.Size = new System.Drawing.Size(192, 71);
            tabPage_anim.TabIndex = 4;
            tabPage_anim.Text = "Animation";
            // 
            // groupBox_animOptions
            // 
            groupBox_animOptions.Controls.Add(comboBox_animNum);
            groupBox_animOptions.Controls.Add(radioButton_animBlank);
            groupBox_animOptions.Controls.Add(radioButton_animCopy);
            groupBox_animOptions.Location = new System.Drawing.Point(107, 7);
            groupBox_animOptions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox_animOptions.Name = "groupBox_animOptions";
            groupBox_animOptions.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox_animOptions.Size = new System.Drawing.Size(141, 106);
            groupBox_animOptions.TabIndex = 10;
            groupBox_animOptions.TabStop = false;
            groupBox_animOptions.Text = "Options";
            // 
            // comboBox_animNum
            // 
            comboBox_animNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox_animNum.FormattingEnabled = true;
            comboBox_animNum.Location = new System.Drawing.Point(71, 50);
            comboBox_animNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            comboBox_animNum.Name = "comboBox_animNum";
            comboBox_animNum.Size = new System.Drawing.Size(58, 23);
            comboBox_animNum.TabIndex = 12;
            // 
            // radioButton_animBlank
            // 
            radioButton_animBlank.AutoSize = true;
            radioButton_animBlank.Location = new System.Drawing.Point(7, 22);
            radioButton_animBlank.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioButton_animBlank.Name = "radioButton_animBlank";
            radioButton_animBlank.Size = new System.Drawing.Size(54, 19);
            radioButton_animBlank.TabIndex = 2;
            radioButton_animBlank.Text = "Blank";
            radioButton_animBlank.UseVisualStyleBackColor = true;
            radioButton_animBlank.CheckedChanged += radioButton_option_CheckedChanged;
            // 
            // radioButton_animCopy
            // 
            radioButton_animCopy.AutoSize = true;
            radioButton_animCopy.Location = new System.Drawing.Point(7, 51);
            radioButton_animCopy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioButton_animCopy.Name = "radioButton_animCopy";
            radioButton_animCopy.Size = new System.Drawing.Size(53, 19);
            radioButton_animCopy.TabIndex = 3;
            radioButton_animCopy.Text = "Copy";
            radioButton_animCopy.UseVisualStyleBackColor = true;
            radioButton_animCopy.CheckedChanged += radioButton_option_CheckedChanged;
            // 
            // groupBox_animSelect
            // 
            groupBox_animSelect.Controls.Add(radioButton_animTileset);
            groupBox_animSelect.Controls.Add(radioButton_animGfx);
            groupBox_animSelect.Controls.Add(radioButton_animPalette);
            groupBox_animSelect.Location = new System.Drawing.Point(7, 7);
            groupBox_animSelect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox_animSelect.Name = "groupBox_animSelect";
            groupBox_animSelect.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox_animSelect.Size = new System.Drawing.Size(93, 106);
            groupBox_animSelect.TabIndex = 3;
            groupBox_animSelect.TabStop = false;
            groupBox_animSelect.Text = "Select";
            // 
            // radioButton_animTileset
            // 
            radioButton_animTileset.AutoSize = true;
            radioButton_animTileset.Location = new System.Drawing.Point(7, 22);
            radioButton_animTileset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioButton_animTileset.Name = "radioButton_animTileset";
            radioButton_animTileset.Size = new System.Drawing.Size(58, 19);
            radioButton_animTileset.TabIndex = 0;
            radioButton_animTileset.TabStop = true;
            radioButton_animTileset.Text = "Tileset";
            radioButton_animTileset.UseVisualStyleBackColor = true;
            radioButton_animTileset.CheckedChanged += radioButton_animation_CheckedChanged;
            // 
            // radioButton_animGfx
            // 
            radioButton_animGfx.AutoSize = true;
            radioButton_animGfx.Location = new System.Drawing.Point(7, 48);
            radioButton_animGfx.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioButton_animGfx.Name = "radioButton_animGfx";
            radioButton_animGfx.Size = new System.Drawing.Size(71, 19);
            radioButton_animGfx.TabIndex = 2;
            radioButton_animGfx.TabStop = true;
            radioButton_animGfx.Text = "Graphics";
            radioButton_animGfx.UseVisualStyleBackColor = true;
            radioButton_animGfx.CheckedChanged += radioButton_animation_CheckedChanged;
            // 
            // radioButton_animPalette
            // 
            radioButton_animPalette.AutoSize = true;
            radioButton_animPalette.Location = new System.Drawing.Point(7, 75);
            radioButton_animPalette.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioButton_animPalette.Name = "radioButton_animPalette";
            radioButton_animPalette.Size = new System.Drawing.Size(61, 19);
            radioButton_animPalette.TabIndex = 1;
            radioButton_animPalette.TabStop = true;
            radioButton_animPalette.Text = "Palette";
            radioButton_animPalette.UseVisualStyleBackColor = true;
            radioButton_animPalette.CheckedChanged += radioButton_animation_CheckedChanged;
            // 
            // button_add
            // 
            button_add.Enabled = false;
            button_add.Location = new System.Drawing.Point(113, 192);
            button_add.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_add.Name = "button_add";
            button_add.Size = new System.Drawing.Size(88, 27);
            button_add.TabIndex = 6;
            button_add.Text = "Add";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
            // 
            // button_close
            // 
            button_close.Location = new System.Drawing.Point(208, 192);
            button_close.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_close.Name = "button_close";
            button_close.Size = new System.Drawing.Size(88, 27);
            button_close.TabIndex = 7;
            button_close.Text = "Close";
            button_close.UseVisualStyleBackColor = true;
            button_close.Click += button_close_Click;
            // 
            // FormAdd
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(314, 232);
            Controls.Add(button_close);
            Controls.Add(button_add);
            Controls.Add(tabControl);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "FormAdd";
            Text = "Add";
            tabControl.ResumeLayout(false);
            tabPage_bg.ResumeLayout(false);
            groupBox_bgOptions.ResumeLayout(false);
            groupBox_bgOptions.PerformLayout();
            groupBox_bgSelect.ResumeLayout(false);
            groupBox_bgSelect.PerformLayout();
            tabPage_roomSprites.ResumeLayout(false);
            tabPage_roomSprites.PerformLayout();
            tabPage_room.ResumeLayout(false);
            tabPage_room.PerformLayout();
            tabPage_tileset.ResumeLayout(false);
            tabPage_tileset.PerformLayout();
            tabPage_spriteset.ResumeLayout(false);
            tabPage_spriteset.PerformLayout();
            tabPage_anim.ResumeLayout(false);
            groupBox_animOptions.ResumeLayout(false);
            groupBox_animOptions.PerformLayout();
            groupBox_animSelect.ResumeLayout(false);
            groupBox_animSelect.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private mage.Theming.CustomControls.FlatTabControl tabControl;
        private System.Windows.Forms.TabPage tabPage_bg;
        private System.Windows.Forms.TabPage tabPage_room;
        private mage.Theming.CustomControls.FlatComboBox comboBox_bg;
        private System.Windows.Forms.RadioButton radioButton_bgCopy;
        private System.Windows.Forms.RadioButton radioButton_bgBlank;
        private mage.Theming.CustomControls.FlatTextBox textBox_bgOffset;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.TabPage tabPage_tileset;
        private System.Windows.Forms.TabPage tabPage_spriteset;
        private System.Windows.Forms.TabPage tabPage_anim;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.RadioButton radioButton_bgLZ77;
        private System.Windows.Forms.RadioButton radioButton_bgRLE;
        private System.Windows.Forms.GroupBox groupBox_bgSelect;
        private System.Windows.Forms.GroupBox groupBox_bgOptions;
        private System.Windows.Forms.TabPage tabPage_roomSprites;
        private mage.Theming.CustomControls.FlatComboBox comboBox_enemySet;
        private System.Windows.Forms.RadioButton radioButton_enemyBlank;
        private System.Windows.Forms.RadioButton radioButton_enemyCopy;
        private mage.Theming.CustomControls.FlatTextBox textBox_enemyOffset;
        private mage.Theming.CustomControls.FlatComboBox comboBox_roomArea;
        private System.Windows.Forms.RadioButton radioButton_roomBlank;
        private System.Windows.Forms.RadioButton radioButton_roomCopy;
        private mage.Theming.CustomControls.FlatComboBox comboBox_roomCopyArea;
        private mage.Theming.CustomControls.FlatTextBox textBox_roomHeight;
        private mage.Theming.CustomControls.FlatTextBox textBox_roomWidth;
        private mage.Theming.CustomControls.FlatComboBox comboBox_roomCopyRoom;
        private System.Windows.Forms.Label label_roomHeight;
        private System.Windows.Forms.Label label_roomWidth;
        private System.Windows.Forms.Label label_roomArea;
        private System.Windows.Forms.RadioButton radioButton_animGfx;
        private System.Windows.Forms.RadioButton radioButton_animPalette;
        private System.Windows.Forms.RadioButton radioButton_animTileset;
        private System.Windows.Forms.GroupBox groupBox_animSelect;
        private System.Windows.Forms.Label label_enemySpriteset;
        private mage.Theming.CustomControls.FlatComboBox comboBox_tileset;
        private System.Windows.Forms.RadioButton radioButton_tilesetBlank;
        private System.Windows.Forms.RadioButton radioButton_tilesetCopy;
        private mage.Theming.CustomControls.FlatComboBox comboBox_spriteset;
        private System.Windows.Forms.RadioButton radioButton_spritesetBlank;
        private System.Windows.Forms.RadioButton radioButton_spritesetCopy;
        private System.Windows.Forms.GroupBox groupBox_animOptions;
        private System.Windows.Forms.RadioButton radioButton_animBlank;
        private System.Windows.Forms.RadioButton radioButton_animCopy;
        private mage.Theming.CustomControls.FlatComboBox comboBox_animNum;
        private System.Windows.Forms.CheckBox chb_screens;
    }
}