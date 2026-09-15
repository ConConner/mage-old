using mage.Properties;
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

namespace mage.Options.Pages;

public partial class PageSprites : UserControl, IReloadablePage
{
    bool init = false;

    public PageSprites()
    {
        InitializeComponent();
        LoadPage();
    }
    public void LoadPage()
    {
        init = true;
        checkBox_allow_ff_sprites.Checked = Version.ProjectConfig.SpritesetAddMoreSprites;
        init = false;

        string spriteNum = Hex.ToString(0xFF);
        checkBox_allow_ff_sprites.Text = $"Allow usage of Sprite IDs up to {spriteNum} in Spriteset Editor";
    }

    private void checkBox_allow_ff_sprites_CheckedChanged(object sender, EventArgs e)
    {
        if (init) return;
        Version.ProjectConfig.SpritesetAddMoreSprites = checkBox_allow_ff_sprites.Checked;
    }
}
