namespace mage.Options.Pages
{
    partial class PageRules
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
            checkBox_warnings_enabled = new System.Windows.Forms.CheckBox();
            seperator1 = new mage.Controls.Seperator();
            listBox_rules = new mage.Theming.CustomControls.FlatCheckedListBox();
            grp_all = new System.Windows.Forms.GroupBox();
            grp_rules_mf = new System.Windows.Forms.GroupBox();
            listBox_rules_mf = new mage.Theming.CustomControls.FlatCheckedListBox();
            grp_rules_zm = new System.Windows.Forms.GroupBox();
            listBox_rules_zm = new mage.Theming.CustomControls.FlatCheckedListBox();
            panel_rules = new System.Windows.Forms.Panel();
            grp_all.SuspendLayout();
            grp_rules_mf.SuspendLayout();
            grp_rules_zm.SuspendLayout();
            panel_rules.SuspendLayout();
            SuspendLayout();
            // 
            // checkBox_warnings_enabled
            // 
            checkBox_warnings_enabled.AutoSize = true;
            checkBox_warnings_enabled.Location = new System.Drawing.Point(6, 6);
            checkBox_warnings_enabled.Name = "checkBox_warnings_enabled";
            checkBox_warnings_enabled.Size = new System.Drawing.Size(201, 19);
            checkBox_warnings_enabled.TabIndex = 11;
            checkBox_warnings_enabled.Text = "Show incorrect clipdata warnings";
            checkBox_warnings_enabled.UseVisualStyleBackColor = true;
            checkBox_warnings_enabled.CheckedChanged += checkBox_warnings_enabled_CheckedChanged;
            // 
            // seperator1
            // 
            seperator1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            seperator1.Location = new System.Drawing.Point(6, 31);
            seperator1.Name = "seperator1";
            seperator1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            seperator1.Size = new System.Drawing.Size(346, 1);
            seperator1.TabIndex = 13;
            seperator1.Text = "seperator1";
            // 
            // listBox_rules
            // 
            listBox_rules.AccentColor = System.Drawing.Color.FromArgb(0, 120, 215);
            listBox_rules.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            listBox_rules.BorderColor = System.Drawing.Color.FromArgb(60, 60, 60);
            listBox_rules.BorderColorDisabled = System.Drawing.Color.FromArgb(100, 100, 100);
            listBox_rules.BorderStyle = System.Windows.Forms.BorderStyle.None;
            listBox_rules.CheckColor = System.Drawing.Color.White;
            listBox_rules.CheckOnClick = true;
            listBox_rules.DisabledTextColor = System.Drawing.Color.Gray;
            listBox_rules.FormattingEnabled = true;
            listBox_rules.Location = new System.Drawing.Point(6, 22);
            listBox_rules.Name = "listBox_rules";
            listBox_rules.SelectionColor = System.Drawing.Color.FromArgb(45, 45, 48);
            listBox_rules.ShowSelection = false;
            listBox_rules.Size = new System.Drawing.Size(336, 96);
            listBox_rules.TabIndex = 14;
            listBox_rules.ItemCheckedChanged += SaveSettings;
            // 
            // grp_all
            // 
            grp_all.AutoSize = true;
            grp_all.Controls.Add(listBox_rules);
            grp_all.Dock = System.Windows.Forms.DockStyle.Top;
            grp_all.Location = new System.Drawing.Point(0, 0);
            grp_all.Name = "grp_all";
            grp_all.Size = new System.Drawing.Size(345, 140);
            grp_all.TabIndex = 15;
            grp_all.TabStop = false;
            grp_all.Text = "Rules";
            // 
            // grp_rules_mf
            // 
            grp_rules_mf.AutoSize = true;
            grp_rules_mf.Controls.Add(listBox_rules_mf);
            grp_rules_mf.Dock = System.Windows.Forms.DockStyle.Top;
            grp_rules_mf.Location = new System.Drawing.Point(0, 140);
            grp_rules_mf.Name = "grp_rules_mf";
            grp_rules_mf.Size = new System.Drawing.Size(345, 65);
            grp_rules_mf.TabIndex = 16;
            grp_rules_mf.TabStop = false;
            grp_rules_mf.Text = "Metroid Fusion Exclusive";
            // 
            // listBox_rules_mf
            // 
            listBox_rules_mf.AccentColor = System.Drawing.Color.FromArgb(0, 120, 215);
            listBox_rules_mf.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            listBox_rules_mf.BorderColor = System.Drawing.Color.FromArgb(60, 60, 60);
            listBox_rules_mf.BorderColorDisabled = System.Drawing.Color.FromArgb(100, 100, 100);
            listBox_rules_mf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            listBox_rules_mf.CheckColor = System.Drawing.Color.White;
            listBox_rules_mf.CheckOnClick = true;
            listBox_rules_mf.DisabledTextColor = System.Drawing.Color.Gray;
            listBox_rules_mf.FormattingEnabled = true;
            listBox_rules_mf.Location = new System.Drawing.Point(6, 19);
            listBox_rules_mf.Name = "listBox_rules_mf";
            listBox_rules_mf.SelectionColor = System.Drawing.Color.FromArgb(45, 45, 48);
            listBox_rules_mf.ShowSelection = false;
            listBox_rules_mf.Size = new System.Drawing.Size(336, 24);
            listBox_rules_mf.TabIndex = 14;
            listBox_rules_mf.ItemCheckedChanged += SaveSettings;
            // 
            // grp_rules_zm
            // 
            grp_rules_zm.AutoSize = true;
            grp_rules_zm.Controls.Add(listBox_rules_zm);
            grp_rules_zm.Dock = System.Windows.Forms.DockStyle.Top;
            grp_rules_zm.Location = new System.Drawing.Point(0, 205);
            grp_rules_zm.Name = "grp_rules_zm";
            grp_rules_zm.Size = new System.Drawing.Size(345, 68);
            grp_rules_zm.TabIndex = 17;
            grp_rules_zm.TabStop = false;
            grp_rules_zm.Text = "Metroid Zero Mission Exclusive";
            // 
            // listBox_rules_zm
            // 
            listBox_rules_zm.AccentColor = System.Drawing.Color.FromArgb(0, 120, 215);
            listBox_rules_zm.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            listBox_rules_zm.BorderColor = System.Drawing.Color.FromArgb(60, 60, 60);
            listBox_rules_zm.BorderColorDisabled = System.Drawing.Color.FromArgb(100, 100, 100);
            listBox_rules_zm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            listBox_rules_zm.CheckColor = System.Drawing.Color.White;
            listBox_rules_zm.CheckOnClick = true;
            listBox_rules_zm.DisabledTextColor = System.Drawing.Color.Gray;
            listBox_rules_zm.FormattingEnabled = true;
            listBox_rules_zm.Location = new System.Drawing.Point(6, 22);
            listBox_rules_zm.Name = "listBox_rules_zm";
            listBox_rules_zm.SelectionColor = System.Drawing.Color.FromArgb(45, 45, 48);
            listBox_rules_zm.ShowSelection = false;
            listBox_rules_zm.Size = new System.Drawing.Size(336, 24);
            listBox_rules_zm.TabIndex = 14;
            listBox_rules_zm.ItemCheckedChanged += SaveSettings;
            // 
            // panel_rules
            // 
            panel_rules.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel_rules.AutoSize = true;
            panel_rules.Controls.Add(grp_rules_zm);
            panel_rules.Controls.Add(grp_rules_mf);
            panel_rules.Controls.Add(grp_all);
            panel_rules.Location = new System.Drawing.Point(7, 38);
            panel_rules.Name = "panel_rules";
            panel_rules.Size = new System.Drawing.Size(345, 301);
            panel_rules.TabIndex = 18;
            // 
            // PageRules
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            AutoScroll = true;
            Controls.Add(panel_rules);
            Controls.Add(seperator1);
            Controls.Add(checkBox_warnings_enabled);
            Name = "PageRules";
            Padding = new System.Windows.Forms.Padding(3);
            Size = new System.Drawing.Size(358, 345);
            grp_all.ResumeLayout(false);
            grp_rules_mf.ResumeLayout(false);
            grp_rules_zm.ResumeLayout(false);
            panel_rules.ResumeLayout(false);
            panel_rules.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.CheckBox checkBox_warnings_enabled;
        private Controls.Seperator seperator1;
        private Theming.CustomControls.FlatCheckedListBox listBox_rules;
        private System.Windows.Forms.GroupBox grp_all;
        private System.Windows.Forms.GroupBox grp_rules_mf;
        private Theming.CustomControls.FlatCheckedListBox listBox_rules_mf;
        private System.Windows.Forms.GroupBox grp_rules_zm;
        private Theming.CustomControls.FlatCheckedListBox listBox_rules_zm;
        private System.Windows.Forms.Panel panel_rules;
    }
}
