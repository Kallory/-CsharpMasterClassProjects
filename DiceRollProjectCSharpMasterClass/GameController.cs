
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
            Console.WriteLine("DEBUGGING: ROLLED NUMBER: " + rolledNumber);

            Console.ReadLine();

        }
    }
}