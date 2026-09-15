namespace mage.Options.Pages
{
    partial class PageSprites
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageSprites));
            checkBox_allow_ff_sprites = new System.Windows.Forms.CheckBox();
            lbl_warning = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // checkBox_allow_ff_sprites
            // 
            checkBox_allow_ff_sprites.AutoSize = true;
            checkBox_allow_ff_sprites.Location = new System.Drawing.Point(6, 6);
            checkBox_allow_ff_sprites.Name = "checkBox_allow_ff_sprites";
            checkBox_allow_ff_sprites.Size = new System.Drawing.Size(311, 19);
            checkBox_allow_ff_sprites.TabIndex = 11;
            checkBox_allow_ff_sprites.Text = "Allow usage of Sprite IDs up to 0xFF in Spriteset Editor";
            checkBox_allow_ff_sprites.UseVisualStyleBackColor = true;
            checkBox_allow_ff_sprites.CheckedChanged += checkBox_allow_ff_sprites_CheckedChanged;
            // 
            // lbl_warning
            // 
            lbl_warning.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lbl_warning.Location = new System.Drawing.Point(6, 31);
            lbl_warning.Margin = new System.Windows.Forms.Padding(3);
            lbl_warning.Name = "lbl_warning";
            lbl_warning.Size = new System.Drawing.Size(346, 159);
            lbl_warning.TabIndex = 12;
            lbl_warning.Text = resources.GetString("lbl_warning.Text");
            // 
            // PageSprites
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            AutoScroll = true;
            Controls.Add(lbl_warning);
            Controls.Add(checkBox_allow_ff_sprites);
            Name = "PageSprites";
            Padding = new System.Windows.Forms.Padding(3);
            Size = new System.Drawing.Size(358, 196);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.CheckBox checkBox_allow_ff_sprites;
        private System.Windows.Forms.Label lbl_warning;
    }
}
