namespace mage.Dialogs
{
    partial class BG3ScrollDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BG3ScrollDialog));
            lbl_x = new System.Windows.Forms.Label();
            lbl_y = new System.Windows.Forms.Label();
            btn_3 = new System.Windows.Forms.Button();
            btn_0 = new System.Windows.Forms.Button();
            btn_1 = new System.Windows.Forms.Button();
            btn_2 = new System.Windows.Forms.Button();
            btn_4 = new System.Windows.Forms.Button();
            btn_5 = new System.Windows.Forms.Button();
            btn_6 = new System.Windows.Forms.Button();
            btn_7 = new System.Windows.Forms.Button();
            btn_8 = new System.Windows.Forms.Button();
            btn_9 = new System.Windows.Forms.Button();
            btn_10 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lbl_x
            // 
            lbl_x.AutoSize = true;
            lbl_x.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            lbl_x.Location = new System.Drawing.Point(12, 9);
            lbl_x.Name = "lbl_x";
            lbl_x.Size = new System.Drawing.Size(49, 15);
            lbl_x.TabIndex = 0;
            lbl_x.Text = "Scroll X";
            // 
            // lbl_y
            // 
            lbl_y.AutoSize = true;
            lbl_y.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            lbl_y.Location = new System.Drawing.Point(316, 9);
            lbl_y.Name = "lbl_y";
            lbl_y.Size = new System.Drawing.Size(48, 15);
            lbl_y.TabIndex = 1;
            lbl_y.Text = "Scroll Y";
            // 
            // btn_3
            // 
            btn_3.Location = new System.Drawing.Point(12, 123);
            btn_3.Name = "btn_3";
            btn_3.Size = new System.Drawing.Size(352, 23);
            btn_3.TabIndex = 2;
            btn_3.Tag = "3";
            btn_3.Text = "Relative to screen / 2                                       Relative to screen / 2";
            btn_3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn_3.UseVisualStyleBackColor = true;
            btn_3.Click += buttonClicked;
            // 
            // btn_0
            // 
            btn_0.Location = new System.Drawing.Point(12, 36);
            btn_0.Name = "btn_0";
            btn_0.Size = new System.Drawing.Size(352, 23);
            btn_0.TabIndex = 3;
            btn_0.Tag = "0";
            btn_0.Text = "None                                                                                             None";
            btn_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn_0.UseVisualStyleBackColor = true;
            btn_0.Click += buttonClicked;
            // 
            // btn_1
            // 
            btn_1.Location = new System.Drawing.Point(12, 65);
            btn_1.Name = "btn_1";
            btn_1.Size = new System.Drawing.Size(352, 23);
            btn_1.TabIndex = 4;
            btn_1.Tag = "1";
            btn_1.Text = "Relative to screen / 2                                                                  None";
            btn_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn_1.UseVisualStyleBackColor = true;
            btn_1.Click += buttonClicked;
            // 
            // btn_2
            // 
            btn_2.Location = new System.Drawing.Point(12, 94);
            btn_2.Name = "btn_2";
            btn_2.Size = new System.Drawing.Size(352, 23);
            btn_2.TabIndex = 5;
            btn_2.Tag = "2";
            btn_2.Text = "None                                                                  Relative to screen / 2";
            btn_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn_2.UseVisualStyleBackColor = true;
            btn_2.Click += buttonClicked;
            // 
            // btn_4
            // 
            btn_4.Location = new System.Drawing.Point(12, 152);
            btn_4.Name = "btn_4";
            btn_4.Size = new System.Drawing.Size(352, 23);
            btn_4.TabIndex = 6;
            btn_4.Tag = "4";
            btn_4.Text = "Relative to screen                                             Relative to screen / 2";
            btn_4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn_4.UseVisualStyleBackColor = true;
            btn_4.Click += buttonClicked;
            // 
            // btn_5
            // 
            btn_5.Location = new System.Drawing.Point(12, 181);
            btn_5.Name = "btn_5";
            btn_5.Size = new System.Drawing.Size(352, 23);
            btn_5.TabIndex = 7;
            btn_5.Tag = "5";
            btn_5.Text = "Relative to screen / 2                                             Relative to screen";
            btn_5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn_5.UseVisualStyleBackColor = true;
            btn_5.Click += buttonClicked;
            // 
            // btn_6
            // 
            btn_6.Location = new System.Drawing.Point(12, 210);
            btn_6.Name = "btn_6";
            btn_6.Size = new System.Drawing.Size(352, 23);
            btn_6.TabIndex = 8;
            btn_6.Tag = "6";
            btn_6.Text = "Relative to screen                                                   Relative to screen";
            btn_6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn_6.UseVisualStyleBackColor = true;
            btn_6.Click += buttonClicked;
            // 
            // btn_7
            // 
            btn_7.Location = new System.Drawing.Point(12, 239);
            btn_7.Name = "btn_7";
            btn_7.Size = new System.Drawing.Size(352, 23);
            btn_7.TabIndex = 9;
            btn_7.Tag = "7";
            btn_7.Text = "Relative to screen - 8px / frame                                                None";
            btn_7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn_7.UseVisualStyleBackColor = true;
            btn_7.Click += buttonClicked;
            // 
            // btn_8
            // 
            btn_8.Location = new System.Drawing.Point(12, 268);
            btn_8.Name = "btn_8";
            btn_8.Size = new System.Drawing.Size(352, 23);
            btn_8.TabIndex = 10;
            btn_8.Tag = "8";
            btn_8.Text = "Relative to screen - 8px / frame                                                None";
            btn_8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn_8.UseVisualStyleBackColor = true;
            btn_8.Click += buttonClicked;
            // 
            // btn_9
            // 
            btn_9.Location = new System.Drawing.Point(12, 297);
            btn_9.Name = "btn_9";
            btn_9.Size = new System.Drawing.Size(352, 23);
            btn_9.TabIndex = 11;
            btn_9.Tag = "9";
            btn_9.Text = "Relative to screen / 4                                                                  None";
            btn_9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn_9.UseVisualStyleBackColor = true;
            btn_9.Click += buttonClicked;
            // 
            // btn_10
            // 
            btn_10.Location = new System.Drawing.Point(12, 326);
            btn_10.Name = "btn_10";
            btn_10.Size = new System.Drawing.Size(352, 23);
            btn_10.TabIndex = 12;
            btn_10.Tag = "10";
            btn_10.Text = "Relative to screen - 8px / frame                           Relative to screen";
            btn_10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn_10.UseVisualStyleBackColor = true;
            btn_10.Click += buttonClicked;
            // 
            // BG3ScrollDialog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            ClientSize = new System.Drawing.Size(376, 364);
            Controls.Add(btn_10);
            Controls.Add(btn_9);
            Controls.Add(btn_8);
            Controls.Add(btn_7);
            Controls.Add(btn_6);
            Controls.Add(btn_5);
            Controls.Add(btn_4);
            Controls.Add(btn_2);
            Controls.Add(btn_1);
            Controls.Add(btn_0);
            Controls.Add(btn_3);
            Controls.Add(lbl_y);
            Controls.Add(lbl_x);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "BG3ScrollDialog";
            Text = "BG3 Scroll";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbl_x;
        private System.Windows.Forms.Label lbl_y;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_10;
    }
}