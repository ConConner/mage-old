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
public class sRamMf : IsRam
{
    private int sramAddr = 0x65C500;


    [JsonConstructor]
    public sRamMf() { }


    //Not SRAM stuff but for general testing
    public bool DebugMenu { get; set; } = false;
    public int xPos { get; set; } = 0;
    public int yPos { get; set; } = 0;

    // SRAM outside equipment
    public byte EventCounter { get; set; } = 0;

    // SRAM in order
    public ushort CurrentEnergy { get; set; } = 99;
    public ushort MaxEnergy { get; set; } = 99;
    public ushort CurrentMissiles { get; set; } = 10;
    public ushort MaxMissiles { get; set; } = 10;
    public byte CurrentPowerBombs { get; set; } = 5;
    public byte MaxPowerBombs { get; set; } = 5;
    public BeamStatus BeamStatus { get; set; } = 0;
    public MissileBombStatus MissileBombStatus { get; set; } = 0;
    public SuitMiscStatus SuitMiscStatus { get; set; } = 0;
    public SecurityHatchLevel SecurityHatchLevel { get; set; } = 0;
    public byte DownloadedMaps { get; set; } = 0xFF;
    public byte LowHealthFlag { get; set; } = 0;

    public void WriteToRom()
    {
        if (ROM.Stream == null) throw new Exception("No ROM Stream specified");

        //Writing Event
        ROM.Stream.Write8(sramAddr + 0x21, EventCounter);

        //Writing Samus Equipment Data
        ROM.Stream.Seek(sramAddr + 0xC4);

        ROM.Stream.Write16(CurrentEnergy);
        ROM.Stream.Write16(MaxEnergy);
        ROM.Stream.Write16(CurrentMissiles);
        ROM.Stream.Write16(MaxMissiles);
        ROM.Stream.Write8(CurrentPowerBombs);
        ROM.Stream.Write8(MaxPowerBombs);
        ROM.Stream.Write8((byte)BeamStatus);
        ROM.Stream.Write8((byte)MissileBombStatus);
        ROM.Stream.Write8((byte)SuitMiscStatus);
        ROM.Stream.Write8((byte)SecurityHatchLevel);
        ROM.Stream.Write8(DownloadedMaps);
        ROM.Stream.Write8(LowHealthFlag);
    }
}

[Flags]
public enum BeamStatus
{
    ChargeBeam = 0x1,
    WideBeam = 0x2,
    PlasmaBeam = 0x4,
    WaveBeam = 0x8,
    IceBeam = 0x10,
}

[Flags]
public enum MissileBombStatus
{
    Missiles = 0x1,
    SuperMissiles = 0x2,
    IceMissiles = 0x4,
    DiffusionMissiles = 0x8,
    Bombs = 0x10,
    PowerBombs = 0x20,
}

[Flags]
public enum SuitMiscStatus
{
    HiJump = 0x1,
    SpeedBooster = 0x2,
    SpaceJump = 0x4,
    ScrewAttack = 0x8,
    VariaSuit = 0x10,
    GravitySuit = 0x20,
    MorphBall = 0x40,
    SAXSuit = 0x80,
}

public enum SecurityHatchLevel
{
    White = 0,
    Level1 = 1,
    Level2 = 2,
    Level3 = 3,
    Level4 = 4,
    NoHatches = 0xFF,
}