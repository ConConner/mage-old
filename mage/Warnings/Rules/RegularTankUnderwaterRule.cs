using System;
using System.Collections.Generic;
using System.Text;

namespace mage.Warnings.Rules;

public class RegularTankUnderwaterRule : IClipdataRule
{
    public string Name => "Regular Tank below water";
    public string Description => "Regular Tanks should only be placed outside of water. Use Underwater Tank instead.";
    public int NeighborhoodRadius => 1;

    public bool MfExclusive { get; } = false;
    public bool ZmExclusive { get; } = false;

    public ClipdataError? Check(TileContext ctx)
    {
        var self = ctx.Get(0, 0);
        if (!self.IsRegularTank()) return null;

        var left = ctx.Get(-1, 0);
        var right = ctx.Get(1, 0);
        var top = ctx.Get(0, -1);
        var bottom = ctx.Get(0, 1);

        if (left.IsWater() || right.IsWater() || top.IsWater() || bottom.IsWater())
            return new(ctx.X, ctx.Y, this, Description);

        return null;
    }
}
