using mage.Warnings;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace mage.Actions.RoomEditor
{
    public class EditBlocks : RoomAction
    {
        // fields
        private Dictionary<Point, Block> blocks;
        private Rectangle region;
        private int _bgNum;
        private bool _updateClip;
        private Backgrounds _backgrounds;


        // constructor
        public EditBlocks(Backgrounds backgrounds, Block[,] clipboard, Point ptDst, int bgNum, ushort clipVal, bool combine)
        {
            this.combine = combine;

            _bgNum = bgNum;
            _backgrounds = backgrounds;

            int width = Math.Min(clipboard.GetLength(0), backgrounds.width - ptDst.X);
            int height = Math.Min(clipboard.GetLength(1), backgrounds.height - ptDst.Y);
            region = new Rectangle(ptDst.X * 16, ptDst.Y * 16, width * 16, height * 16);

            _updateClip = (clipVal != 0xFFFF);
            blocks = new Dictionary<Point, Block>();

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    // get source and destination blocks
                    Block src = clipboard[x, y];
                    int u = ptDst.X + x;
                    int v = ptDst.Y + y;
                    Block dst = backgrounds.GetBlock(u, v);

                    // give destination block new values
                    if (bgNum != -1) { dst[bgNum] = src[bgNum]; }
                    if (_updateClip)
                    {
                        if (clipVal == 0xFFFE) { dst.CLP = src.CLP; }
                        else { dst.CLP = clipVal; }
                    }
                    blocks.Add(new Point(u, v), dst);
                }
            }
        }

        public override void Do(Room room)
        {
            Dictionary<Point, Block> backup = new Dictionary<Point, Block>();

            List<(int x, int y)> changedTiles = new();
            foreach (KeyValuePair<Point, Block> kvp in blocks)
            {
                Point p = kvp.Key;
                changedTiles.Add((p.X, p.Y));
                Block b = room.backgrounds.GetBlock(p.X, p.Y);
                backup.Add(p, b);
                room.backgrounds.SetBlock(kvp.Value, p.X, p.Y);
            }

            blocks = backup;

            // mark backgrounds edited
            if (_bgNum != -1)
            {
                _backgrounds[_bgNum].Edited = true;
            }

            if (_updateClip)
            {
                _backgrounds.clip.Edited = true;
                FormMain.Instance.roomRuleValidator?.OnTilesChanged(changedTiles);
            }
        }

        public override void Undo(Room room)
        {
            Do(room);
        }

        public override Rectangle AffectedRegion
        {
            get { return region; }
        }

        public override string ActionText
        {
            get { return "Edit blocks"; }
        }

        public override bool TryCombine(Action a)
        {
            EditBlocks newer = a as EditBlocks;
            if (newer == null) { return false; }

            // resize region
            region = Rectangle.Union(region, newer.region);

            // copy blocks
            foreach (KeyValuePair<Point, Block> kvp in newer.blocks)
            {
                if (!blocks.ContainsKey(kvp.Key))
                {
                    blocks.Add(kvp.Key, kvp.Value);
                }
            }

            return true;
        }


    }
}
