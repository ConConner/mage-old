using System;
using System.Collections.Generic;
using System.Text;

namespace mage.Warnings.Rules;

public class SlopeBelowCeilingRule : IClipdataRule
{
    public string Name => "Slope below ceiling";
    public string Description => "A slope must not be placed directly below a solid block.";
    public int NeighborhoodRadius => 1;

    public bool MfExclusive { get; } = false;
    public bool ZmExclusive { get; } = false;

    public ClipdataError? Check(TileContext ctx)
    {
        var self = ctx.Get(0, 0);
        if (!self.IsSlope()) return null;

        var above = ctx.Get(0, -1);
        if (above.IsSolid()) return new ClipdataError(ctx.X, ctx.Y, this,
            Description);

        return null;
    }
}
