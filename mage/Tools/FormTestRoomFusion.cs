using mage.Data;
using mage.Theming;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace mage;

public partial class FormTestRoomFusion : Form
{
    // fields
    private FormMain main;
    private sRamMf save;

    // constructor
    public FormTestRoomFusion(FormMain main, sRamMf save = null)
    {
        InitializeComponent();

        ThemeSwitcher.ChangeTheme(Controls, this);
        ThemeSwitcher.InjectPaintOverrides(Controls);

        if (save == null) save = new();
        this.save = save;
        this.main = main;

        SetUIValues();

        SetUIColors();
    }

    private void SetUIColors()
    {
        txb_missile_cur.BackColor =
        txb_missile_max.BackColor =
        txb_energy_cur.BackColor =
        txb_energy_max.BackColor =
        txb_power_cur.BackColor =
        txb_power_max.BackColor =
        cbb_lock_level.BackColor =
        cbb_lock_level.BorderColor =
        Color.FromArgb(0x21, 0x21, 0x4A);

        textBox_xPos.BackColor =
        textBox_yPos.BackColor =
        textBox_event.BackColor =
        Color.FromArgb(0x10, 0x29, 0xC6);

        txb_missile_cur.ForeColor =
        txb_missile_max.ForeColor =
        txb_energy_cur.ForeColor =
        txb_energy_max.ForeColor =
        txb_power_cur.ForeColor =
        txb_power_max.ForeColor =
        Color.FromArgb(0x10, 0xFF, 0x84);

        textBox_xPos.ForeColor =
        textBox_yPos.ForeColor =
        textBox_event.ForeColor =
        cbb_lock_level.ForeColor =
        cbb_lock_level.BorderColor =
        Color.FromArgb(0x10, 0xFF, 0xFF);

        txb_missile_cur.Font =
        txb_missile_max.Font =
        txb_energy_cur.Font =
        txb_energy_max.Font =
        txb_power_cur.Font =
        txb_power_max.Font =
        textBox_xPos.Font =
        textBox_yPos.Font =
        textBox_event.Font =
        new Font(main.pfc.Families[0], 16);

        txb_missile_cur.DisplayBorder =
        txb_missile_max.DisplayBorder =
        txb_energy_cur.DisplayBorder =
        txb_energy_max.DisplayBorder =
        txb_power_cur.DisplayBorder =
        txb_power_max.DisplayBorder =
        textBox_xPos.DisplayBorder =
        textBox_yPos.DisplayBorder =
        textBox_event.DisplayBorder =
        false;
    }

    private void SetUIValues()
    {
        textBox_xPos.Text = Hex.ToString(save.xPos);
        textBox_yPos.Text = Hex.ToString(save.yPos);
        textBox_event.Text = Hex.ToString(save.EventCounter);
        if (save.DebugMenu) ItemToggle(chb_debug);

        int oldradix = Hex.radix;
        Hex.radix = 10;
        txb_energy_cur.Text = Hex.ToString(save.CurrentEnergy);
        txb_energy_max.Text = Hex.ToString(save.MaxEnergy);
        txb_missile_cur.Text = Hex.ToString(save.CurrentMissiles);
        txb_missile_max.Text = Hex.ToString(save.MaxMissiles);
        txb_power_cur.Text = Hex.ToString(save.CurrentPowerBombs);
        txb_power_max.Text = Hex.ToString(save.MaxPowerBombs);
        Hex.radix = oldradix;

        int selectedLockLevel = (byte)save.SecurityHatchLevel == 0xFF ? 5 : (byte)save.SecurityHatchLevel;
        cbb_lock_level.SelectedIndex = selectedLockLevel;

        if (save.BeamStatus.HasFlag(BeamStatus.ChargeBeam)) ItemToggle(chb_charge);
        if (save.BeamStatus.HasFlag(BeamStatus.WideBeam)) ItemToggle(chb_wide);
        if (save.BeamStatus.HasFlag(BeamStatus.PlasmaBeam)) ItemToggle(chb_plasma);
        if (save.BeamStatus.HasFlag(BeamStatus.WaveBeam)) ItemToggle(chb_wave);

        if (save.MissileBombStatus.HasFlag(MissileBombStatus.Missiles)) ItemToggle(chb_missile);
        if (save.MissileBombStatus.HasFlag(MissileBombStatus.SuperMissiles)) ItemToggle(chb_super);
        if (save.MissileBombStatus.HasFlag(MissileBombStatus.IceMissiles)) ItemToggle(chb_ice_missiles);
        if (save.MissileBombStatus.HasFlag(MissileBombStatus.DiffusionMissiles)) ItemToggle(chb_diffusion);
        if (save.MissileBombStatus.HasFlag(MissileBombStatus.Bombs)) ItemToggle(chb_bombs);
        if (save.MissileBombStatus.HasFlag(MissileBombStatus.PowerBombs)) ItemToggle(chb_pbs);

        if (save.SuitMiscStatus.HasFlag(SuitMiscStatus.HiJump)) ItemToggle(chb_hijump);
        if (save.SuitMiscStatus.HasFlag(SuitMiscStatus.SpeedBooster)) ItemToggle(chb_speed);
        if (save.SuitMiscStatus.HasFlag(SuitMiscStatus.SpaceJump)) ItemToggle(chb_space);
        if (save.SuitMiscStatus.HasFlag(SuitMiscStatus.ScrewAttack)) ItemToggle(chb_screw);
        if (save.SuitMiscStatus.HasFlag(SuitMiscStatus.VariaSuit)) ItemToggle(chb_varia);
        if (save.SuitMiscStatus.HasFlag(SuitMiscStatus.GravitySuit)) ItemToggle(chb_gravity);
        if (save.SuitMiscStatus.HasFlag(SuitMiscStatus.MorphBall)) ItemToggle(chb_morph);
    }

