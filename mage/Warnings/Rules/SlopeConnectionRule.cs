using System;
using System.Collections.Generic;
using System.Text;

namespace mage.Warnings.Rules;

public class SlopeConnectionRule : IClipdataRule
{
    public string Name => "Invalid slope connection";
    public string Description => "A slope may not connect into a misaligned slope.";
    public int NeighborhoodRadius => 1;

    public bool MfExclusive { get; } = false;
    public bool ZmExclusive { get; } = false;

    private ClipdataError Error(TileContext ctx) => new(ctx.X, ctx.Y, this, Description);

    private bool isValidSupport(Block b) => b.IsSolid() || b.IsSlope();


    public ClipdataError? Check(TileContext ctx)
    {
        var self = ctx.Get(0, 0);
        if (!self.IsSlope()) return null;

        bool leftFacing = self.IsLeftFacingSlope();

        //Steep
        var left = ctx.Get(-1, leftFacing ? -1 : 1);
        var right = ctx.Get(1, leftFacing ? 1 : -1);

        if (!left.IsSlope() && !right.IsSlope()) return null;

        if (self.CLP == 0x11)
        {
            if (left.IsSlope() && (left.CLP != 0x11 && left.CLP != 0x14)) return Error(ctx);
            if (right.IsSlope() && (right.CLP != 0x11 && right.CLP != 0x13)) return Error(ctx);
        }
        if (self.CLP == 0x12)
        {
            if (left.IsSlope() && (left.CLP != 0x12 && left.CLP != 0x16)) return Error(ctx);
            if (right.IsSlope() && (right.CLP != 0x12 && right.CLP != 0x15)) return Error(ctx);
        }
        if (self.CLP == 0x13)
            if (left.IsSlope() && (left.CLP != 0x11 && left.CLP != 0x14)) return Error(ctx);
        if (self.CLP == 0x14)
            if (right.IsSlope() && (right.CLP != 0x11 && right.CLP != 0x13)) return Error(ctx);
        if (self.CLP == 0x15)
            if (left.IsSlope() && (left.CLP != 0x12 && left.CLP != 0x16)) return Error(ctx);
        if (self.CLP == 0x16)
            if (right.IsSlope() && (right.CLP != 0x12 && right.CLP != 0x15)) return Error(ctx);

        return null;
    }
}
