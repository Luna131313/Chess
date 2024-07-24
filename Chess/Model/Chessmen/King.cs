using System.Collections.Generic;
using Chess.Interfaces;

namespace Chess.Model.Chessmen;

// TODO Rochade
public class King : Chessman
{
    public override List<int[]> PossibleMoves { get; } = new()
    {
        new[] { 1, 0 },
        new[] { -1, 0 },
        new[] { 0, 1 },
        new[] { 0, -1 },
        new[] { 1, 1 },
        new[] { 1, -1 },
        new[] { -1, 1 },
        new[] { -1, -1 }
    };

    public King(string color, int x, int y) :
        base(color, x, y)
    {
    }
}