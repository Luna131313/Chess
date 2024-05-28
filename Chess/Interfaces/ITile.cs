namespace Chess.Interfaces
{
    public interface ITile
    { 
        public bool IsOccupied { get; set; }
        public int X { get; }
        public int Y { get; }
    }
}
