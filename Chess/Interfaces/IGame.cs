namespace Chess.Interfaces
{
    public interface IGame
    {
        public bool GameOver { get; set; }
        public bool Patt { get; set; }
    }
}