namespace DiceRollProjectCSharpMasterClass {
    internal class GameModel {
        private int _targetNumber;
        private const int _MAX_ATTEMPTS = 3;
        private const int _MIN_GUESS = 1;
        private const int _MAX_GUESS = 6;

        public int TargetNumber {
            get { return _targetNumber; }

            set { _targetNumber = value; }
        }

        private int _attemptsLeft;

        public int AttemptsLeft {
            get { return _attemptsLeft; }
            set { _attemptsLeft = value; }
        }

        public int MAX_ATTEMPTS {
            get { return _MAX_ATTEMPTS; }
        }

        public int MIN_GUESS {
            get { return _MIN_GUESS; }
        }

        public int MAX_GUESS {
            get { return _MAX_GUESS;  }
        }

        public GameModel() {
            
        }

        public void InitializeGame() {
            this.AttemptsLeft = MAX_ATTEMPTS;
        }

        public bool IsCorrectGuess(int guess) {
            return guess == this.TargetNumber;
        }

        public bool IsValidGuess(int guess) {
            return (guess >= MIN_GUESS && guess <= MAX_GUESS);
        }

        public bool IsGameOver() {
            return this.AttemptsLeft == 0;
        }
    }
}