    private void button_go_Click(object sender, EventArgs e)
    {
        try
        {
            bool debug = chb_debug.Checked;
            byte xPos = Hex.ToByte(textBox_xPos.Text);
            byte yPos = Hex.ToByte(textBox_yPos.Text);
            save.EventCounter = Hex.ToByte(textBox_event.Text);

            int oldradix = Hex.radix;
            Hex.radix = 10;
            save.CurrentEnergy = Hex.ToUshort(txb_energy_cur.Text);
            save.MaxEnergy = Hex.ToUshort(txb_energy_max.Text);
            save.CurrentMissiles = Hex.ToUshort(txb_missile_cur.Text);
            save.MaxMissiles = Hex.ToUshort(txb_missile_max.Text);
            save.CurrentPowerBombs = Hex.ToByte(txb_power_cur.Text);
            save.MaxPowerBombs = Hex.ToByte(txb_power_max.Text);
            Hex.radix = oldradix;

            Test.Room(main, debug, xPos, yPos, save);

            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show("One of the values entered was not valid.\n\n" + ex.Message,
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void button_cancel_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void ItemToggle(PictureBoxInterpolation sender)
    {
        sender.Checked = !sender.Checked;

        if (sender.Name == chb_bombs.Name || sender.Name == chb_missile.Name || sender.Name == chb_debug.Name)
        {
            if (sender.Checked) { sender.Image = Properties.Resources.item_enabled_fusion_secondary; }
            else sender.Image = Properties.Resources.item_disabled_fusion_secondary;
            return;
        }

        if (sender.Checked) { sender.Image = Properties.Resources.item_enabled_fusion; }
        else sender.Image = Properties.Resources.item_disabled_fusion;
    }

    private void chb_beam_status_Clicked(object sender, EventArgs e)
    {
        if (sender is not PictureBoxInterpolation pb) return;
        ItemToggle(pb);

        //Adjusting value
        BeamStatus bb = (BeamStatus)Enum.Parse(typeof(BeamStatus), pb.Tag.ToString());
        if (!pb.Checked) save.BeamStatus &= ~bb;
        else save.BeamStatus |= bb;
    }

    private void chb_suit_misc_Clicked(object sender, EventArgs e)
    {
        if (sender is not PictureBoxInterpolation pb) return;
        ItemToggle(pb);

        //Adjusting value
        SuitMiscStatus bb = (SuitMiscStatus)Enum.Parse(typeof(SuitMiscStatus), pb.Tag.ToString());
        if (!pb.Checked) save.SuitMiscStatus &= ~bb;
        else save.SuitMiscStatus |= bb;
    }

    private void chb_missile_bomb_status_Clicked(object sender, EventArgs e)
    {
        if (sender is not PictureBoxInterpolation pb) return;
        ItemToggle(pb);

        //Adjusting value
        MissileBombStatus bb = (MissileBombStatus)Enum.Parse(typeof(MissileBombStatus), pb.Tag.ToString());
        if (!pb.Checked) save.MissileBombStatus &= ~bb;
        else save.MissileBombStatus |= bb;
    }

    private void chb_debug_Click(object sender, EventArgs e)
    {
        if (sender is not PictureBoxInterpolation pb) return;
        ItemToggle(pb);
    }

    private void cbb_suit_type_SelectedIndexChanged(object sender, EventArgs e)
    {
        byte value = (byte)cbb_lock_level.SelectedIndex;
        value = (byte)(value == 5 ? 0xFF : value);
        save.SecurityHatchLevel = (SecurityHatchLevel)value;

        switch (save.SecurityHatchLevel)
        {
            case SecurityHatchLevel.White:
                pbx_lock_display.Image = Properties.Resources.lock_fusion_0;
                break;
            case SecurityHatchLevel.Level1:
                pbx_lock_display.Image = Properties.Resources.lock_fusion_1;
                break;
            case SecurityHatchLevel.Level2:
                pbx_lock_display.Image = Properties.Resources.lock_fusion_2;
                break;
            case SecurityHatchLevel.Level3:
                pbx_lock_display.Image = Properties.Resources.lock_fusion_3;
                break;
            case SecurityHatchLevel.Level4:
                pbx_lock_display.Image = Properties.Resources.lock_fusion_4;
                break;
            case SecurityHatchLevel.NoHatches:
                pbx_lock_display.Image = Properties.Resources.lock_fusion_0;
                break;
        }
    }
}