using System;
using System.Collections.Generic;
using System.Text;

namespace mage.Warnings.Rules;

public class LadderObstructionRule : IClipdataRule
{
    public string Name => "Ladder obstructed";
    public string Description => "A ladder must not be blocked on its attachable side";
    public int NeighborhoodRadius => 1;

    public bool MfExclusive { get; } = true;
    public bool ZmExclusive { get; } = false;

    public ClipdataError? Check(TileContext ctx)
    {
        var self = ctx.Get(0, 0);
        if (!self.IsCeilingLadder() && !self.IsLeftWallLadder() && !self.IsRightWallLadder()) return null;

        var left = ctx.Get(-1, 0);
        var right = ctx.Get(1, 0);
        var bottom = ctx.Get(0, 1);

        if (self.IsCeilingLadder() && bottom.IsSolid()) return new ClipdataError(ctx.X, ctx.Y, this, Description);
        if (self.IsRightWallLadder() && left.IsSolid()) return new ClipdataError(ctx.X, ctx.Y, this, Description);
        if (self.IsLeftWallLadder() && right.IsSolid()) return new ClipdataError(ctx.X, ctx.Y, this, Description);

        return null;
    }
}
