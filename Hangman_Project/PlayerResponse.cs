using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_Project
{
    public class PlayerResponse
    {
        
        
        

        public int badGuess = 5;

        

        public static void GetPlayerGuess()
        {
            char playerGuess = Convert.ToChar(Console.ReadLine());
            string badGuessList = "";
            int guessesRemaining = 5;
            var NewWord = new WordGenerator();
            string newWord = NewWord.GetWord();

            foreach (char character in newWord)
            {
                if (playerGuess == newWord[character])
                {
                    WordMask.displayWord[character] = playerGuess;
                    if (WordMask.displayWord == newWord)
                    {
                        Messages.GameWon();
                    }
                }
                else
                {
                    guessesRemaining--;
                    if (guessesRemaining == 0)
                    {
                        badGuessList += playerGuess;
                        Messages.DisplayCurrentGameState(WordMask.displayWord, badGuessList, guessesRemaining);
                        Messages.GameLost();

                    }
                    else
                    {
                        badGuessList += playerGuess;
                        Messages.DisplayCurrentGameState(WordMask.displayWord, badGuessList, guessesRemaining);
                        Messages.GuessAgain();
                    }

                }
            }
        }
    }
}
