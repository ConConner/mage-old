namespace mage.Tools
{
    partial class FormTestRoomFusion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTestRoomFusion));
            lbl_x = new System.Windows.Forms.Label();
            lbl_y = new System.Windows.Forms.Label();
            txb_x = new Theming.CustomControls.FlatTextBox();
            txb_y = new Theming.CustomControls.FlatTextBox();
            chb_debug = new System.Windows.Forms.CheckBox();
            btn_go = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lbl_x
            // 
            lbl_x.AutoSize = true;
            lbl_x.Location = new System.Drawing.Point(12, 15);
            lbl_x.Name = "lbl_x";
            lbl_x.Size = new System.Drawing.Size(55, 15);
            lbl_x.TabIndex = 0;
            lbl_x.Text = "Screen X:";
            // 
            // lbl_y
            // 
            lbl_y.AutoSize = true;
            lbl_y.Location = new System.Drawing.Point(12, 44);
            lbl_y.Name = "lbl_y";
            lbl_y.Size = new System.Drawing.Size(55, 15);
            lbl_y.TabIndex = 1;
            lbl_y.Text = "Screen Y:";
            // 
            // txb_x
            // 
            txb_x.BorderColor = System.Drawing.Color.Black;
            txb_x.Location = new System.Drawing.Point(73, 12);
            txb_x.Multiline = false;
            txb_x.Name = "txb_x";
            txb_x.OnTextChanged = null;
            txb_x.Padding = new System.Windows.Forms.Padding(3, 3, 1, 2);
            txb_x.ReadOnly = false;
            txb_x.ScrollBars = System.Windows.Forms.ScrollBars.None;
            txb_x.SelectionStart = 0;
            txb_x.Size = new System.Drawing.Size(47, 23);
            txb_x.TabIndex = 2;
            txb_x.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            txb_x.WordWrap = true;
            // 
            // txb_y
            // 
            txb_y.BorderColor = System.Drawing.Color.Black;
            txb_y.Location = new System.Drawing.Point(73, 41);
            txb_y.Multiline = false;
            txb_y.Name = "txb_y";
            txb_y.OnTextChanged = null;
            txb_y.Padding = new System.Windows.Forms.Padding(3, 3, 1, 2);
            txb_y.ReadOnly = false;
            txb_y.ScrollBars = System.Windows.Forms.ScrollBars.None;
            txb_y.SelectionStart = 0;
            txb_y.Size = new System.Drawing.Size(47, 23);
            txb_y.TabIndex = 3;
            txb_y.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            txb_y.WordWrap = true;
            // 
            // chb_debug
            // 
            chb_debug.AutoSize = true;
            chb_debug.Checked = true;
            chb_debug.CheckState = System.Windows.Forms.CheckState.Checked;
            chb_debug.Location = new System.Drawing.Point(12, 70);
            chb_debug.Name = "chb_debug";
            chb_debug.Size = new System.Drawing.Size(95, 19);
            chb_debug.TabIndex = 4;
            chb_debug.Text = "Debug Menu";
            chb_debug.UseVisualStyleBackColor = true;
            // 
            // btn_go
            // 
            btn_go.Location = new System.Drawing.Point(126, 41);
            btn_go.Name = "btn_go";
            btn_go.Size = new System.Drawing.Size(52, 23);
            btn_go.TabIndex = 5;
            btn_go.Text = "Play";
            btn_go.UseVisualStyleBackColor = true;
            btn_go.Click += btn_go_Click;
            // 
            // FormTestRoomFusion
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            ClientSize = new System.Drawing.Size(190, 95);
            Controls.Add(btn_go);
            Controls.Add(chb_debug);
            Controls.Add(txb_y);
            Controls.Add(txb_x);
            Controls.Add(lbl_y);
            Controls.Add(lbl_x);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormTestRoomFusion";
            Text = "Test Room";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbl_x;
        private System.Windows.Forms.Label lbl_y;
        private Theming.CustomControls.FlatTextBox txb_x;
        private Theming.CustomControls.FlatTextBox txb_y;
        private System.Windows.Forms.CheckBox chb_debug;
        private System.Windows.Forms.Button btn_go;
    }
}