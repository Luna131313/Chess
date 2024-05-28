namespace Chess.Chessmen
{
    public class Rook : Chessman
    {
        public override List<int[]> PossibleMoves { get; } = new()
        {
            new[]{ 1, 0 },
            new[]{ 2, 0 },
            new[]{ 3, 0 },
            new[]{ 4, 0 },
            new[]{ 5, 0 },
            new[]{ 6, 0 },
            new[]{ 7, 0 },
            new[]{ -1, 0 },
            new[]{ -2, 0 },
            new[]{ -3, 0 },
            new[]{ -4, 0 },
            new[]{ -5, 0 },
            new[]{ -6, 0 },
            new[]{ -7, 0 },
            new[]{ 0, 1 },
            new[]{ 0, 2 },
            new[]{ 0, 3 },
            new[]{ 0, 4 },
            new[]{ 0, 5 },
            new[]{ 0, 6 },
            new[]{ 0, 7 },
            new[]{ 0, -1 },
            new[]{ 0, -2 },
            new[]{ 0, -3 },
            new[]{ 0, -4 },
            new[]{ 0, -5 },
            new[]{ 0, -6 },
            new[]{ 0, -7 }
        };
    }
}
