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
    public partial class FormTestRoomFusion : Form
    {
        FormMain main;

        public FormTestRoomFusion(FormMain main)
        {
            InitializeComponent();

            ThemeSwitcher.ChangeTheme(Controls, this);
            ThemeSwitcher.InjectPaintOverrides(Controls);

            txb_x.Text = "0";
            txb_y.Text = "0";

            this.main = main;
        }

        private void btn_go_Click(object sender, EventArgs e)
        {
            try
            {
                bool debug = chb_debug.Checked;
                byte xPos = Hex.ToByte(txb_x.Text);
                byte yPos = Hex.ToByte(txb_y.Text);

                Test.Room(main, debug, xPos, yPos);
            }
            catch(Exception ex)
            {
                MessageBox.Show("One of the values entered was not valid.\n\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
