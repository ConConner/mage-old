using System;
using System.Collections.Generic;
using System.Text;

namespace mage.Warnings.Rules;

public class SlopeFloatingRule : IClipdataRule
{
    public string Name => "Slope floating";
    public string Description => "A slope must not be placed without a solid block below it.";
    public int NeighborhoodRadius => 1;

    public bool MfExclusive { get; } = false;
    public bool ZmExclusive { get; } = false;

    public ClipdataError? Check(TileContext ctx)
    {
        var self = ctx.Get(0, 0);
        if (!self.IsSlope()) return null;

        var below = ctx.Get(0, 1);
        if (!below.IsSolid()) return new ClipdataError(ctx.X, ctx.Y, this,
            Description);

        return null;
    }
}
