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
            CreateBoard();
            InitializeChessmen(); // TODO: sollte die Methode lieber am Ende von CreateBoard() aufgerufen werden?
        }

        private void CreateBoard()
        {
            // TODO refactor
            InitializeKnights();
            InitializeRooks();
            InitializePawns();
        }

        private void InitializeKnights()
        {
            // add white rooks
            Board[1, 0].Owner = new Knight("White", 1, 0);
            Board[6, 0].Owner = new Knight("White", 6, 0);

            // add black rooks
            Board[1, 7].Owner = new Knight("Black", 1, 7);
            Board[6, 7].Owner = new Knight("Black", 6, 7);
        }

        private void InitializeRooks()
        {
            // add white rooks
            Board[0, 0].Owner = new Rook("White", 0, 0);
            Board[7, 0].Owner = new Rook("White", 7, 0);

            // add black rooks
            Board[0, 7].Owner = new Rook("Black", 0, 7);
            Board[7, 7].Owner = new Rook("Black", 7, 7);
        }

        private void InitializePawns()
        {
            // add white pawns
            for (var i = 0; i < 7; i++)
            {
                Board[i, 1].Owner = new Pawn("White", i, 1);
            }

            // add black pawns
            for (var i = 0; i < 7; i++)
            {
                Board[i, 6].Owner = new Pawn("Black", i, 6);
            }
        }

        private void InitializeChessmen()
        {
            for (var i = 0; i < 7; i++)
            {
                White.Chessmen.Add(Board[i, 0].Owner);
                White.Chessmen.Add(Board[i, 1].Owner);
                Black.Chessmen.Add(Board[i, 6].Owner);
                Black.Chessmen.Add(Board[i, 7].Owner);
            }
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
