using System;
using System.Collections.Generic;
using System.Text;

namespace mage.Data;

public interface IsRam
{
    public bool DebugMenu { get; set; }
    public int xPos { get; set; }
    public int yPos { get; set; }
    public void WriteToRom();
}
