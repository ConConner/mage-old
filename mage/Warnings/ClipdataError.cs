using System;
using System.Collections.Generic;
using System.Text;

namespace mage.Warnings;

public class ClipdataError
{
    public int X { get; init; }
    public int Y { get; init; }
    public IClipdataRule Rule { get; init; }
    public string Message { get; init; }

    public ClipdataError(int x, int y, IClipdataRule rule, string message)
    {
        X = x;
        Y = y;
        Rule = rule;
        Message = message;
    }
}
