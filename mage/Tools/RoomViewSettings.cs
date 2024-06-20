using mage.Theming;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mage.Tools
{
    public partial class RoomViewSettings : Form
    {
        FormMain parent;

        public RoomViewSettings(FormMain main)
        {
            InitializeComponent();

            ThemeSwitcher.ChangeTheme(Controls, this);
            ThemeSwitcher.InjectPaintOverrides(Controls);

            parent = main;
            pnl_color.BackColor = GBAtoRGB(main.Bg3Color);
        }

        private void pnl_color_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //Set new background color
                Color c = dialog.Color;
                ushort gbaColor = RGBtoGBA(c);
                parent.Bg3Color = gbaColor;

                //Set new color on Panel
                pnl_color.BackColor = GBAtoRGB(gbaColor);
            }
        }

        private void RoomViewSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (parent.Room == null) return;
            parent.ReloadRoom(false);
        }


        private static Color GBAtoRGB(ushort color)
        {
            byte red = (byte)((color >> 10 & 0b11111) << 3);
            byte green = (byte)((color >> 5 & 0b11111) << 3);
            byte blue = (byte)((color & 0b11111) << 3);

            return Color.FromArgb(red, green, blue);
        }

        private static ushort RGBtoGBA(Color color)
        {
            byte red = (byte)(color.R >> 3);
            byte green = (byte)(color.G >> 3);
            byte blue = (byte)(color.B >> 3);

            return (ushort)(red << 10 | green << 5 | blue);
        }
    }
}
