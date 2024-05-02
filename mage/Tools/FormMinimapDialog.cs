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

    Point mPos;
    Size RoomSize;

    public Point SelectedPoint { get; private set; }

    public FormMinimapDialog(byte areaID, Size roomSize)
    {
        InitializeComponent();

        RoomSize = roomSize;

        //Loading Palette
        int paletteOffset = Version.MinimapPaletteOffset;
        int numPalettes;
        if (Version.IsMF) { numPalettes = 3; }
        else { numPalettes = 5; }
        palette = new Palette(ROM.Stream, paletteOffset, numPalettes);
        palette.SetARGB(1, 0, 0);

        //loading map gfx
        current = ROM.LoadMinimap(areaID);
        LoadMap();
    }

    private void LoadMap()
    {
        Bitmap mapImg = current.Draw(ROM.Stream, palette, 0);
        gfxView_map.BackgroundImage = mapImg;
    }

    private void gfxView_map_MouseClick(object sender, MouseEventArgs e)
    {
        int x = e.X >> 4;
        int y = e.Y >> 4;

        SelectedPoint = new Point(x, y);
        DialogResult = DialogResult.OK;
        Close();
    }

    private void gfxView_map_MouseMove(object sender, MouseEventArgs e)
    {
        int x = e.X >> 4;
        int y = e.Y >> 4;
        if (x == mPos.X && y == mPos.Y) { return; }
        if (x < 0 || x >= 32 || y < 0 || y >= 32) { return; }

        mPos = new Point(x, y);

        // draw red rectangle
        Rectangle rect = gfxView_map.redRect;
        gfxView_map.redRect = new Rectangle(x * 16, y * 16, (16 * RoomSize.Width) - 1, (16 * RoomSize.Height) - 1);
        rect = Draw.Union(rect, gfxView_map.redRect);
        gfxView_map.Invalidate(rect);
    }
}
