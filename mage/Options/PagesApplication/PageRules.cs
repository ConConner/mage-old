using mage.Properties;
using mage.Theming;
using mage.Updates;
using mage.Warnings;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mage.Options.Pages;

public partial class PageRules : UserControl, IReloadablePage
{
    private class RuleItem
    {
        public IClipdataRule Rule { get; }
        public RuleItem(IClipdataRule rule) => Rule = rule;

        public override string ToString() => Rule.Name;
    }

    private bool init = false;

    public PageRules()
    {
        InitializeComponent();
        LoadPage();
    }
    public void LoadPage()
    {
        init = true;
        checkBox_warnings_enabled.Checked = Program.Config.WarningsEnabled;
        populateRulesList();
        init = false;
    }

    private void populateRulesList()
    {
        IEnumerable<IClipdataRule> allRules = Program.Services.GetServices<IClipdataRule>();

        var zmExclusive = allRules.Where(r => r.ZmExclusive);
        var mfExclusive = allRules.Where(r => r.MfExclusive);
        var genericRules = allRules.Where(r => !r.MfExclusive && !r.ZmExclusive);

        grp_rules_mf.Visible = mfExclusive.Count() > 0;
        grp_rules_zm.Visible = zmExclusive.Count() > 0;

        // Populate each CheckedListBox
        PopulateBox(listBox_rules, genericRules);
        PopulateBox(listBox_rules_zm, zmExclusive);
        PopulateBox(listBox_rules_mf, mfExclusive);
    }

    private void ReloadRoomValidator()
    {
        FormMain.Instance.RoomRuleValidationSettingsChanged();
    }

    private void PopulateBox(CheckedListBox clb, IEnumerable<IClipdataRule> rules)
    {
        clb.BeginUpdate();
        clb.Items.Clear();

        foreach (var rule in rules)
        {
            // Check if enabled according to Config
            bool isEnabled = Program.Config.IsRuleEnabled(rule.RuleKey);

            clb.Items.Add(new RuleItem(rule), isEnabled);
        }

        clb.EndUpdate();

        AutoSizeCheckedListBox(clb);
    }

    public static void AutoSizeCheckedListBox(CheckedListBox clb, bool autoWidth = false, bool autoHeight = true)
    {
        if (clb.Items.Count == 0) return;

        // 1. Calculate required height
        if (autoHeight)
        {
            int borderPadding = SystemInformation.BorderSize.Height * 2;
            int totalHeight = (clb.Items.Count * clb.ItemHeight) + borderPadding + 2;
            clb.Height = totalHeight;
        }

        // 2. Calculate required width
        if (autoWidth)
        {
            int maxWidth = 0;
            // 20px accounts for the checkbox square + standard padding
            int checkGlyphOffset = 24;

            foreach (var item in clb.Items)
            {
                string text = clb.GetItemText(item);
                Size size = TextRenderer.MeasureText(text, clb.Font);
                if (size.Width > maxWidth)
                {
                    maxWidth = size.Width;
                }
            }

            int borderPadding = SystemInformation.BorderSize.Width * 2;
            clb.Width = maxWidth + checkGlyphOffset + borderPadding + 10;
        }
    }

    private void checkBox_warnings_enabled_CheckedChanged(object sender, EventArgs e)
    {
        if (init) return;
        Program.Config.WarningsEnabled = checkBox_warnings_enabled.Checked;
        ReloadRoomValidator();
    }

    public void SaveSettings(object sender, ItemCheckEventArgs e)
    {
        if (init) return;
        SaveBox(listBox_rules);
        SaveBox(listBox_rules_mf);
        SaveBox(listBox_rules_zm);
        ReloadRoomValidator();
    }

    private void SaveBox(CheckedListBox clb)
    {
        for (int i = 0; i < clb.Items.Count; i++)
        {
            var item = (RuleItem)clb.Items[i];
            bool isChecked = clb.GetItemChecked(i);

            Program.Config.SetRuleEnabled(item.Rule.RuleKey, isChecked);
        }
    }
}
