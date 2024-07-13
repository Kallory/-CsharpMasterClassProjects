namespace DiceRollProjectCSharpMasterClass {
    internal class Dice {
        private Random rnd;

        private int currentRoll;   // creates a number between 1 and 6
        public Dice() {
            rnd = new Random();
        }

        public int Roll() {
            currentRoll = rnd.Next(1, 7);
            return currentRoll;
        }
    }
}