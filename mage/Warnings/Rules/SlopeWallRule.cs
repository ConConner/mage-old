using System;
using System.Collections.Generic;
using System.Text;

namespace mage.Warnings.Rules;

public class SlopeWallRule : IClipdataRule
{
    public string Name => "Slope leads into wall";
    public string Description => "A slope must not lead directly into a wall.";
    public int NeighborhoodRadius => 1;

    public bool MfExclusive { get; } = false;
    public bool ZmExclusive { get; } = false;

    private ClipdataError Error(TileContext ctx) => new(ctx.X, ctx.Y, this, Description);

    public ClipdataError? Check(TileContext ctx)
    {
        var self = ctx.Get(0, 0);
        if (!self.IsSlope()) return null;

        bool leftFacing = self.IsLeftFacingSlope();
        var wallLeft = ctx.Get(-1, leftFacing ? -1 : 0);
        var wallRight = ctx.Get(1, leftFacing ? 0 : -1);
        if (wallLeft.IsSolid() || wallRight.IsSolid()) return Error(ctx);

        return null;
    }
}
