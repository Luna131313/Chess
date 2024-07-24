using System;
using System.Collections.Generic;
using System.Linq;

namespace Chess.Interfaces;

public abstract class Chessman
{
    public int X { get; set; }

    public int Y { get; set; }

    public bool IsDead { get; set; }

    public string Color { get; set; }

    public abstract List<int[]> PossibleMoves { get; }

    protected Chessman(string color, int x, int y)
    {
        IsDead = false;
        Color = color;
        X = x;
        Y = y;
    }

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