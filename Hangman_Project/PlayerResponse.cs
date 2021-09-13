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
            List<char> badGuessList = new List<char>();
            int guessesRemaining = 5;
            //string displayedWord = new WordMask.DisplayedWord();
            //string maskedWord = DisplayedWord();

            //foreach (char character in newWord)
            //{
            //    if (playerGuess == newWord[character])
            //    {
                    
            //    }
            //    else 
            //    {
            //        guessesRemaining--;
            //        if (guessesRemaining == 0)
            //        {
            //            badGuessList.Add(playerGuess);
            //            Messages.DisplayCurrentGameState( , badGuessList, guessesRemaining);

            //        }
            //        else
            //        {
            //            badGuessList.Add(playerGuess);
            //            Messages.DisplayCurrentGameState( , badGuessList, guessesRemaining);
            //            Messages.GuessAgain();
            //        }
                    
            //    }
            //}
        }
    }
}
