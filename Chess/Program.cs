namespace Chess
{
    public class Program
    {
        // TODO: enum für die Farben?
        // TODO: use point instead of X and Y?
        // TODO: Refactor chessmen classes
        // TODO: GameOver and Patt Property in Game class or in IPlayer?
        // TODO: Methoden zum Initialisieren des Schachbretts refactoren?
        // TODO: Eigentlich ist es doppelt die Farbe sowohl in Player als auch in Chessman zu speichern, weil die Figuren sowieso in der Chessmen Liste gespeichert sind.
        public static void Main(string[] args)
        {
            var game = new Game();
            game.StartGame();
        }
    }
}
