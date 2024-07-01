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
using static System.Net.Mime.MediaTypeNames;

namespace mage.Dialogs
{
    public partial class BG3ScrollDialog : Form
    {
        public byte Value = 0;

        public BG3ScrollDialog()
        {
            InitializeComponent();

            //Theming
            ThemeSwitcher.ChangeTheme(Controls, this);
            ThemeSwitcher.InjectPaintOverrides(Controls);

            DialogResult = DialogResult.Cancel;
        }

        private void returnValue(byte value)
        {
            DialogResult = DialogResult.OK;
            Value = value;
            Close();
        }

        private void buttonClicked(object sender, EventArgs e)
        {
            Button b = sender as Button;
            int val = Convert.ToInt32(b.Tag.ToString(), 10);
            returnValue((byte)val);
        }
    }
}
