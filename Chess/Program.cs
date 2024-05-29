using System;

namespace Chess
{
    public class Program
    {
        // TODO: enum für die Farben
        public static void Main(string[] args)
        {
            Console.WriteLine("Do you want to be black or white?");
            var color = Console.ReadLine();
            var game = new Game();
        }
    }
}
