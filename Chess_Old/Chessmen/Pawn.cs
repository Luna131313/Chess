using System.Collections.Generic;
using Chess.Interfaces;

namespace Chess.Chessmen
{
    // TODO en passant
    public class Pawn : Chessman
    {
        private readonly List<int[]> _possibleMoves;

        public override List<int[]> PossibleMoves
        {
            get
            {
                return Y == 1 ? new List<int[]>(_possibleMoves) { new[] { 2, 0 } } : _possibleMoves;
            }
        }

        public Pawn(string color, int x, int y) : base(color, x, y)
        {
            _possibleMoves = new List<int[]> { new[] { 1,0 } };
        }
    }
}
