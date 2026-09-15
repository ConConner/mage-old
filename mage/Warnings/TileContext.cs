using System;
using System.Collections.Generic;
using System.Text;

namespace mage.Warnings;

public readonly struct TileContext
{
    public int X { get; init; }
    public int Y { get; init; }
    public Backgrounds Grid { get; init; }

    public Block Get(int dx, int dy)
    {
        Block? b = Grid.GetBlockClamped(X + dx, Y + dy);
        return b ?? new();
    }
}
