using Chess.Interfaces;

namespace Chess.Chessmen
{
    public class Knight : Chessman
    {
        public override List<int[]> PossibleMoves { get; } = new()
        {
            new[]{ 1, 2 },
            new[]{ 1, -2 },
            new[]{ -1, 2 },
            new[]{ -1, -2 },
            new[]{ 2, 1 },
            new[]{ 2, -1 },
            new[]{ -2, 1 },
            new[]{ -2, -1 }
        };

        public Knight(IPlayer owner) : base()
        {
        }
    }
}
