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

namespace mage.Tools;

public partial class FormOffsetGrabber : Form
{
    public FormOffsetGrabber(Room r, int x, int y)
    {
        InitializeComponent();

        ThemeSwitcher.ChangeTheme(Controls, this);
        ThemeSwitcher.InjectPaintOverrides(Controls);

        txb_clip.Text = Hex.ToString(GetClipPointerOfCoordinates(r, x, y));
        txb_bg.Text = Hex.ToString(GetBg1PointerOfCoordinates(r, x, y));
        txb_mmx.Text = Hex.ToString(r.header.mapX + (x - 2) / 0xF);
        txb_mmy.Text = Hex.ToString(r.header.mapY + (y - 2) / 0xA);
    }

    private int CountRLETiles(int target, int offset)
    {
        ByteStream bs = ROM.Stream;

        int count = 0;
        int read = offset;
        while (count <= target)
        {
            byte b = bs.Read8(read++);
            if (b > 0x80) 
            {
                b -= 0x80;
                count += b;
                if (count > target) return -1;

                read++;
            }
            else
            {
                if (count + b < target)
                {
                    count += b;
                    read += b;
                }
                else
                {
                    read += b - (count + b - target);
                    break;
                }
            }
        }
        return read;
    }

    private int GetClipPointerOfCoordinates(Room r, int x, int y)
    {
        int clipPtr = r.header.clipPtr;
        int roomWidth = ROM.Stream.Read8(clipPtr);

        return CountRLETiles(y * roomWidth + x, clipPtr + 3);
    }

    private int GetBg1PointerOfCoordinates(Room r, int x, int y)
    {
        int bg1Ptr = r.header.BG1ptr;
        int roomWidth = ROM.Stream.Read8(bg1Ptr);

        return CountRLETiles(y * roomWidth + x, bg1Ptr + 3);
    }
}
