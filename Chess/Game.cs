using System;
using Chess.Interfaces;

namespace Chess
{
    public class Game : IGame
    {
        public bool GameOver
        {
            get
            {

            }
        }

        public bool Patt
        {
            get
            {

            }
        }

        public Player Black { get; set; }

        public Player White { get; set; }

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
                        Console.WriteLine($"{color} is an invalid color, you need to choose between black and white.");
                        continue;
                }
            } while (color is not ("black" or "Black" or "b" or "B" or "white" or "White" or "w" or "W"));

            return null;
        }
    }
}
