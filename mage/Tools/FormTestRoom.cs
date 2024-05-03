using mage.Data;
using mage.Theming;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace mage;

public partial class FormTestRoom : Form
{
    // fields
    private FormMain main;
    private sRam save;

    // constructor
    public FormTestRoom(FormMain main, sRam save = null)
    {
        InitializeComponent();

        ThemeSwitcher.ChangeTheme(Controls, this);
        ThemeSwitcher.InjectPaintOverrides(Controls);

        if (save == null) save = new();
        this.save = save;
        this.main = main;

        SetUIValues();
        
        SetUIColors();
        ToggleSuitGraphic();
    }

    private void SetUIColors()
    {
        txb_missile_cur.BackColor =
        txb_missile_max.BackColor =
        txb_supers_cur.BackColor =
        txb_supers_max.BackColor =
        txb_energy_cur.BackColor =
        txb_energy_max.BackColor =
        txb_power_cur.BackColor =
        txb_power_max.BackColor =
        textBox_xPos.BackColor =
        textBox_yPos.BackColor =
        cbb_suit_type.BackColor =
        Color.Black;

        txb_missile_cur.ForeColor =
        txb_missile_max.ForeColor =
        txb_supers_cur.ForeColor =
        txb_supers_max.ForeColor =
        txb_energy_cur.ForeColor =
        txb_energy_max.ForeColor =
        txb_power_cur.ForeColor =
        txb_power_max.ForeColor =
        textBox_xPos.ForeColor =
        textBox_yPos.ForeColor =
        Color.FromArgb(0xbd, 0xff, 0xde);

        cbb_suit_type.ForeColor =
        Color.White;

        txb_missile_cur.Font =
        txb_missile_max.Font =
        txb_supers_cur.Font =
        txb_supers_max.Font =
        txb_energy_cur.Font =
        txb_energy_max.Font =
        txb_power_cur.Font =
        txb_power_max.Font =
        textBox_xPos.Font =
        textBox_yPos.Font =
        new Font(main.pfc.Families[0], 20);

        txb_missile_cur.DisplayBorder =
        txb_missile_max.DisplayBorder =
        txb_supers_cur.DisplayBorder =
        txb_supers_max.DisplayBorder =
        txb_energy_cur.DisplayBorder =
        txb_energy_max.DisplayBorder =
        txb_power_cur.DisplayBorder =
        txb_power_max.DisplayBorder =
        textBox_xPos.DisplayBorder =
        textBox_yPos.DisplayBorder =
        false;
    }

    private void SetUIValues()
    {
        textBox_xPos.Text = Hex.ToString(save.xPos);
        textBox_yPos.Text = Hex.ToString(save.yPos);
        if (save.DebugMenu) ItemToggle(chb_debug);

        cbb_suit_type.SelectedIndex = (int)save.Suit;
        int oldradix = Hex.radix;
        Hex.radix = 10;
        txb_energy_cur.Text = Hex.ToString(save.CurrentEnergy);
        txb_energy_max.Text = Hex.ToString(save.MaxEnergy);
        txb_missile_cur.Text = Hex.ToString(save.CurrentMissiles);
        txb_missile_max.Text = Hex.ToString(save.MaxMissiles);
        txb_supers_cur.Text = Hex.ToString(save.CurrentSupers);
        txb_supers_max.Text = Hex.ToString(save.MaxSupers);
        txb_power_cur.Text = Hex.ToString(save.CurrentPowerBombs);
        txb_power_max.Text = Hex.ToString(save.MaxPowerBombs);
        Hex.radix = oldradix;

        if (save.BeamBombs.HasFlag(BeamBombs.LongBeam)) ItemToggle(chb_long);
        if (save.BeamBombs.HasFlag(BeamBombs.IceBeam)) ItemToggle(chb_ice);
        if (save.BeamBombs.HasFlag(BeamBombs.WaveBeam)) ItemToggle(chb_wave);
        if (save.BeamBombs.HasFlag(BeamBombs.PlasmaBeam)) ItemToggle(chb_plasma);
        if (save.BeamBombs.HasFlag(BeamBombs.ChargeBeam)) ItemToggle(chb_charge);
        if (save.BeamBombs.HasFlag(BeamBombs.Bombs)) ItemToggle(chb_bombs);

        if (save.Items.HasFlag(Items.HiJump)) ItemToggle(chb_hijump);
        if (save.Items.HasFlag(Items.PowerGrip)) ItemToggle(chb_grip);
        if (save.Items.HasFlag(Items.MorphBall)) ItemToggle(chb_morph);
        if (save.Items.HasFlag(Items.SpeedBooster)) ItemToggle(chb_speed);
        if (save.Items.HasFlag(Items.ScrewAttack)) ItemToggle(chb_screw);
        if (save.Items.HasFlag(Items.SpaceJump)) ItemToggle(chb_space);
        if (save.Items.HasFlag(Items.VariaSuit)) ItemToggle(chb_varia);
        if (save.Items.HasFlag(Items.GravitySuit)) ItemToggle(chb_gravity);
    }

