using System;
using System.Collections.Generic;
using System.Text;

namespace mage.Warnings.Rules;

public class CeilingSlopeRule : IClipdataRule
{
    public string Name => "Ceiling slope used";
    public string Description => "Ceiling slopes are unused clipdata and should be replaced with air.";
    public int NeighborhoodRadius => 0;

    public bool MfExclusive { get; } = false;
    public bool ZmExclusive { get; } = false;

    public ClipdataError? Check(TileContext ctx)
    {
        var self = ctx.Get(0, 0);
        if (!self.IsCeilingSlope()) return null;
        return new ClipdataError(ctx.X, ctx.Y, this, Description);
    }
}
