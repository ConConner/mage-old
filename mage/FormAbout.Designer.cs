namespace mage
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            label_mage = new System.Windows.Forms.Label();
            label_version = new System.Windows.Forms.Label();
            label_bugs = new System.Windows.Forms.Label();
            linkLabel_forum = new System.Windows.Forms.LinkLabel();
            label_silk = new System.Windows.Forms.Label();
            linkLabel_silk = new System.Windows.Forms.LinkLabel();
            label_font = new System.Windows.Forms.Label();
            linkLabel_repo = new System.Windows.Forms.LinkLabel();
            label_repo = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label_mage
            // 
            label_mage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label_mage.Location = new System.Drawing.Point(14, 10);
            label_mage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_mage.Name = "label_mage";
            label_mage.Size = new System.Drawing.Size(280, 30);
            label_mage.TabIndex = 0;
            label_mage.Text = "Metroid Advance Game Editor";
            label_mage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_version
            // 
            label_version.Location = new System.Drawing.Point(14, 40);
            label_version.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_version.Name = "label_version";
            label_version.Size = new System.Drawing.Size(280, 91);
            label_version.TabIndex = 5;
            label_version.Text = "Version 1.4.0\r\n2023-01-22\r\n\r\nCreated by biospark\r\nModified by ConConner";
            label_version.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_bugs
            // 
            label_bugs.Location = new System.Drawing.Point(15, 131);
            label_bugs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_bugs.Name = "label_bugs";
            label_bugs.Size = new System.Drawing.Size(280, 15);
            label_bugs.TabIndex = 6;
            label_bugs.Text = "Report bugs and other problems here:";
            label_bugs.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // linkLabel_forum
            // 
            linkLabel_forum.Location = new System.Drawing.Point(15, 146);
            linkLabel_forum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            linkLabel_forum.Name = "linkLabel_forum";
            linkLabel_forum.Size = new System.Drawing.Size(280, 45);
            linkLabel_forum.TabIndex = 7;
            linkLabel_forum.TabStop = true;
            linkLabel_forum.Text = "http://forum.metroidconstruction.com/index.php/topic,3969.0.html";
            linkLabel_forum.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            linkLabel_forum.LinkClicked += linkLabel_clicked;
            // 
            // label_silk
            // 
            label_silk.Location = new System.Drawing.Point(15, 241);
            label_silk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_silk.Name = "label_silk";
            label_silk.Size = new System.Drawing.Size(280, 15);
            label_silk.TabIndex = 8;
            label_silk.Text = "Silk icon set by Mark James";
            label_silk.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // linkLabel_silk
            // 
            linkLabel_silk.Location = new System.Drawing.Point(15, 256);
            linkLabel_silk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            linkLabel_silk.Name = "linkLabel_silk";
            linkLabel_silk.Size = new System.Drawing.Size(280, 15);
            linkLabel_silk.TabIndex = 9;
            linkLabel_silk.TabStop = true;
            linkLabel_silk.Text = "http://www.famfamfam.com/lab/icons/silk/";
            linkLabel_silk.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            linkLabel_silk.LinkClicked += linkLabel_clicked;
            // 
            // label_font
            // 
            label_font.Location = new System.Drawing.Point(15, 291);
            label_font.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_font.Name = "label_font";
            label_font.Size = new System.Drawing.Size(280, 15);
            label_font.TabIndex = 10;
            label_font.Text = "MZM Font by Zidj";
            label_font.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // linkLabel_repo
            // 
            linkLabel_repo.Location = new System.Drawing.Point(14, 206);
            linkLabel_repo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            linkLabel_repo.Name = "linkLabel_repo";
            linkLabel_repo.Size = new System.Drawing.Size(280, 35);
            linkLabel_repo.TabIndex = 13;
            linkLabel_repo.TabStop = true;
            linkLabel_repo.Text = "https://github.com/biosp4rk/mage-old";
            linkLabel_repo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            linkLabel_repo.LinkClicked += linkLabel_clicked;
            // 
            // label_repo
            // 
            label_repo.Location = new System.Drawing.Point(14, 191);
            label_repo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_repo.Name = "label_repo";
            label_repo.Size = new System.Drawing.Size(280, 15);
            label_repo.TabIndex = 12;
            label_repo.Text = "Source code\r\n";
            label_repo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(308, 321);
            Controls.Add(linkLabel_repo);
            Controls.Add(label_repo);
            Controls.Add(label_font);
            Controls.Add(linkLabel_silk);
            Controls.Add(label_silk);
            Controls.Add(linkLabel_forum);
            Controls.Add(label_bugs);
            Controls.Add(label_version);
            Controls.Add(label_mage);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            Text = "About MAGE";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label_mage;
        private System.Windows.Forms.Label label_version;
        private System.Windows.Forms.Label label_bugs;
        private System.Windows.Forms.LinkLabel linkLabel_forum;
        private System.Windows.Forms.Label label_silk;
        private System.Windows.Forms.LinkLabel linkLabel_silk;
        private System.Windows.Forms.Label label_font;
        private System.Windows.Forms.LinkLabel linkLabel_repo;
        private System.Windows.Forms.Label label_repo;
    }
}