namespace mage.Tools
{
    partial class FormOffsetGrabber
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
            lbl_clip = new System.Windows.Forms.Label();
            lbl_bg = new System.Windows.Forms.Label();
            txb_clip = new Theming.CustomControls.FlatTextBox();
            txb_bg = new Theming.CustomControls.FlatTextBox();
            lbl_mmx = new System.Windows.Forms.Label();
            lbl_mmy = new System.Windows.Forms.Label();
            txb_mmx = new Theming.CustomControls.FlatTextBox();
            txb_mmy = new Theming.CustomControls.FlatTextBox();
            SuspendLayout();
            // 
            // lbl_clip
            // 
            lbl_clip.AutoSize = true;
            lbl_clip.Location = new System.Drawing.Point(12, 15);
            lbl_clip.Name = "lbl_clip";
            lbl_clip.Size = new System.Drawing.Size(89, 15);
            lbl_clip.TabIndex = 0;
            lbl_clip.Text = "Clipdata Offset:";
            // 
            // lbl_bg
            // 
            lbl_bg.AutoSize = true;
            lbl_bg.Location = new System.Drawing.Point(12, 44);
            lbl_bg.Name = "lbl_bg";
            lbl_bg.Size = new System.Drawing.Size(65, 15);
            lbl_bg.TabIndex = 1;
            lbl_bg.Text = "Bg1 Offset:";
            // 
            // txb_clip
            // 
            txb_clip.BorderColor = System.Drawing.Color.Black;
            txb_clip.Location = new System.Drawing.Point(107, 12);
            txb_clip.Multiline = false;
            txb_clip.Name = "txb_clip";
            txb_clip.OnTextChanged = null;
            txb_clip.Padding = new System.Windows.Forms.Padding(3, 3, 1, 2);
            txb_clip.ReadOnly = true;
            txb_clip.ScrollBars = System.Windows.Forms.ScrollBars.None;
            txb_clip.SelectionStart = 0;
            txb_clip.Size = new System.Drawing.Size(100, 23);
            txb_clip.TabIndex = 2;
            txb_clip.WordWrap = true;
            // 
            // txb_bg
            // 
            txb_bg.BorderColor = System.Drawing.Color.Black;
            txb_bg.Location = new System.Drawing.Point(107, 41);
            txb_bg.Multiline = false;
            txb_bg.Name = "txb_bg";
            txb_bg.OnTextChanged = null;
            txb_bg.Padding = new System.Windows.Forms.Padding(3, 3, 1, 2);
            txb_bg.ReadOnly = true;
            txb_bg.ScrollBars = System.Windows.Forms.ScrollBars.None;
            txb_bg.SelectionStart = 0;
            txb_bg.Size = new System.Drawing.Size(100, 23);
            txb_bg.TabIndex = 3;
            txb_bg.WordWrap = true;
            // 
            // lbl_mmx
            // 
            lbl_mmx.AutoSize = true;
            lbl_mmx.Location = new System.Drawing.Point(213, 15);
            lbl_mmx.Name = "lbl_mmx";
            lbl_mmx.Size = new System.Drawing.Size(68, 15);
            lbl_mmx.TabIndex = 4;
            lbl_mmx.Text = "Minimap X:";
            // 
            // lbl_mmy
            // 
            lbl_mmy.AutoSize = true;
            lbl_mmy.Location = new System.Drawing.Point(213, 44);
            lbl_mmy.Name = "lbl_mmy";
            lbl_mmy.Size = new System.Drawing.Size(65, 15);
            lbl_mmy.TabIndex = 5;
            lbl_mmy.Text = "Minimap Y";
            // 
            // txb_mmx
            // 
            txb_mmx.BorderColor = System.Drawing.Color.Black;
            txb_mmx.Location = new System.Drawing.Point(287, 12);
            txb_mmx.Multiline = false;
            txb_mmx.Name = "txb_mmx";
            txb_mmx.OnTextChanged = null;
            txb_mmx.Padding = new System.Windows.Forms.Padding(3, 3, 1, 2);
            txb_mmx.ReadOnly = true;
            txb_mmx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            txb_mmx.SelectionStart = 0;
            txb_mmx.Size = new System.Drawing.Size(23, 23);
            txb_mmx.TabIndex = 6;
            txb_mmx.WordWrap = true;
            // 
            // txb_mmy
            // 
            txb_mmy.BorderColor = System.Drawing.Color.Black;
            txb_mmy.Location = new System.Drawing.Point(287, 41);
            txb_mmy.Multiline = false;
            txb_mmy.Name = "txb_mmy";
            txb_mmy.OnTextChanged = null;
            txb_mmy.Padding = new System.Windows.Forms.Padding(3, 3, 1, 2);
            txb_mmy.ReadOnly = true;
            txb_mmy.ScrollBars = System.Windows.Forms.ScrollBars.None;
            txb_mmy.SelectionStart = 0;
            txb_mmy.Size = new System.Drawing.Size(23, 23);
            txb_mmy.TabIndex = 7;
            txb_mmy.WordWrap = true;
            // 
            // FormOffsetGrabber
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(326, 78);
            Controls.Add(txb_mmy);
            Controls.Add(txb_mmx);
            Controls.Add(lbl_mmy);
            Controls.Add(lbl_mmx);
            Controls.Add(txb_bg);
            Controls.Add(txb_clip);
            Controls.Add(lbl_bg);
            Controls.Add(lbl_clip);
            Name = "FormOffsetGrabber";
            ShowIcon = false;
            Text = "OffsetGrabber";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbl_clip;
        private System.Windows.Forms.Label lbl_bg;
        private Theming.CustomControls.FlatTextBox txb_clip;
        private Theming.CustomControls.FlatTextBox txb_bg;
        private System.Windows.Forms.Label lbl_mmx;
        private System.Windows.Forms.Label lbl_mmy;
        private Theming.CustomControls.FlatTextBox txb_mmx;
        private Theming.CustomControls.FlatTextBox txb_mmy;
    }
}