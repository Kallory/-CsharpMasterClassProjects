using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollProjectCSharpMasterClass {
    internal class Guesses {

        private string _promptForGuesses;

        public Guesses() {
            _promptForGuesses = "Please enter a guess for the dice roll, 1-6";
        }

        public string PromptForGuess() {
            return _promptForGuesses;
        }
    }
}
