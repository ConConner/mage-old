using System;
using System.Collections.Generic;
using System.Text;

namespace mage.Warnings.Rules;

public class SlopeSupportRule : IClipdataRule
{
    public string Name => "Slope lacking support";
    public string Description => "A slope must have supporting solid blocks or other slopes at the beginning and end of the slope.";
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
        var left = ctx.Get(-1, leftFacing ? 0 : 1);
        var right = ctx.Get(1, leftFacing ? 1 : 0);

        if (self.IsSlightSlope())
        {
            if ((self.CLP == 0x13 || self.CLP == 0x15) && !isValidSupport(left)) return Error(ctx);
            if ((self.CLP == 0x14 || self.CLP == 0x16) && !isValidSupport(right)) return Error(ctx);
            return null;
        }

        if (!isValidSupport(left) || !isValidSupport(right)) return Error(ctx);

        return null;
    }
}
