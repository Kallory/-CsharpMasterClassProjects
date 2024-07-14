namespace DiceRollProjectCSharpMasterClass {
    internal class Dice {
        private readonly Random rnd;
        private const int MIN_NUMBER = 1;
        private const int MAX_NUMBER = 7;

        private int currentRoll;   // creates a number between 1 and 6
        public Dice() {
            rnd = new Random();
        }

        public int Roll() {
            currentRoll = rnd.Next(MIN_NUMBER, MAX_NUMBER);
            return currentRoll;
        }
    }
}