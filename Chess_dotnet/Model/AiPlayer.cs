using Chess.Interfaces;

namespace Chess.Model;

public class AiPlayer : IPlayer
{
    public string Color { get; set; }
    public Chessman King { get; set; }
    public List<Chessman> Chessmen { get; set; }

    public AiPlayer(string color, Chessman king, List<Chessman> chessmen)
    {
        Color = color;
        King = king;
        Chessmen = chessmen;
    }
}