using mage.Theming;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace mage
{
    public partial class FormImportRLEBG : Form
    {
        // fields
        private PortImage pi;

        private FormMain main;
        private ByteStream romStream;
        private Room room;

        // constructor
        public FormImportRLEBG(FormMain main)
        {
            InitializeComponent();

            ThemeSwitcher.ChangeTheme(Controls, this);
            ThemeSwitcher.InjectPaintOverrides(Controls);

            this.main = main;
            this.romStream = ROM.Stream;
            this.room = main.Room;

            for (int i = 0; i < Version.NumOfTilesets; i++)
            {
                comboBox_tileset.Items.Add(Hex.ToString(i));
            }
            comboBox_tileset.SelectedIndex = 0;
        }

        private void button_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog tilesetFile = new OpenFileDialog();
            tilesetFile.Filter = "Bitmaps (*.png, *.bmp, *.gif, *.jpeg, *.jpg, *.tif, *.tiff)|*.png;*.bmp;*.gif;*.jpeg;*.jpg;*.tif;*.tiff";
            if (tilesetFile.ShowDialog() == DialogResult.OK)
            {
                // check image
                Bitmap image = new Bitmap(tilesetFile.FileName);

                if (image.PixelFormat != System.Drawing.Imaging.PixelFormat.Format32bppArgb)
                {
                    errorMessage("Invalid pixel format. Image must be 32bpp.");
                    image.Dispose();
                    return;
                }

                if (image.Width != 256 || image.Height % 16 != 0 || image.Height > 1024)
                {
                    string message = "Invalid dimensions.\n\r";

                    if (image.Width != 256) message += "\n\rImage width is not 256!";
                    if (image.Height % 16 != 0) message += "\n\rImage height is not divisible by 16!";
                    if (image.Height > 1024) message += "\n\rImage height is bigger than 1024!";

                    errorMessage(message);
                    image.Dispose();
                    return;
                }

                try
                {
                    pi = new PortImage(image);
                }
                catch (FormatException ex)
                {
                    errorMessage(ex.Message);
                    return;
                }

                groupBox_select.Enabled = true;
                groupBox_palette.Enabled = true;
                checkBox_preserveData.Enabled = true;
                button_ok.Enabled = true;
                radioButton_current.Checked = true;
            }
        }

        private void errorMessage(string message) => MessageBox.Show(message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        private void checkBox_autoRows_CheckedChanged(object sender, EventArgs e)
        {
            listBox_rows.Enabled = !checkBox_autoRows.Checked;
        }

        private List<int> GetPaletteRows(Tileset ts)
        {
            List<int> rows = new List<int>();

            if (checkBox_autoRows.Checked)
            {
                // get rows used in current tileset
                bool[] rowsUsed = new bool[16];
                foreach (ushort tile in ts.tileTable)
                {
                    int pal = tile >> 12;
                    rowsUsed[pal] = true;
                }

                for (int r = 1; r < 14; r++)
                {
                    if (rowsUsed[r + 2])
                    {
                        rows.Add(r);
                    }
                }

                // get blank rows
                ushort[,] argbs = ts.palette.ARGBs;
                for (int r = 1; r < 14; r++)
                {
                    if (rowsUsed[r + 2]) { continue; }

                    ushort color = argbs[r, 1];
                    bool blank = true;
                    for (int c = 2; c < 16; c++)
                    {
                        if (argbs[r, c] != color)
                        {
                            blank = false;
                            break;
                        }
                    }

                    if (blank) { rows.Add(r); }
                }
            }
            else
            {
                foreach (int r in listBox_rows.SelectedIndices)
                {
                    rows.Add(r + 1);
                }
            }

            return rows;
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            // get tileset number
            byte tsNum = 0;

            if (radioButton_current.Checked)
            {
                tsNum = room.tileset.number;
            }
            else
            {
                tsNum = (byte)comboBox_tileset.SelectedIndex;
            }

            // import
            Tileset ts = new Tileset(romStream, tsNum);
            VramBG vram = new VramBG(ts, false);

            // get rows
            List<int> rows = GetPaletteRows(ts);
           
            try
            {
                pi.GetData(vram, rows, true, false);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // write data
            bool shared = !checkBox_preserveData.Checked;
            pi.WritePalette(ts.addr + 4, shared);
            pi.WriteGfx(ts.addr, ts.RLEgfx.origLen, shared);
            pi.WriteTileTable(ts.addr + 0xC, ts.tileTable.Length * 2 + 2, shared);

            // update editors
            FormMain.UpdateEditors();

            Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
