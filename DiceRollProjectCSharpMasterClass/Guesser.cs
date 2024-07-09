namespace DiceRollProjectCSharpMasterClass {
    public class Guesser {

        private GuessController guessController;

        public Guesser() {
            this.GuessController = new GuessController();
        }

        internal GuessController GuessController { get => guessController; set => guessController = value; }

        public void StartGame() {
            GuessController.DiceRoll();
            Console.WriteLine("Roll is: " + GuessController.DiceRoll());
            Console.WriteLine(GuessController.PromptForGuess());
            Console.ReadLine();
        }
    }
}