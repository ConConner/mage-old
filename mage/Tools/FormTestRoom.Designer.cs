namespace mage
{
    partial class FormTestRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTestRoom));
            textBox_xPos = new Theming.CustomControls.FlatTextBox();
            textBox_yPos = new Theming.CustomControls.FlatTextBox();
            pbx_Background = new PictureBoxInterpolation();
            chb_long = new PictureBoxInterpolation();
            chb_charge = new PictureBoxInterpolation();
            chb_ice = new PictureBoxInterpolation();
            chb_wave = new PictureBoxInterpolation();
            chb_plasma = new PictureBoxInterpolation();
            chb_bombs = new PictureBoxInterpolation();
            chb_varia = new PictureBoxInterpolation();
            chb_gravity = new PictureBoxInterpolation();
            chb_morph = new PictureBoxInterpolation();
            chb_grip = new PictureBoxInterpolation();
            chb_speed = new PictureBoxInterpolation();
            chb_hijump = new PictureBoxInterpolation();
            chb_screw = new PictureBoxInterpolation();
            chb_space = new PictureBoxInterpolation();
            txb_missile_cur = new Theming.CustomControls.FlatTextBox();
            txb_missile_max = new Theming.CustomControls.FlatTextBox();
            txb_supers_cur = new Theming.CustomControls.FlatTextBox();
            txb_supers_max = new Theming.CustomControls.FlatTextBox();
            txb_energy_cur = new Theming.CustomControls.FlatTextBox();
            txb_energy_max = new Theming.CustomControls.FlatTextBox();
            txb_power_cur = new Theming.CustomControls.FlatTextBox();
            txb_power_max = new Theming.CustomControls.FlatTextBox();
            btn_play = new PictureBoxInterpolation();
            btn_cancel = new PictureBoxInterpolation();
            cbb_suit_type = new Theming.CustomControls.FlatComboBox();
            chb_debug = new PictureBoxInterpolation();
            pbx_suit = new PictureBoxInterpolation();
            ((System.ComponentModel.ISupportInitialize)pbx_Background).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chb_long).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chb_charge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chb_ice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chb_wave).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chb_plasma).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chb_bombs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chb_varia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chb_gravity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chb_morph).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chb_grip).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chb_speed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chb_hijump).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chb_screw).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chb_space).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_play).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_cancel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chb_debug).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx_suit).BeginInit();
            SuspendLayout();
            // 
            // textBox_xPos
            // 
            textBox_xPos.BorderColor = System.Drawing.Color.Black;
            textBox_xPos.DisplayBorder = true;
            textBox_xPos.Location = new System.Drawing.Point(42, 421);
            textBox_xPos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox_xPos.MaxLength = 2;
            textBox_xPos.Multiline = false;
            textBox_xPos.Name = "textBox_xPos";
            textBox_xPos.OnTextChanged = null;
            textBox_xPos.Padding = new System.Windows.Forms.Padding(3, 5, 3, 0);
            textBox_xPos.ReadOnly = false;
            textBox_xPos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            textBox_xPos.SelectionStart = 0;
            textBox_xPos.Size = new System.Drawing.Size(52, 23);
            textBox_xPos.TabIndex = 0;
            textBox_xPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            textBox_xPos.WordWrap = true;
            // 
            // textBox_yPos
            // 
            textBox_yPos.BorderColor = System.Drawing.Color.Black;
            textBox_yPos.DisplayBorder = true;
            textBox_yPos.Location = new System.Drawing.Point(122, 421);
            textBox_yPos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox_yPos.MaxLength = 2;
            textBox_yPos.Multiline = false;
            textBox_yPos.Name = "textBox_yPos";
            textBox_yPos.OnTextChanged = null;
            textBox_yPos.Padding = new System.Windows.Forms.Padding(3, 5, 3, 0);
            textBox_yPos.ReadOnly = false;
            textBox_yPos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            textBox_yPos.SelectionStart = 0;
            textBox_yPos.Size = new System.Drawing.Size(52, 23);
            textBox_yPos.TabIndex = 1;
            textBox_yPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            textBox_yPos.WordWrap = true;
            // 
            // pbx_Background
            // 
            pbx_Background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pbx_Background.Checked = false;
            pbx_Background.Image = Properties.Resources.status_screen;
            pbx_Background.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            pbx_Background.Location = new System.Drawing.Point(0, 0);
            pbx_Background.Name = "pbx_Background";
            pbx_Background.Size = new System.Drawing.Size(720, 480);
            pbx_Background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pbx_Background.TabIndex = 5;
            pbx_Background.TabStop = false;
            // 
            // chb_long
            // 
            chb_long.Checked = false;
            chb_long.Image = Properties.Resources.item_disabled;
            chb_long.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            chb_long.Location = new System.Drawing.Point(24, 123);
            chb_long.Name = "chb_long";
            chb_long.Size = new System.Drawing.Size(21, 21);
            chb_long.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            chb_long.TabIndex = 6;
            chb_long.TabStop = false;
            chb_long.Tag = "LongBeam";
            chb_long.Click += chb_beams_bombs_click;
            // 
            // chb_charge
            // 
            chb_charge.Checked = false;
            chb_charge.Image = Properties.Resources.item_disabled;
            chb_charge.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            chb_charge.Location = new System.Drawing.Point(24, 147);
            chb_charge.Name = "chb_charge";
            chb_charge.Size = new System.Drawing.Size(21, 21);
            chb_charge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            chb_charge.TabIndex = 7;
            chb_charge.TabStop = false;
            chb_charge.Tag = "ChargeBeam";
            chb_charge.Click += chb_beams_bombs_click;
            // 
            // chb_ice
            // 
            chb_ice.Checked = false;
            chb_ice.Image = Properties.Resources.item_disabled;
            chb_ice.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            chb_ice.Location = new System.Drawing.Point(24, 171);
            chb_ice.Name = "chb_ice";
            chb_ice.Size = new System.Drawing.Size(21, 21);
            chb_ice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            chb_ice.TabIndex = 8;
            chb_ice.TabStop = false;
            chb_ice.Tag = "IceBeam";
            chb_ice.Click += chb_beams_bombs_click;
            // 
            // chb_wave
            // 
            chb_wave.Checked = false;
            chb_wave.Image = Properties.Resources.item_disabled;
            chb_wave.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            chb_wave.Location = new System.Drawing.Point(24, 195);
            chb_wave.Name = "chb_wave";
            chb_wave.Size = new System.Drawing.Size(21, 21);
            chb_wave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            chb_wave.TabIndex = 9;
            chb_wave.TabStop = false;
            chb_wave.Tag = "WaveBeam";
            chb_wave.Click += chb_beams_bombs_click;
            // 
            // chb_plasma
            // 
            chb_plasma.Checked = false;
            chb_plasma.Image = Properties.Resources.item_disabled;
            chb_plasma.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            chb_plasma.Location = new System.Drawing.Point(24, 219);
            chb_plasma.Name = "chb_plasma";
            chb_plasma.Size = new System.Drawing.Size(21, 21);
            chb_plasma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            chb_plasma.TabIndex = 10;
            chb_plasma.TabStop = false;
            chb_plasma.Tag = "PlasmaBeam";
            chb_plasma.Click += chb_beams_bombs_click;
            // 
            // chb_bombs
            // 
            chb_bombs.Checked = false;
            chb_bombs.Image = Properties.Resources.item_disabled;
            chb_bombs.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            chb_bombs.Location = new System.Drawing.Point(456, 75);
            chb_bombs.Name = "chb_bombs";
            chb_bombs.Size = new System.Drawing.Size(21, 21);
            chb_bombs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            chb_bombs.TabIndex = 11;
            chb_bombs.TabStop = false;
            chb_bombs.Tag = "Bombs";
            chb_bombs.Click += chb_beams_bombs_click;
            // 
            // chb_varia
            // 
            chb_varia.Checked = false;
            chb_varia.Image = Properties.Resources.item_disabled;
            chb_varia.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            chb_varia.Location = new System.Drawing.Point(504, 147);
            chb_varia.Name = "chb_varia";
            chb_varia.Size = new System.Drawing.Size(21, 21);
            chb_varia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            chb_varia.TabIndex = 12;
            chb_varia.TabStop = false;
            chb_varia.Tag = "VariaSuit";
            chb_varia.Click += chb_items_click;
            // 
            // chb_gravity
            // 
            chb_gravity.Checked = false;
            chb_gravity.Image = Properties.Resources.item_disabled;
            chb_gravity.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            chb_gravity.Location = new System.Drawing.Point(504, 171);
            chb_gravity.Name = "chb_gravity";
            chb_gravity.Size = new System.Drawing.Size(21, 21);
            chb_gravity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            chb_gravity.TabIndex = 13;
            chb_gravity.TabStop = false;
            chb_gravity.Tag = "GravitySuit";
            chb_gravity.Click += chb_items_click;
            // 
            // chb_morph
            // 
            chb_morph.Checked = false;
            chb_morph.Image = Properties.Resources.item_disabled;
            chb_morph.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            chb_morph.Location = new System.Drawing.Point(504, 243);
            chb_morph.Name = "chb_morph";
            chb_morph.Size = new System.Drawing.Size(21, 21);
            chb_morph.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            chb_morph.TabIndex = 14;
            chb_morph.TabStop = false;
            chb_morph.Tag = "MorphBall";
            chb_morph.Click += chb_items_click;
            // 
            // chb_grip
            // 
            chb_grip.Checked = false;
            chb_grip.Image = Properties.Resources.item_disabled;
            chb_grip.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            chb_grip.Location = new System.Drawing.Point(504, 267);
            chb_grip.Name = "chb_grip";
            chb_grip.Size = new System.Drawing.Size(21, 21);
            chb_grip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            chb_grip.TabIndex = 15;
            chb_grip.TabStop = false;
            chb_grip.Tag = "PowerGrip";
            chb_grip.Click += chb_items_click;
            // 
            // chb_speed
            // 
            chb_speed.Checked = false;
            chb_speed.Image = Properties.Resources.item_disabled;
            chb_speed.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            chb_speed.Location = new System.Drawing.Point(504, 291);
            chb_speed.Name = "chb_speed";
            chb_speed.Size = new System.Drawing.Size(21, 21);
            chb_speed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            chb_speed.TabIndex = 16;
            chb_speed.TabStop = false;
            chb_speed.Tag = "SpeedBooster";
            chb_speed.Click += chb_items_click;
            // 
            // chb_hijump
            // 
            chb_hijump.Checked = false;
            chb_hijump.Image = Properties.Resources.item_disabled;
            chb_hijump.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            chb_hijump.Location = new System.Drawing.Point(504, 315);
            chb_hijump.Name = "chb_hijump";
            chb_hijump.Size = new System.Drawing.Size(21, 21);
            chb_hijump.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            chb_hijump.TabIndex = 17;
            chb_hijump.TabStop = false;
            chb_hijump.Tag = "HiJump";
            chb_hijump.Click += chb_items_click;
            // 
            // chb_screw
            // 
            chb_screw.Checked = false;
            chb_screw.Image = Properties.Resources.item_disabled;
            chb_screw.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            chb_screw.Location = new System.Drawing.Point(504, 339);
            chb_screw.Name = "chb_screw";
            chb_screw.Size = new System.Drawing.Size(21, 21);
            chb_screw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            chb_screw.TabIndex = 18;
            chb_screw.TabStop = false;
            chb_screw.Tag = "ScrewAttack";
            chb_screw.Click += chb_items_click;
            // 
            // chb_space
            // 
            chb_space.Checked = false;
            chb_space.Image = Properties.Resources.item_disabled;
            chb_space.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            chb_space.Location = new System.Drawing.Point(504, 363);
            chb_space.Name = "chb_space";
            chb_space.Size = new System.Drawing.Size(21, 21);
            chb_space.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            chb_space.TabIndex = 19;
            chb_space.TabStop = false;
            chb_space.Tag = "SpaceJump";
            chb_space.Click += chb_items_click;
            // 
            // txb_missile_cur
            // 
            txb_missile_cur.BackColor = System.Drawing.Color.Black;
            txb_missile_cur.BorderColor = System.Drawing.Color.Transparent;
            txb_missile_cur.DisplayBorder = true;
            txb_missile_cur.Location = new System.Drawing.Point(24, 313);
            txb_missile_cur.MaxLength = 4;
            txb_missile_cur.Multiline = false;
            txb_missile_cur.Name = "txb_missile_cur";
            txb_missile_cur.OnTextChanged = null;
            txb_missile_cur.Padding = new System.Windows.Forms.Padding(3, 5, 3, 0);
            txb_missile_cur.ReadOnly = false;
            txb_missile_cur.ScrollBars = System.Windows.Forms.ScrollBars.None;
            txb_missile_cur.SelectionStart = 0;
            txb_missile_cur.Size = new System.Drawing.Size(70, 23);
            txb_missile_cur.TabIndex = 20;
            txb_missile_cur.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            txb_missile_cur.WordWrap = true;
            // 
            // txb_missile_max
            // 
            txb_missile_max.BackColor = System.Drawing.Color.Black;
            txb_missile_max.BorderColor = System.Drawing.Color.Transparent;
            txb_missile_max.DisplayBorder = true;
            txb_missile_max.Location = new System.Drawing.Point(122, 313);
            txb_missile_max.MaxLength = 4;
            txb_missile_max.Multiline = false;
            txb_missile_max.Name = "txb_missile_max";
            txb_missile_max.OnTextChanged = null;
            txb_missile_max.Padding = new System.Windows.Forms.Padding(3, 5, 3, 0);
            txb_missile_max.ReadOnly = false;
            txb_missile_max.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txb_missile_max.ScrollBars = System.Windows.Forms.ScrollBars.None;
            txb_missile_max.SelectionStart = 0;
            txb_missile_max.Size = new System.Drawing.Size(70, 23);
            txb_missile_max.TabIndex = 21;
            txb_missile_max.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            txb_missile_max.WordWrap = true;
            // 
            // txb_supers_cur
            // 
            txb_supers_cur.BackColor = System.Drawing.Color.Black;
            txb_supers_cur.BorderColor = System.Drawing.Color.Transparent;
            txb_supers_cur.DisplayBorder = true;
            txb_supers_cur.Location = new System.Drawing.Point(24, 362);
            txb_supers_cur.MaxLength = 3;
            txb_supers_cur.Multiline = false;
            txb_supers_cur.Name = "txb_supers_cur";
            txb_supers_cur.OnTextChanged = null;
            txb_supers_cur.Padding = new System.Windows.Forms.Padding(3, 5, 3, 0);
            txb_supers_cur.ReadOnly = false;
            txb_supers_cur.ScrollBars = System.Windows.Forms.ScrollBars.None;
            txb_supers_cur.SelectionStart = 0;
            txb_supers_cur.Size = new System.Drawing.Size(70, 23);
            txb_supers_cur.TabIndex = 22;
            txb_supers_cur.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            txb_supers_cur.WordWrap = true;
            // 
            // txb_supers_max
            // 
            txb_supers_max.BackColor = System.Drawing.Color.Black;
            txb_supers_max.BorderColor = System.Drawing.Color.Transparent;
            txb_supers_max.DisplayBorder = true;
            txb_supers_max.Location = new System.Drawing.Point(122, 362);
            txb_supers_max.MaxLength = 3;
            txb_supers_max.Multiline = false;
            txb_supers_max.Name = "txb_supers_max";
            txb_supers_max.OnTextChanged = null;
            txb_supers_max.Padding = new System.Windows.Forms.Padding(3, 5, 3, 0);
            txb_supers_max.ReadOnly = false;
            txb_supers_max.ScrollBars = System.Windows.Forms.ScrollBars.None;
            txb_supers_max.SelectionStart = 0;
            txb_supers_max.Size = new System.Drawing.Size(70, 23);
            txb_supers_max.TabIndex = 23;
            txb_supers_max.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            txb_supers_max.WordWrap = true;
            // 
            // txb_energy_cur
            // 
            txb_energy_cur.BackColor = System.Drawing.Color.Black;
            txb_energy_cur.BorderColor = System.Drawing.Color.Transparent;
            txb_energy_cur.DisplayBorder = true;
            txb_energy_cur.Location = new System.Drawing.Point(191, 49);
            txb_energy_cur.MaxLength = 4;
            txb_energy_cur.Multiline = false;
            txb_energy_cur.Name = "txb_energy_cur";
            txb_energy_cur.OnTextChanged = null;
            txb_energy_cur.Padding = new System.Windows.Forms.Padding(3, 5, 3, 0);
            txb_energy_cur.ReadOnly = false;
            txb_energy_cur.ScrollBars = System.Windows.Forms.ScrollBars.None;
            txb_energy_cur.SelectionStart = 0;
            txb_energy_cur.Size = new System.Drawing.Size(98, 23);
            txb_energy_cur.TabIndex = 24;
            txb_energy_cur.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            txb_energy_cur.WordWrap = true;
            // 
            // txb_energy_max
            // 
            txb_energy_max.BackColor = System.Drawing.Color.Black;
            txb_energy_max.BorderColor = System.Drawing.Color.Transparent;
            txb_energy_max.DisplayBorder = true;
            txb_energy_max.Location = new System.Drawing.Point(314, 49);
            txb_energy_max.MaxLength = 4;
            txb_energy_max.Multiline = false;
            txb_energy_max.Name = "txb_energy_max";
            txb_energy_max.OnTextChanged = null;
            txb_energy_max.Padding = new System.Windows.Forms.Padding(3, 5, 3, 0);
            txb_energy_max.ReadOnly = false;
            txb_energy_max.ScrollBars = System.Windows.Forms.ScrollBars.None;
            txb_energy_max.SelectionStart = 0;
            txb_energy_max.Size = new System.Drawing.Size(94, 23);
            txb_energy_max.TabIndex = 25;
            txb_energy_max.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            txb_energy_max.WordWrap = true;
            // 
            // txb_power_cur
            // 
            txb_power_cur.BackColor = System.Drawing.Color.Black;
            txb_power_cur.BorderColor = System.Drawing.Color.Transparent;
            txb_power_cur.DisplayBorder = true;
            txb_power_cur.Location = new System.Drawing.Point(579, 97);
            txb_power_cur.MaxLength = 2;
            txb_power_cur.Multiline = false;
            txb_power_cur.Name = "txb_power_cur";
            txb_power_cur.OnTextChanged = null;
            txb_power_cur.Padding = new System.Windows.Forms.Padding(3, 5, 3, 0);
            txb_power_cur.ReadOnly = false;
            txb_power_cur.ScrollBars = System.Windows.Forms.ScrollBars.None;
            txb_power_cur.SelectionStart = 0;
            txb_power_cur.Size = new System.Drawing.Size(42, 23);
            txb_power_cur.TabIndex = 26;
            txb_power_cur.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            txb_power_cur.WordWrap = true;
            // 
            // txb_power_max
            // 
            txb_power_max.BackColor = System.Drawing.Color.Black;
            txb_power_max.BorderColor = System.Drawing.Color.Transparent;
            txb_power_max.DisplayBorder = true;
            txb_power_max.Location = new System.Drawing.Point(650, 97);
            txb_power_max.MaxLength = 2;
            txb_power_max.Multiline = false;
            txb_power_max.Name = "txb_power_max";
            txb_power_max.OnTextChanged = null;
            txb_power_max.Padding = new System.Windows.Forms.Padding(3, 5, 3, 0);
            txb_power_max.ReadOnly = false;
            txb_power_max.ScrollBars = System.Windows.Forms.ScrollBars.None;
            txb_power_max.SelectionStart = 0;
            txb_power_max.Size = new System.Drawing.Size(47, 23);
            txb_power_max.TabIndex = 27;
            txb_power_max.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            txb_power_max.WordWrap = true;
            // 
            // btn_play
            // 
            btn_play.Checked = false;
            btn_play.Image = Properties.Resources.test_play;
            btn_play.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            btn_play.Location = new System.Drawing.Point(570, -1);
            btn_play.Name = "btn_play";
            btn_play.Size = new System.Drawing.Size(150, 39);
            btn_play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            btn_play.TabIndex = 28;
            btn_play.TabStop = false;
            btn_play.Click += button_go_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.Checked = false;
            btn_cancel.Image = Properties.Resources.test_cancel;
            btn_cancel.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            btn_cancel.Location = new System.Drawing.Point(0, 0);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new System.Drawing.Size(150, 39);
            btn_cancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            btn_cancel.TabIndex = 29;
            btn_cancel.TabStop = false;
            btn_cancel.Click += button_cancel_Click;
            // 
            // cbb_suit_type
            // 
            cbb_suit_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbb_suit_type.FormattingEnabled = true;
            cbb_suit_type.Items.AddRange(new object[] { "Normal Suit", "Fully Powered Suit", "Zero Suit" });
            cbb_suit_type.Location = new System.Drawing.Point(277, 420);
            cbb_suit_type.Name = "cbb_suit_type";
            cbb_suit_type.Size = new System.Drawing.Size(121, 23);
            cbb_suit_type.TabIndex = 30;
            cbb_suit_type.SelectedIndexChanged += cbb_suit_type_SelectedIndexChanged;
            // 
            // chb_debug
            // 
            chb_debug.Checked = false;
            chb_debug.Image = Properties.Resources.item_disabled;
            chb_debug.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            chb_debug.Location = new System.Drawing.Point(504, 423);
            chb_debug.Name = "chb_debug";
            chb_debug.Size = new System.Drawing.Size(21, 21);
            chb_debug.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            chb_debug.TabIndex = 31;
            chb_debug.TabStop = false;
            chb_debug.Tag = "SpaceJump";
            chb_debug.Click += chb_debug_Click;
            // 
            // pbx_suit
            // 
            pbx_suit.Checked = false;
            pbx_suit.Image = Properties.Resources.item_full_gravity;
            pbx_suit.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            pbx_suit.Location = new System.Drawing.Point(267, 120);
            pbx_suit.Name = "pbx_suit";
            pbx_suit.Size = new System.Drawing.Size(141, 264);
            pbx_suit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pbx_suit.TabIndex = 32;
            pbx_suit.TabStop = false;
            // 
            // FormTestRoom
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            ClientSize = new System.Drawing.Size(720, 480);
            Controls.Add(pbx_suit);
            Controls.Add(chb_debug);
            Controls.Add(cbb_suit_type);
            Controls.Add(btn_cancel);
            Controls.Add(btn_play);
            Controls.Add(textBox_yPos);
            Controls.Add(textBox_xPos);
            Controls.Add(txb_power_max);
            Controls.Add(txb_power_cur);
            Controls.Add(txb_energy_max);
            Controls.Add(txb_energy_cur);
            Controls.Add(txb_supers_max);
            Controls.Add(txb_supers_cur);
            Controls.Add(txb_missile_max);
            Controls.Add(txb_missile_cur);
            Controls.Add(chb_space);
            Controls.Add(chb_screw);
            Controls.Add(chb_hijump);
            Controls.Add(chb_speed);
            Controls.Add(chb_grip);
            Controls.Add(chb_morph);
            Controls.Add(chb_gravity);
            Controls.Add(chb_varia);
            Controls.Add(chb_bombs);
            Controls.Add(chb_plasma);
            Controls.Add(chb_wave);
            Controls.Add(chb_ice);
            Controls.Add(chb_charge);
            Controls.Add(chb_long);
            Controls.Add(pbx_Background);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "FormTestRoom";
            Text = "Test Room";
            ((System.ComponentModel.ISupportInitialize)pbx_Background).EndInit();
            ((System.ComponentModel.ISupportInitialize)chb_long).EndInit();
            ((System.ComponentModel.ISupportInitialize)chb_charge).EndInit();
            ((System.ComponentModel.ISupportInitialize)chb_ice).EndInit();
            ((System.ComponentModel.ISupportInitialize)chb_wave).EndInit();
            ((System.ComponentModel.ISupportInitialize)chb_plasma).EndInit();
            ((System.ComponentModel.ISupportInitialize)chb_bombs).EndInit();
            ((System.ComponentModel.ISupportInitialize)chb_varia).EndInit();
            ((System.ComponentModel.ISupportInitialize)chb_gravity).EndInit();
            ((System.ComponentModel.ISupportInitialize)chb_morph).EndInit();
            ((System.ComponentModel.ISupportInitialize)chb_grip).EndInit();
            ((System.ComponentModel.ISupportInitialize)chb_speed).EndInit();
            ((System.ComponentModel.ISupportInitialize)chb_hijump).EndInit();
            ((System.ComponentModel.ISupportInitialize)chb_screw).EndInit();
            ((System.ComponentModel.ISupportInitialize)chb_space).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_play).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_cancel).EndInit();
            ((System.ComponentModel.ISupportInitialize)chb_debug).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx_suit).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private mage.Theming.CustomControls.FlatTextBox textBox_xPos;
        private mage.Theming.CustomControls.FlatTextBox textBox_yPos;
        private PictureBoxInterpolation pbx_Background;
        private PictureBoxInterpolation chb_long;
        private PictureBoxInterpolation chb_charge;
        private PictureBoxInterpolation chb_ice;
        private PictureBoxInterpolation chb_wave;
        private PictureBoxInterpolation chb_plasma;
        private PictureBoxInterpolation chb_bombs;
        private PictureBoxInterpolation chb_varia;
        private PictureBoxInterpolation chb_gravity;
        private PictureBoxInterpolation chb_morph;
        private PictureBoxInterpolation chb_grip;
        private PictureBoxInterpolation chb_speed;
        private PictureBoxInterpolation chb_hijump;
        private PictureBoxInterpolation chb_screw;
        private PictureBoxInterpolation chb_space;
        private Theming.CustomControls.FlatTextBox txb_missile_cur;
        private Theming.CustomControls.FlatTextBox txb_missile_max;
        private Theming.CustomControls.FlatTextBox txb_supers_cur;
        private Theming.CustomControls.FlatTextBox txb_supers_max;
        private Theming.CustomControls.FlatTextBox txb_energy_cur;
        private Theming.CustomControls.FlatTextBox txb_energy_max;
        private Theming.CustomControls.FlatTextBox txb_power_cur;
        private Theming.CustomControls.FlatTextBox txb_power_max;
        private PictureBoxInterpolation btn_play;
        private PictureBoxInterpolation btn_cancel;
        private Theming.CustomControls.FlatComboBox cbb_suit_type;
        private PictureBoxInterpolation chb_debug;
        private PictureBoxInterpolation pbx_suit;
    }
}