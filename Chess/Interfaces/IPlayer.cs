using Chess.Chessmen;
using System.Collections.Generic;

namespace Chess.Interfaces
{
    public interface IPlayer
    {
        public string Color { get; set; }

        public Chessman King { get; set; }

        public List<Chessman> Chessmen { get; set; }
    }
}
