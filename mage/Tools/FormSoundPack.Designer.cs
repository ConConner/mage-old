namespace mage.Tools
{
    partial class FormSoundPack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSoundPack));
            btn_select_path = new System.Windows.Forms.Button();
            lst_packs = new System.Windows.Forms.ListBox();
            grp_info = new System.Windows.Forms.GroupBox();
            txb_info = new Theming.CustomControls.FlatTextBox();
            grp_info.SuspendLayout();
            SuspendLayout();
            // 
            // btn_select_path
            // 
            btn_select_path.Image = Properties.Resources.toolbar_open;
            btn_select_path.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn_select_path.Location = new System.Drawing.Point(12, 12);
            btn_select_path.Name = "btn_select_path";
            btn_select_path.Size = new System.Drawing.Size(155, 27);
            btn_select_path.TabIndex = 1;
            btn_select_path.Text = "Set Soundpacks Path";
            btn_select_path.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btn_select_path.UseVisualStyleBackColor = true;
            btn_select_path.Click += btn_select_path_Click;
            // 
            // lst_packs
            // 
            lst_packs.FormattingEnabled = true;
            lst_packs.ItemHeight = 15;
            lst_packs.Location = new System.Drawing.Point(12, 45);
            lst_packs.Name = "lst_packs";
            lst_packs.Size = new System.Drawing.Size(155, 229);
            lst_packs.TabIndex = 2;
            lst_packs.SelectedIndexChanged += lst_packs_SelectedIndexChanged;
            // 
            // grp_info
            // 
            grp_info.Controls.Add(txb_info);
            grp_info.Location = new System.Drawing.Point(173, 12);
            grp_info.Name = "grp_info";
            grp_info.Size = new System.Drawing.Size(301, 260);
            grp_info.TabIndex = 3;
            grp_info.TabStop = false;
            grp_info.Text = "Pack Info";
            // 
            // txb_info
            // 
            txb_info.BorderColor = System.Drawing.Color.Black;
            txb_info.DisplayBorder = true;
            txb_info.Location = new System.Drawing.Point(6, 22);
            txb_info.MaxLength = 32767;
            txb_info.Multiline = true;
            txb_info.Name = "txb_info";
            txb_info.OnTextChanged = null;
            txb_info.Padding = new System.Windows.Forms.Padding(3, 3, 1, 2);
            txb_info.ReadOnly = false;
            txb_info.ScrollBars = System.Windows.Forms.ScrollBars.None;
            txb_info.SelectionStart = 0;
            txb_info.Size = new System.Drawing.Size(289, 232);
            txb_info.TabIndex = 0;
            txb_info.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            txb_info.WordWrap = true;
            // 
            // FormSoundPack
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            ClientSize = new System.Drawing.Size(486, 284);
            Controls.Add(grp_info);
            Controls.Add(lst_packs);
            Controls.Add(btn_select_path);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "FormSoundPack";
            Text = "Soundpack Settings";
            grp_info.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button btn_select_path;
        private System.Windows.Forms.ListBox lst_packs;
        private System.Windows.Forms.GroupBox grp_info;
        private Theming.CustomControls.FlatTextBox txb_info;
    }
}