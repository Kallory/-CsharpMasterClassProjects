
namespace DiceRollProjectCSharpMasterClass {
    internal class GameView {
        internal void DisplayWelcomeMessage() {
            Console.WriteLine("Dice Rolled. Guess what number it shows in 3 tries or less.");
        }

        internal void DisplayPromptForGuess() {
            Console.WriteLine("Please guess a number between 1 and 6");
        }

        internal void DisplayNotANumberMsg() {
            Console.WriteLine("Not a number, sorry");
        }

        internal void DisplayWinMessage() {
            Console.WriteLine("Congrats you won!");
        }
        
        internal void DisplayLoseMessage() {
            Console.WriteLine("Out of attempts to guess, you lost :(");
        }

        internal void DisplayGuessNotInRangeMsg(int min, int max) {
            Console.WriteLine("Please enter a number between " + min + " and " + max);
        }

        internal void DisplayWrongNumberMsg(int attemptsRemaining) {
            Console.WriteLine("Wrong number, try again");
            Console.WriteLine(attemptsRemaining + " attempts remaining");
        }
    }
}