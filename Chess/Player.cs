using System.Collections.Generic;
using Chess.Chessmen;
using Chess.Interfaces;

namespace Chess
{
    public class Player : IPlayer
    {
        public string Color { get; set; }
        public Chessman King { get; set; }
        public List<Chessman> Chessmen { get; set; }

        public Player(string color)
        {
            Color = color;
            Chessmen = new List<Chessman>();
        }
    }
}
