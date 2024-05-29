using Chess.Interfaces;

namespace Chess
{
    public class Board : IBoard
    {
        public Tile this[int x, int y] => TileArray[x, y];

        public Tile[,] TileArray { get; set; }

        public Board()
        {
            TileArray = new Tile[8, 8];
            for (var x = 0; x < 8; x++)
            {
                for (var y = 0; y < 8; y++)
                {
                    TileArray[x, y] = new Tile(x, y);
                }
            }
        }
    }
}