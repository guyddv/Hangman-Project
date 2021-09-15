using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_Project
{
    public class PlayerResponse
    {
        

        public static void GetPlayerGuess()
        {
            var NewWord = new WordGenerator();
            string newWord = NewWord.GetWord();
            var MaskedWord = new WordMask();
            string maskWord = MaskedWord.DisplayedWord(newWord);
            int guessesRemaining = 5;
            string badGuessList = "";
            bool won = false;

            while (guessesRemaining != 0 || won == false)
            {
                char playerGuess = Convert.ToChar(Console.ReadLine());
                var isCorrect = Utility.IsGuessInWord(playerGuess, newWord);
                
                if (isCorrect)
                {
                    maskWord = Utility.ReplaceMask(maskWord, newWord, playerGuess);
                    Messages.DisplayCurrentGameState(maskWord, badGuessList, guessesRemaining);
                    if (maskWord == newWord)
                    {
                        won = true;
                        Messages.GameWon();
                    }
                    else
                    {
                        Messages.GuessAgain();
                    }
                }
                else
                {
                    guessesRemaining--;
                    if (guessesRemaining == 0)
                    {
                        badGuessList += playerGuess;
                        Messages.DisplayCurrentGameState(maskWord, badGuessList, guessesRemaining);
                        Messages.GameLost();
                    }
                    else
                    {
                        badGuessList += playerGuess;
                        Messages.DisplayCurrentGameState(maskWord, badGuessList, guessesRemaining);
                        Messages.GuessAgain();
                    }
                }
            }
        }
    }
}