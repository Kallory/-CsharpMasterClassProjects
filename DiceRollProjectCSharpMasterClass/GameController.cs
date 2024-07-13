
namespace DiceRollProjectCSharpMasterClass {
    internal class GameController {
        GameModel gameModel;
        Dice gameDice;
        GameView view;
        int numberGuessed;
        internal void Start() {
            this.gameModel = new GameModel();
            this.gameDice = new Dice();
            this.view = new GameView();

            gameModel.InitializeGame();
            view.DisplayWelcomeMessage();

            gameModel.TargetNumber = gameDice.Roll();
            Console.WriteLine("DEBUGGING: ROLLED NUMBER: " + gameModel.TargetNumber);


            while (!gameModel.IsGameOver()) {

                view.DisplayPromptForGuess();
                bool isNumber = int.TryParse(Console.ReadLine(), out int result);

                CheckIsNumber(ref isNumber, ref result);

                while (!gameModel.IsValidGuess(numberGuessed)) {
                    view.DisplayGuessNotInRangeMsg(gameModel.MIN_GUESS, gameModel.MAX_GUESS);
                    isNumber = int.TryParse(Console.ReadLine(), out result);
                    CheckIsNumber(ref isNumber, ref result);
                }

                if (!gameModel.IsCorrectGuess(numberGuessed)) {
                    gameModel.AttemptsLeft--;
                    view.DisplayWrongNumberMsg(gameModel.AttemptsLeft);
                } else {
                    view.DisplayWinMessage();
                    Console.ReadLine();
                    Environment.Exit(0);
                }
            }

            //string toExit = Console.ReadLine();


            //while (!(string.Equals(toExit, "e"))) {
            //    rolledNumber = gameDice.Roll();
            //    
            //    toExit = Console.ReadLine();
            //}

            view.DisplayLoseMessage();
            Console.ReadLine();

        }

        private void CheckIsNumber(ref bool isNumber, ref int result) {
            while (!isNumber) {
                view.DisplayNotANumberMsg();
                isNumber = int.TryParse(Console.ReadLine(), out result);
            }

            if (isNumber) {
                numberGuessed = result;
            }
        }


    }
}