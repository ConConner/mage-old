using System;
using System.Collections.Generic;
using System.Text;

namespace mage.Warnings.Rules;

public class PirateWallJumpObstructionRule : IClipdataRule
{
    public string Name => "Space Pirate wall jump point obstructed";
    public string Description => "A Space Pirate wall jump point must have at least one accessible wall.";
    public int NeighborhoodRadius => 1;

    public bool MfExclusive { get; } = false;
    public bool ZmExclusive { get; } = true;

    public ClipdataError? Check(TileContext ctx)
    {
        var self = ctx.Get(0, 0);
        if (!self.IsPirateWallJumpPoint()) return null;

        var left = ctx.Get(-1, 0);
        var right = ctx.Get(1, 0);

        if (left.IsSolid() && right.IsSolid()) return new ClipdataError(ctx.X, ctx.Y, this, Description);

        return null;
    }
}
