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

            // TODO refactor
            // TODO am besten eine eigene Methode initialize Player wo ich dann die Figuren der oberen bzw. der unteren beiden Reihen zur Chessman liste des jeweiligen Spielers hinzufüge
            InitializeKnights(board);
            InitializeRooks(board);
            InitializePawns(board);

            return board;
        }

        private void InitializeKnights(Board board)
        {
            // add white rooks
            var knight1 = new Knight("White", 1, 0);
            White.Chessmen.Add(knight1);
            board[1, 0].Owner = knight1;

            var knight2 = new Knight("White", 6, 0);
            White.Chessmen.Add(knight2);
            board[6, 0].Owner = knight2;

            // add black rooks
            var knight3 = new Knight("Black", 1, 7);
            White.Chessmen.Add(knight3);
            board[1, 7].Owner = knight3;

            var knight4 = new Knight("Black", 6, 7);
            White.Chessmen.Add(knight4);
            board[6, 7].Owner = knight4;
        }
        private void InitializeRooks(Board board)
        {
            // add white rooks
            var rook1 = new Rook("White", 0, 0);
            White.Chessmen.Add(rook1);
            board[0, 0].Owner = rook1;

            var rook2 = new Rook("White", 7, 0);
            White.Chessmen.Add(rook2);
            board[7, 0].Owner = rook2;

            // add black rooks
            var rook3 = new Rook("Black", 0, 7);
            White.Chessmen.Add(rook3);
            board[0, 7].Owner = rook3;

            var rook4 = new Rook("Black", 7, 7);
            White.Chessmen.Add(rook4);
            board[7, 7].Owner = rook4;
        }

        private void InitializePawns(Board board)
        {
            // add white pawns
            for (var i = 0; i < 7; i++)
            {
                var pawn = new Pawn("White", i, 1);
                White.Chessmen.Add(pawn);
                board[i, 1].Owner = pawn;
            }

            // add black pawns
            for (var i = 0; i < 7; i++)
            {
                var pawn = new Pawn("Black", i, 6);
                Black.Chessmen.Add(pawn);
                board[i, 6].Owner = pawn;
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
