using System;
using System.Collections.Generic;
using System.Text;

namespace mage.Warnings;

public interface IClipdataRule
{
    string Name { get; }
    string Description { get; }

    /// <summary>
    /// How many tiles around the checked tile this rule needs to see
    /// </summary>
    int NeighborhoodRadius { get; }

    bool MfExclusive { get; }
    bool ZmExclusive { get; }

    string RuleKey => GetType().Name;

    ClipdataError? Check(TileContext ctx);
}
