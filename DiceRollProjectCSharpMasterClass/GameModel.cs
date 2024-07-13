namespace DiceRollProjectCSharpMasterClass {
    internal class GameModel {
        private int _targetNumber;
        private const int _MAX_ATTEMPTS = 3;

        public int TargetNumber {
            get { return _targetNumber; }

            private set { _targetNumber = value; }
        }

        private int _attemptsLeft;

        public int AttemptsLeft {
            get { return _attemptsLeft; }
            private set { _attemptsLeft = value; }
        }

        public int MAX_ATTEMPTS {
            get { return _MAX_ATTEMPTS; }
        }

        public GameModel() {
            
        }

        public void InitializeGame() {
            this.AttemptsLeft = MAX_ATTEMPTS;
        }

        public bool CheckGuess(int guess) {
            return guess == this.TargetNumber;
        }

        public bool IsGameOver() {
            return this.AttemptsLeft == 0;
        }
    }
}