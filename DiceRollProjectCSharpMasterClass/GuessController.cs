using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollProjectCSharpMasterClass {
    internal class GuessController {

        private Dice _dice;
        private Guesses _guesses;

        public GuessController() {
            _dice = new Dice();
            _guesses = new Guesses();
        }

        public int DiceRoll() {
            return _dice.Roll();
        }

        public string PromptForGuess() {
            return _guesses.PromptForGuess();
        }
    }
}
