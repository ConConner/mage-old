using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Text;

namespace mage.Warnings;

public static class ClipdataLists
{
    private static bool mf => Version.IsMF;

    // SOLID
    private static readonly FrozenSet<int> zmSolidClip =
        new[] { 0x02, 0x09, 0x10, 0x18, 0x19, 0x1A, 0x1C, 0x1D, 0x1E, 0x29, 0x2A, 0x2C, 0x2D }.ToFrozenSet();
    private static readonly FrozenSet<int> mfSolidClip =
        new[] { 0x09, 0x10, 0x1C, 0x1D, 0x1E, 0x29, 0x2A, 0x2C, 0x2D }.ToFrozenSet();
    public static bool IsSolid(this Block b)
        => mf ? mfSolidClip.Contains(b.CLP) : zmSolidClip.Contains(b.CLP);

    // SLOPES
    private static readonly FrozenSet<int> slopeClip =
        new[] { 0x11, 0x12, 0x13, 0x14, 0x15, 0x16 }.ToFrozenSet();
    public static bool IsSlope(this Block b) => slopeClip.Contains(b.CLP);

    private static readonly FrozenSet<int> slightSlopeClip =
        new[] { 0x13, 0x14, 0x15, 0x16 }.ToFrozenSet();
    public static bool IsSlightSlope(this Block b) => slightSlopeClip.Contains(b.CLP);
    public static bool IsSteepSlope(this Block b) => b.IsSlope() && !b.IsSlightSlope();

    private static readonly FrozenSet<int> leftFacingSlopeClip =
        new[] { 0x12, 0x15, 0x16 }.ToFrozenSet();
    public static bool IsLeftFacingSlope(this Block b) => leftFacingSlopeClip.Contains(b.CLP);
    public static bool IsRightFacingSlope(this Block b) => b.IsSlope() && !leftFacingSlopeClip.Contains(b.CLP);

    private static readonly FrozenSet<int> ceilingSlopeClip =
        new[] { 0x21, 0x22, 0x23, 0x24, 0x25, 0x26 }.ToFrozenSet();
    public static bool IsCeilingSlope(this Block b) => ceilingSlopeClip.Contains(b.CLP);

    // TANKS
    private static readonly FrozenSet<int> zmTanks =
        new[] { 0x5C, 0x5D, 0x5E, 0x5F, 0x6C, 0x6D, 0x6E, 0x6F, 0x7C, 0x7D, 0x7E, 0x7F }.ToFrozenSet();
    private static readonly FrozenSet<int> mfTanks =
        new[] { 0x62, 0x63, 0x64, 0x65, 0x66, 0x67, 0x68, 0x69, 0x6A }.ToFrozenSet();
    private static readonly FrozenSet<int> zmHiddenTanks =
        new[] { 0x6C, 0x6D, 0x6E, 0x6F }.ToFrozenSet();
    private static readonly FrozenSet<int> mfHiddenTanks =
        new[] { 0x64, 0x65, 0x69 }.ToFrozenSet();
    private static readonly FrozenSet<int> zmUnderwaterTanks =
        new[] { 0x7C, 0x7D, 0x7E, 0x7F }.ToFrozenSet();
    private static readonly FrozenSet<int> mfUnderwaterTanks =
        new[] { 0x66, 0x67, 0x6A }.ToFrozenSet();
    public static bool IsTank(this Block b) => mf ? mfTanks.Contains(b.CLP) : zmTanks.Contains(b.CLP);
    public static bool IsHiddenTank(this Block b) => mf ? mfHiddenTanks.Contains(b.CLP) : zmHiddenTanks.Contains(b.CLP);
    public static bool IsUnderwaterTank(this Block b) => mf ? mfUnderwaterTanks.Contains(b.CLP) : zmUnderwaterTanks.Contains(b.CLP);
    public static bool IsRegularTank(this Block b) => b.IsTank() && !b.IsHiddenTank() && !b.IsUnderwaterTank();

    // OTHER CLIPDATA
    public static bool IsWater(this Block b) => b.CLP == 0x1B;
    public static bool IsCeilingLadder(this Block b) => mf && b.CLP == 0x18;
    public static bool IsRightWallLadder(this Block b) => mf && b.CLP == 0x19;
    public static bool IsLeftWallLadder(this Block b) => mf && b.CLP == 0x1A;
    public static bool IsPirateWallJumpPoint(this Block b) => !mf && b.CLP == 0x19;
}
