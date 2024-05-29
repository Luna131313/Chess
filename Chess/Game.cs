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
            Board = new Board();
            CreateBoard();
            InitializeChessmen(); // TODO: sollte die Methode lieber am Ende von CreateBoard() aufgerufen werden?
        }

        public void StartGame()
        {

        }

        private void CreateBoard()
        {
            InitializeKings();
            InitializeQueens();
            InitializeKnights();
            InitializeRooks();
            InitializeBishops();
            InitializePawns();
        }

        private void InitializeKings()
        {
            // add white king
            Board[4, 0].Owner = new Queen("White", 3, 0);

            // add black king
            Board[4, 7].Owner = new Queen("Black", 3, 7);
        }

        private void InitializeQueens()
        {
            // add white queen
            Board[3, 0].Owner = new Queen("White", 3, 0);

            // add black queen
            Board[3, 7].Owner = new Queen("Black", 3, 7);
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

        private void InitializeBishops()
        {
            // add white queen
            Board[2, 0].Owner = new Bishop("White", 2, 0);
            Board[5, 0].Owner = new Bishop("White", 5, 0);

            // add black queen
            Board[2, 7].Owner = new Bishop("Black", 2, 7);
            Board[5, 7].Owner = new Bishop("Black", 5, 7);
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
                White.King = Board[4, 0].Owner;

                Black.Chessmen.Add(Board[i, 6].Owner);
                Black.Chessmen.Add(Board[i, 7].Owner);
                Black.King = Board[4, 0].Owner;
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
