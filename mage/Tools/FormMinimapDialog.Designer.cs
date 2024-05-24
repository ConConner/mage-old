namespace mage.Tools
{
    partial class FormMinimapDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMinimapDialog));
            gfxView_map = new GfxView();
            SuspendLayout();
            // 
            // gfxView_map
            // 
            gfxView_map.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            gfxView_map.Location = new System.Drawing.Point(0, 0);
            gfxView_map.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gfxView_map.Name = "gfxView_map";
            gfxView_map.Size = new System.Drawing.Size(512, 512);
            gfxView_map.TabIndex = 7;
            gfxView_map.TabStop = false;
            gfxView_map.MouseClick += gfxView_map_MouseClick;
            gfxView_map.MouseMove += gfxView_map_MouseMove;
            // 
            // FormMinimapDialog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            ClientSize = new System.Drawing.Size(512, 512);
            Controls.Add(gfxView_map);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMinimapDialog";
            Text = "Select Map Coordinate";
            ResumeLayout(false);
        }

        #endregion

        private GfxView gfxView_map;
    }
}