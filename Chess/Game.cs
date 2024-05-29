using System;
using Chess.Chessmen;
using Chess.Interfaces;

namespace Chess
{
    public class Game : IGame
    {
        public IBoard Board { get; }

        public IPlayer Black { get; set; }

        public IPlayer White { get; set; }

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
            var board = CreateBoard();

        }

        private Board CreateBoard()
        {
            var board = new Board();
            // add white chessmen
            for (var i = 0; i < 7; i++)
            {
                var pawn = new Pawn("White", i, 1);
                White.Chessmen.Add(pawn);
                board[i, 1].Owner = pawn;
            }

            // add black chessmen
            for (var i = 0; i < 7; i++)
            {
                var pawn = new Pawn("Black", i, 6);
                Black.Chessmen.Add(pawn);
                board[i, 6].Owner = pawn;
            }
            return board;
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
