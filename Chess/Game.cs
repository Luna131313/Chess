using System;
using Chess.Interfaces;

namespace Chess
{
    public class Game : IGame
    {
        public Player Black { get; set; }

        public Player White { get; set; }

        public bool GameOver
        {
            get
            {
                // TODO
                return false;
            }
        }

        public bool Patt
        {
            get
            {
                // TODO
                return false;
            }
        }

        public Game()
        {
            var player = ReadDesiredColor();
        }

        public static string ReadDesiredColor()
        {
            string color;
            do
            {
                Console.WriteLine("Do you want to be black or white?");
                color = Console.ReadLine();
                switch (color)
                {
                    case "black" or "Black" or "b" or "B":
                        return "Black";
                    case "white" or "White" or "w" or "W":
                        return "White";
                    default:
                        Console.WriteLine($"\"{color}\" is an invalid color, you need to choose between black and white.");
                        continue;
                }
            } while (color is not ("black" or "Black" or "b" or "B" or "white" or "White" or "w" or "W"));

            return null;
        }
    }
}
