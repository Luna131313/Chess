using Chess.Interfaces;

namespace Chess
{
    public class Player : IPlayer
    {
        public string Color { get; set; }

        public Player(string color)
        {
            Color = color;
        }
    }
}
