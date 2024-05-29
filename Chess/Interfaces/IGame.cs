namespace Chess.Interfaces
{
    public interface IGame
    {
        public bool GameOver { get; }
        public bool Patt { get; }
    }
}