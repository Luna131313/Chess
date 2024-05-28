using Chess.Interfaces;

namespace Chess
{
    public class Game : IGame
    {
        public bool GameOver { get; set; }

        public List<Player> PlayerList = new();

        public Game()
        {
            var player = InitializePlayer();
            PlayerList.Add(player);
        }

        public Player InitializePlayer()
        {
            string? color;
            do
            {
                Console.WriteLine("Do you want to be black or white?");
                color = Console.ReadLine();
                switch (color)
                {
                    case "black" or "Black" or "b" or "B":
                        return new Player("Black");
                    case "white" or "White" or "w" or "W":
                        return new Player("White");
                    default:
                        Console.WriteLine($"{color} is an invalid color, you need to choose between black and white.");
                        continue;
                }
            } while (color is not ("black" or "Black" or "b" or "B" or "white" or "White" or "w" or "W"));

            return null;
        }
    }
}
