using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace mage.Data;

/// <summary>
/// Data structure storing sRAM data. Only used for ZM as of now since Fusion has a debug menu
/// </summary>
public class sRam
{
    public ByteStream RomStream { get; set; }
    private int sramAddr = 0x7D8000;

    public sRam(ByteStream bs)
    {
        this.RomStream = bs;
    }

    [JsonConstructor]
    public sRam() { }


    //Not SRAM stuff
    public bool DebugMenu { get; set; } = true;
    public int xPos { get; set; } = 0;
    public int yPos { get; set; } = 0;

    public ushort MaxEnergy { get; set; } = 99;
    public ushort MaxMissiles { get; set; } = 0x5;
    public byte MaxSupers { get; set; } = 0x2;
    public byte MaxPowerBombs { get; set; } = 0x2;
    public byte CurrentPowerBombs { get; set; } = 0x2;
    public ushort CurrentEnergy { get; set; } = 99;
    public ushort CurrentMissiles { get; set; } = 0x5;
    public byte CurrentSupers { get; set; } = 0x2;
    public BeamBombs BeamBombs { get; set; } = 0;
    public Items Items { get; set; } = 0;
    public const byte MapStatus = 0xFF;
    public const byte LowHealthFlag = 0x0;
    public Suit Suit { get; set; } = Suit.Normal;
    public const byte GrabbedByMetroid = 0x0;

    public void WriteToRom()
    {
        if (RomStream == null) throw new Exception("No ROM Stream specified");

        //Writing Samus Equipment Data
        RomStream.Seek(sramAddr + 0x19C);

        RomStream.Write16(MaxEnergy);
        RomStream.Write16(MaxMissiles);
        RomStream.Write8(MaxSupers);
        RomStream.Write8(MaxPowerBombs);
        RomStream.Write16(CurrentEnergy);
        RomStream.Write16(CurrentMissiles);
        RomStream.Write8(CurrentSupers);
        RomStream.Write8(CurrentPowerBombs);
        RomStream.Write8((byte)BeamBombs);
        RomStream.Write8((byte)BeamBombs); //Activation flags
        RomStream.Write8((byte)Items);
        RomStream.Write8((byte)Items); //Activation flags
        RomStream.Write8(MapStatus);
        RomStream.Write8(LowHealthFlag);
        RomStream.Write8((byte)Suit);
        RomStream.Write8(GrabbedByMetroid);
    }
}

[Flags]
public enum BeamBombs
{
    LongBeam = 1,
    IceBeam = 2,
    WaveBeam = 4,
    PlasmaBeam = 8,
    ChargeBeam = 16,
    Bombs = 128,
}

[Flags]
public enum Items
{
    HiJump = 1,
    SpeedBooster = 2,
    SpaceJump = 4,
    ScrewAttack = 8,
    VariaSuit = 16,
    GravitySuit = 32,
    MorphBall = 64,
    PowerGrip = 128,
}

public enum Suit
{
    Normal,
    FullPower,
    Suitless
}