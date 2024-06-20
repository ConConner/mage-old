namespace mage.Tools
{
    partial class RoomViewSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomViewSettings));
            lbl_color = new System.Windows.Forms.Label();
            pnl_color = new System.Windows.Forms.Panel();
            SuspendLayout();
            // 
            // lbl_color
            // 
            lbl_color.AutoSize = true;
            lbl_color.Location = new System.Drawing.Point(12, 16);
            lbl_color.Name = "lbl_color";
            lbl_color.Size = new System.Drawing.Size(103, 15);
            lbl_color.TabIndex = 0;
            lbl_color.Text = "Color behind BG3:";
            // 
            // pnl_color
            // 
            pnl_color.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            pnl_color.Cursor = System.Windows.Forms.Cursors.Hand;
            pnl_color.Location = new System.Drawing.Point(121, 12);
            pnl_color.Name = "pnl_color";
            pnl_color.Size = new System.Drawing.Size(23, 23);
            pnl_color.TabIndex = 1;
            pnl_color.Click += pnl_color_Click;
            // 
            // RoomViewSettings
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            ClientSize = new System.Drawing.Size(287, 47);
            Controls.Add(pnl_color);
            Controls.Add(lbl_color);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "RoomViewSettings";
            Text = "Room View Settings";
            FormClosing += RoomViewSettings_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbl_color;
        private System.Windows.Forms.Panel pnl_color;
    }
}