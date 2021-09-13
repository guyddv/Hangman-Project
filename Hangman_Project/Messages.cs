using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_Project
{
    public class Messages
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine(@"Welcome to Hangman.  The rules are simple: 
You guess one letter at a time. If you guess 
a correct letter, it will appear on screen. If 
you guess wrong, you die (just kidding).  You 
get 5 wrong guesses before the game ends.
Good luck!");
        }

        public static void PlayerGuess()
        {
            Console.WriteLine("\nPick a letter, any letter: ");
        }

        public static void GuessAgain()
        {
            Console.WriteLine("Guess another letter: ");
        }

        public static void DisplayCurrentGameState(List<char> Progress, List<char> BadGuesses, int GuessesRemaining)
        {
            Console.WriteLine($"Mystery Word: {Progress}    Wrong Guesses: {BadGuesses}");
            Console.WriteLine($"Guesses Remaining: {GuessesRemaining}.");
        }
    }       //  'Instantiate'   '_n____n_____'
}
