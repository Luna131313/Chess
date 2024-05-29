namespace Chess.Interfaces
{
    public interface IBoard
    {
        public Tile[,] TileArray { get; set; }
        public Tile this[int x, int y] { get; }
    }
}