    private void button_go_Click(object sender, EventArgs e)
    {
        try
        {
            bool debug = chb_debug.Checked;
            byte xPos = Hex.ToByte(textBox_xPos.Text);
            byte yPos = Hex.ToByte(textBox_yPos.Text);

            save.Suit = (Suit)cbb_suit_type.SelectedIndex;

            int oldradix = Hex.radix;
            Hex.radix = 10;
            save.CurrentEnergy = Hex.ToUshort(txb_energy_cur.Text);
            save.MaxEnergy = Hex.ToUshort(txb_energy_max.Text);
            save.CurrentMissiles = Hex.ToUshort(txb_missile_cur.Text);
            save.MaxMissiles = Hex.ToUshort(txb_missile_max.Text);
            save.CurrentSupers = Hex.ToByte(txb_supers_cur.Text);
            save.MaxSupers = Hex.ToByte(txb_supers_max.Text);
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
        if (sender.Checked) { sender.Image = Properties.Resources.item_enabled; }
        else sender.Image = Properties.Resources.item_disabled;
    }

    private void ToggleSuitGraphic()
    {
        if (cbb_suit_type.SelectedIndex == (int)Suit.Suitless) pbx_suit.Image = Properties.Resources.item_zero;
        else if (cbb_suit_type.SelectedIndex == (int)Suit.FullPower)
        {
            if (chb_gravity.Checked) pbx_suit.Image = Properties.Resources.item_full_gravity;
            else if (chb_varia.Checked) pbx_suit.Image = Properties.Resources.item_full_varia;
            else pbx_suit.Image = Properties.Resources.item_full_power;
        }
        else
        {
            if (chb_gravity.Checked) pbx_suit.Image = Properties.Resources.item_gravity;
            else if (chb_varia.Checked) pbx_suit.Image = Properties.Resources.item_varia;
            else pbx_suit.Image = Properties.Resources.item_power;
        }
    }

    private void chb_beams_bombs_click(object sender, EventArgs e)
    {
        PictureBoxInterpolation pb = sender as PictureBoxInterpolation;
        ItemToggle(pb);

        //Adjusting value
        BeamBombs bb = (BeamBombs)Enum.Parse(typeof(BeamBombs), pb.Tag.ToString());
        if (!pb.Checked) save.BeamBombs &= ~bb;
        else save.BeamBombs |= bb;
    }

    private void chb_items_click(object sender, EventArgs e)
    {
        PictureBoxInterpolation pb = sender as PictureBoxInterpolation;
        ItemToggle(pb);

        //Adjusting value
        Items bb = (Items)Enum.Parse(typeof(Items), pb.Tag.ToString());
        if (!pb.Checked) save.Items &= ~bb;
        else save.Items |= bb;

        //Toggling suit graphics
        ToggleSuitGraphic();
    }

    private void chb_debug_Click(object sender, EventArgs e)
    {
        PictureBoxInterpolation pb = sender as PictureBoxInterpolation;
        ItemToggle(pb);
    }

    private void cbb_suit_type_SelectedIndexChanged(object sender, EventArgs e)
    {
        ToggleSuitGraphic();
    }
}

public class PictureBoxInterpolation : PictureBox
{
    public override Color BackColor { get => Color.Transparent; }
    public bool Checked { get; set; } = false;

    public InterpolationMode InterpolationMode
    {
        get => interpolationMode;
        set
        {
            interpolationMode = value;
            Invalidate();
        }
    }
    private InterpolationMode interpolationMode = InterpolationMode.NearestNeighbor;

    protected override void OnPaint(PaintEventArgs pe)
    {
        pe.Graphics.InterpolationMode = InterpolationMode;
        pe.Graphics.PixelOffsetMode = PixelOffsetMode.Half;
        base.OnPaint(pe);
    }
}