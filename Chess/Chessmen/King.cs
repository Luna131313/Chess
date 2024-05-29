using System.Collections.Generic;

namespace Chess.Chessmen
{
    public class King : Chessman
    {
        public override List<int[]> PossibleMoves { get; } = new()
        {
            new[]{ 1, 0 },
            new[]{ -1, 0 },
            new[]{ 0, 1 },
            new[]{ 0, -1 },
            new[]{ 1, 1 },
            new[]{ 1, -1 },
            new[]{ -1, 1 },
            new[]{ -1, -1 }
        };

        public King(string color, int x, int y) : base(color, x, y)
        {
        }
    }
}
