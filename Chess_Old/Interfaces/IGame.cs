namespace Chess.Interfaces
{
    public interface IGame
    {
        public IBoard Board { get; }

        public IPlayer Black { get; set; }
        public IPlayer White { get; set; }

        public bool GameOver { get; }

        public bool Patt { get; }
    }
}