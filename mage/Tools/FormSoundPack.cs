using mage.Theming;
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

namespace mage.Tools
{
    public partial class FormSoundPack : Form
    {
        public FormSoundPack()
        {
            InitializeComponent();

            ThemeSwitcher.ChangeTheme(Controls, this);
            ThemeSwitcher.InjectPaintOverrides(this.Controls);

            LoadPackNames();
        }

        /// <summary>
        /// Populates the combobox with all the available packs
        /// </summary>
        private void LoadPackNames()
        {
            lst_packs.Items.Clear();

            if (!Directory.Exists(Sound.SoundPacksPath)) return;

            int selectIndex = -1;
            int count = -1;
            foreach (string dir in Directory.GetDirectories(Sound.SoundPacksPath))
            {
                //check if pack.info exists
                if (!File.Exists(Path.Combine(dir, "pack.info"))) continue;
                count++;

                string name = Path.GetFileName(dir);
                lst_packs.Items.Add(name);

                if (name == Sound.SoundPackName) selectIndex = count;
            }

            lst_packs.SelectedIndex = selectIndex;
        }

        private void btn_select_path_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() != DialogResult.OK) return;

            Sound.SoundPacksPath = dialog.SelectedPath;

            LoadPackNames();
        }

        private void lst_packs_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lst_packs.SelectedIndex;
            if (index == -1)
            {
                Sound.SoundPackName = "";
                return;
            }
            Sound.SoundPackName = lst_packs.Items[index].ToString();

            //Load pack.info
            string fullPath = Path.Combine(Sound.SoundPacksPath, Sound.SoundPackName);
            if (!Directory.Exists(fullPath)) return;
            fullPath = Path.Combine(fullPath, "pack.info");

            string info = File.ReadAllText(fullPath);
            txb_info.Text = info;
        }
    }
}
