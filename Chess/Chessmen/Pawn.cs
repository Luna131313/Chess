using Chess.Interfaces;

namespace Chess.Chessmen
{
    public class Pawn : Chessman
    {
        // TODO en passant
        private readonly List<int[]> _possibleMoves = new()
        {
            new[] { 1,0 }
        };

        public override List<int[]> PossibleMoves
        {
            get
            {
                return Y == 1 ? new List<int[]>(_possibleMoves) { new[] { 2, 0 } } : _possibleMoves;
            }
        }

        public Pawn(IPlayer owner) : base(owner)
        {
        }
    }
}
