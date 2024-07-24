namespace Chess.Interfaces;

public interface IBoard
{
    public ITile[,] TileArray { get; set; }

    public ITile this[int x, int y] { get; }
}