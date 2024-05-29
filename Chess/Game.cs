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
            Board = CreateBoard();
            InitializeChessmen(); // TODO: sollte die Methode lieber am Ende von CreateBoard() aufgerufen werden?
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

        private Board CreateBoard()
        {
            // TODO: kann die Methode nicht auch void sein und direkt die Property setzen?
            var board = new Board();

            // TODO refactor
            // TODO am besten eine eigene Methode initialize Player
            // in der ich dann die Figuren der oberen bzw. der unteren beiden Reihen
            // zur Chessman Liste des jeweiligen Spielers hinzufüge
            InitializeKnights(board);
            InitializeRooks(board);
            InitializePawns(board);

            return board;
        }

        private void InitializeKnights(Board board)
        {
            // add white rooks
            board[1, 0].Owner = new Knight("White", 1, 0);
            board[6, 0].Owner = new Knight("White", 6, 0);

            // add black rooks
            board[1, 7].Owner = new Knight("Black", 1, 7);
            board[6, 7].Owner = new Knight("Black", 6, 7);
        }
        private void InitializeRooks(Board board)
        {
            // add white rooks
            board[0, 0].Owner = new Rook("White", 0, 0);
            board[7, 0].Owner = new Rook("White", 7, 0);

            // add black rooks
            board[0, 7].Owner = new Rook("Black", 0, 7);
            board[7, 7].Owner = new Rook("Black", 7, 7);
        }

        private void InitializePawns(Board board)
        {
            // add white pawns
            for (var i = 0; i < 7; i++)
            {
                board[i, 1].Owner = new Pawn("White", i, 1);
            }

            // add black pawns
            for (var i = 0; i < 7; i++)
            {
                board[i, 6].Owner = new Pawn("Black", i, 6);
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
