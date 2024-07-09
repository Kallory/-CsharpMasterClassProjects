namespace DiceRollProjectCSharpMasterClass {
    public class Guesser {
        private Dice _dice;

        public Guesser() {
            _dice = new Dice();
        }

        public int DiceRoll() {
            return _dice.Roll();
        }
    }
}