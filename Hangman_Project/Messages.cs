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
            Console.WriteLine("\nGuess another letter: ");
        }

        public static void DisplayCurrentGameState(string Progress, string BadGuesses, int GuessesRemaining)
        {
            Console.WriteLine($"\nMystery Word: {Progress}    Wrong Guesses: {BadGuesses}");
            Console.WriteLine($"Guesses Remaining: {GuessesRemaining}.");
        }

        public static void GameLost()
        {
            Console.WriteLine("\nNo more guesses, you lose!");
        }

        public static void GameWon()
        {
            Console.WriteLine("\nYou guessed the mystery word!");
        }
    }       
}
