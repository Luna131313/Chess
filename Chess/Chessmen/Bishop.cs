using System.Collections.Generic;

namespace Chess.Chessmen
{
    public class Bishop : Chessman
    {
        public override List<int[]> PossibleMoves { get; } = new()
        {
            new[]{ 1, 1 },
            new[]{ 2, 2 },
            new[]{ 3, 3 },
            new[]{ 4, 4 },
            new[]{ 5, 5 },
            new[]{ 6, 6 },
            new[]{ 7, 7 },
            new[]{ -1, -1 },
            new[]{ -2, -2 },
            new[]{ -3, -3 },
            new[]{ -4, -4 },
            new[]{ -5, -5 },
            new[]{ -6, -6 },
            new[]{ -7, -7 }
        };

        public Bishop(string color) : base(color)
        {
        }
    }
}
