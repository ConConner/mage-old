using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mage.Tools;

public partial class FormMinimapDialog : Form
{
    Minimap current;
    Palette palette;

    public FormMinimapDialog(byte areaID)
    {
        InitializeComponent();

        int paletteOffset = Version.MinimapPaletteOffset;
        palette = new Palette(ROM.Stream, paletteOffset, 1);

        current = ROM.LoadMinimap(areaID);
        LoadMap();
    }

    private void LoadMap()
    {
        Bitmap mapImg = current.Draw(ROM.Stream, palette, 0);
        gfxView_map.BackgroundImage = mapImg;
    }
}
