using System;
using System.Collections.Generic;
using System.Text;

namespace mage.Warnings.Rules;

public class SlopeUnfinishedRule : IClipdataRule
{
    public string Name => "Unfinished slope";
    public string Description => "A slight slope must have both the lower and upper part.";
    public int NeighborhoodRadius => 1;

    public bool MfExclusive { get; } = false;
    public bool ZmExclusive { get; } = false;

    private ClipdataError Error(TileContext ctx) => new(ctx.X, ctx.Y, this, Description);

    public ClipdataError? Check(TileContext ctx)
    {
        var self = ctx.Get(0, 0);
        if (!self.IsSlightSlope()) return null;

        if (self.CLP == 0x13 && ctx.Get(1, 0).CLP != 0x14) return Error(ctx);
        if (self.CLP == 0x14 && ctx.Get(-1, 0).CLP != 0x13) return Error(ctx);
        if (self.CLP == 0x15 && ctx.Get(1, 0).CLP != 0x16) return Error(ctx);
        if (self.CLP == 0x16 && ctx.Get(-1, 0).CLP != 0x15) return Error(ctx);

        return null;
    }
}
