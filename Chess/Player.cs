using System.Collections.Generic;
using Chess.Chessmen;
using Chess.Interfaces;

namespace Chess
{
    public class Player : IPlayer
    {
        public string Color { get; set; }
        public List<Chessman> Chessmen { get; set; }

        public Player(string color, List<Chessman> chessmen)
        {
            Color = color;
            Chessmen = chessmen;
        }
    }
}
