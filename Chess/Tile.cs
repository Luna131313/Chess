using Chess.Chessmen;
using Chess.Interfaces;

namespace Chess
{
    public class Tile : ITile
    {
        public Chessman Owner { get; set; }

        public bool IsOccupied { get; set; }

        public int X { get; }

        public int Y { get; }

        public Tile(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void PlaceChessman()
        {
            IsOccupied = true;
        }

        public void RemoveChessman()
        {
            IsOccupied = false;
        }
    }
}
