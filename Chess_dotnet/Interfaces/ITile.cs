namespace Chess.Interfaces;

public interface ITile
{
    public Chessman Owner { get; set; }
    public bool IsOccupied { get; set; }
    public int X { get; }
    public int Y { get; }
}