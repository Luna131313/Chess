using System.Collections.Generic;
using Chess.Chessmen;
using Chess.Interfaces;

namespace Chess
{
    public class AiPlayer : IPlayer
    {
        public string Color { get; set; }
        public Chessman King { get; set; }
        public List<Chessman> Chessmen { get; set; }
    }
}
