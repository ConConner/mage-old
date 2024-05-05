using System;
using System.Drawing;

namespace mage
{
    public class Door : RoomObject
    {
        // properties
        public bool Edited { get; set; }
        
        // fields
        public byte doorNum;
        public byte areaID;

        public byte type;
        public byte srcRoom;
        public byte xStart, xEnd;
        public byte yStart, yEnd;
        public byte dstDoor;
        public byte xExitDistance;
        public byte yExitDistance;
        public int xScreen => (xStart - 2) / 15;
        public int yScreen => (yStart - 2) / 10;

        // constructor
        public Door()
        {

        }

        public override Rectangle DrawingBounds
        {
            get { return new Rectangle(xStart * 16, yStart * 16, (xEnd - xStart + 1) * 16, (yEnd - yStart + 1) * 16); }
        }

        public override RoomObject Copy()
        {
            Door copy = new Door();
            copy.doorNum = this.doorNum;
            copy.areaID = this.areaID;

            copy.type = this.type;
            copy.srcRoom = this.srcRoom;
            copy.xStart = this.xStart;
            copy.xEnd = this.xEnd;
            copy.yStart = this.yStart;
            copy.yEnd = this.yEnd;
            copy.dstDoor = this.dstDoor;
            copy.xExitDistance = this.xExitDistance;
            copy.yExitDistance = this.yExitDistance;
            return copy;
        }

        public override void SetValue(RoomObject newObj)
        {
            Door d = (Door)newObj;
            Edited = true;
            this.doorNum = d.doorNum;
            this.areaID = d.areaID;

            this.type = d.type;
            this.srcRoom = d.srcRoom;
            this.xStart = d.xStart;
            this.xEnd = d.xEnd;
            this.yStart = d.yStart;
            this.yEnd = d.yEnd;
            this.dstDoor = d.dstDoor;
            this.xExitDistance = d.xExitDistance;
            this.yExitDistance = d.yExitDistance;
        }

        public override RoomObject Move(Point diff, int num)
        {
            Door copy = (Door)this.Copy();
            if (xStart + diff.X < 0 || yStart + diff.Y < 0) { return copy; }

            copy.Edited = true;

            copy.xStart += (byte)diff.X;
            copy.xEnd += (byte)diff.X;
            copy.yStart += (byte)diff.Y;
            copy.yEnd += (byte)diff.Y;
            return copy;
        }

        public override void Add(Point pos)
        {
            Edited = true;
            type = 0x14;
            xStart = (byte)pos.X;
            xEnd = (byte)pos.X;
            yStart = (byte)pos.Y;
            yEnd = (byte)(pos.Y + 3);
            dstDoor = 0;
            xExitDistance = 0;
            yExitDistance = 0;
        }

        public DoorPosition EdgePosition()
        {
            Room r = new Room(areaID, srcRoom);

            //Check naive cases where door is behind room edge
            if (xStart <= 1) return DoorPosition.Left;
            if (xEnd >= r.Width - 2) return DoorPosition.Right;
            if (yStart <= 1) return DoorPosition.Top;
            if (yEnd >= r.Height - 2) return DoorPosition.Down;

            //Check position relative on screen
            if (xStart - 2 == (xScreen * 15)) return DoorPosition.Left;
            if (xEnd - 2 == (xScreen * 15) + 14) return DoorPosition.Right;
            if (yStart - 2 == (yScreen * 10)) return DoorPosition.Top;
            if (yEnd - 2 == (yScreen * 10) + 9) return DoorPosition.Down;

            return DoorPosition.None;
        }

        /// <summary>
        /// Returns a point that fixes for a screen coordinate that lies on the 2 tile border
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public Point ScreenCoordinatesFixed(Room r)
        {
            int screenX = Math.Min(xScreen, r.WidthInScreens - 1);
            int screenY = Math.Min(yScreen, r.HeightInScreens - 1);
            return new Point(screenX, screenY);
        }
    }
}

public enum DoorPosition
{
    Left,
    Top,
    Right,
    Down,
    None
}