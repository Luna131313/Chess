namespace Chess.Chessmen
{
    public abstract class Chessman
    {
        public bool IsDead { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public abstract List<int[]> PossibleMoves { get; }
        public bool MoveIsValid(int x, int y)
        {
            if (X + x < 0 || x + X > 7 || y + Y < 0 || y + Y > 7)
            {
                return false;
            }

            return PossibleMoves.Any(move => X + x == move[0] && Y + y == move[1]);
        }
        public void Move(int x, int y)
        {
            if (!MoveIsValid(x, y))
            {
                Console.WriteLine("Move is not valid");
            }
            else
            {
                X = x;
                Y = y;
                Console.WriteLine($"Moved chessman to position {x}, {y}");
            }
        }
    }
}