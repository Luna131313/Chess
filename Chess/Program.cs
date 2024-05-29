namespace Chess
{
    public class Program
    {
        // TODO: enum für die Farben
        // TODO: use point instead of X and Y?
        // TODO: Refactor chessmen classes
        // TODO: Methoden zum Initialisieren des Schachbretts refactoren?
        public static void Main(string[] args)
        {
            var game = new Game();
            game.StartGame();
        }
    }
}
