using mage.Warnings.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mage.Warnings;

public class RuleValidator
{
    private readonly List<IClipdataRule> _rules = new();
    private readonly int _maxRadius;

    private readonly Backgrounds _grid;

    private readonly Dictionary<(int x, int y), List<ClipdataError>> _errors = new();
    public IReadOnlyDictionary<(int x, int y), List<ClipdataError>> Errors => _errors;

    public event System.Action<RuleValidator>? ErrorsChanged;

    public RuleValidator(Backgrounds grid, IEnumerable<IClipdataRule> allRules)
    {
        _rules = allRules
            .Where(r => Program.Config.IsRuleEnabled(r.RuleKey) && isCorrectGame(r))
            .ToList();

        _maxRadius = _rules.Max(r => r.NeighborhoodRadius);
        _grid = grid;
    }

    private bool isCorrectGame(IClipdataRule rule)
    {
        if (rule.ZmExclusive && rule.MfExclusive) throw new Exception("Rule cannot be both ZM and MF exclusive");
        if (rule.ZmExclusive && Version.IsMF) return false;
        if (rule.MfExclusive && !Version.IsMF) return false;
        return true;
    }

    public bool HasErrorAt(int x, int y) =>
        _errors.TryGetValue((x, y), out var list) && list.Count > 0;

    private void AddError(int x, int y, ClipdataError error)
    {
        if (!_errors.TryGetValue((x, y), out var list))
        {
            list = new List<ClipdataError>();
            _errors[(x, y)] = list;
        }
        list.Add(error);
    }

    private void ValidateTile(int x, int y)
    {
        var ctx = new TileContext { X = x, Y = y, Grid = _grid };
        foreach (var rule in _rules)
        {
            var error = rule.Check(ctx);
            if (error != null)
                AddError(x, y, error);
        }
    }

    /// <summary>
    /// Re-validates the neighborhood around a single changed tile.
    /// </summary>
    public void OnTileChanged(int x, int y)
    {
        for (int dy = -_maxRadius; dy <= _maxRadius; dy++)
            for (int dx = -_maxRadius; dx <= _maxRadius; dx++)
                _errors.Remove((x + dx, y + dy));

        for (int dy = -_maxRadius; dy <= _maxRadius; dy++)
            for (int dx = -_maxRadius; dx <= _maxRadius; dx++)
            {
                int tx = x + dx;
                int ty = y + dy;
                if (tx >= _grid.width || ty >= _grid.height || tx < 0 || ty < 0) continue;
                ValidateTile(tx, ty);
            }

        ErrorsChanged?.Invoke(this);
    }

    /// <summary>
    /// Re-validates the union of neighborhoods around many changed tiles.
    /// Use this for fill/paste/brush operations.
    /// </summary>
    public void OnTilesChanged(IEnumerable<(int x, int y)> changedTiles)
    {
        var affected = new HashSet<(int x, int y)>();

        foreach (var (x, y) in changedTiles)
        {
            for (int dy = -_maxRadius; dy <= _maxRadius; dy++)
                for (int dx = -_maxRadius; dx <= _maxRadius; dx++)
                {
                    int tx = x + dx;
                    int ty = y + dy;
                    if (tx >= _grid.width || ty >= _grid.height || tx < 0 || ty < 0) continue;
                    affected.Add((tx, ty));
                }
        }

        foreach (var pos in affected)
            _errors.Remove(pos);

        foreach (var (x, y) in affected)
            ValidateTile(x, y);

        ErrorsChanged?.Invoke(this);
    }

    /// <summary>
    /// Full re-validation of the entire room. Use on room load or when
    /// rules change. O(width * height * ruleCount), fine as a one-time
    /// cost, don't call it per edit.
    /// </summary>
    public void ValidateRoom()
    {
        _errors.Clear();

        for (int y = 0; y < _grid.height; y++)
            for (int x = 0; x < _grid.width; x++)
                ValidateTile(x, y);

        ErrorsChanged?.Invoke(this);
    }
}
