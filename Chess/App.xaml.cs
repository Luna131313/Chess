using System.Windows;
using Chess.Model;

namespace Chess
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        // TODO: enum für die Farben?
        // TODO: use point instead of X and Y?
        // TODO: Refactor chessmen classes
        // TODO: GameOver and Patt Property in Game class or in IPlayer?
        // TODO: Methoden zum Initialisieren des Schachbretts refactoren?
        // TODO: Eigentlich ist es doppelt die Farbe sowohl in Player als auch in Chessman zu speichern, weil die Figuren sowieso in der Chessmen Liste gespeichert sind.

        private static App _app;
        private static Game _game;
        //private static TitleScreenViewModel _titleScreenViewModel;
        //private static TitleScreen _titleScreen;
        //private static GameViewModel _gameViewModel;
        //private static GameView _gameView;
        //private static EndScreenViewModel _endScreenViewModel;
        //private static EndScreenView _endScreenView;

        [System.STAThreadAttribute()]
        public static void Main()
        {
            _app = new App();

            _app.Run();

            //_titleScreen = new TitleScreen
            //{
            //    DataContext = _titleScreenViewModel
            //};

            //_app.Run(_titleScreen);

            var game = new Game();
            game.StartGame();
        }
    }
}