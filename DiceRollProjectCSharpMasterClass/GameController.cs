
namespace DiceRollProjectCSharpMasterClass {
    internal class GameController {
        GameModel gameModel;
        Dice gameDice;
        GameView view;
        internal void Start() {
            this.gameModel = new GameModel();
            this.gameDice = new Dice();
            this.view = new GameView();

            view.DisplayWelcomeMessage();
            int rolledNumber = gameDice.Roll();
            string toExit = Console.ReadLine();

            while (!(string.Equals(toExit, "e"))) {
                rolledNumber = gameDice.Roll();
                Console.WriteLine("DEBUGGING: ROLLED NUMBER: " + rolledNumber);
                toExit = Console.ReadLine();
            }

            Console.ReadLine();

        }
    }
}