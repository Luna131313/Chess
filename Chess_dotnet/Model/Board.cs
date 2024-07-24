using Chess.Interfaces;

namespace Chess.Model;

public class Board : IBoard
{
    public ITile this[int x, int y] => TileArray[x, y];

    public ITile[,] TileArray { get; set; }

    public Board()
    {
        TileArray = new ITile[8, 8];
        for (var x = 0; x < 8; x++)
        {
            for (var y = 0; y < 8; y++)
            {
                TileArray[x, y] = new Tile(x, y);
            }
        }
    }
}