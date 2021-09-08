using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_Project
{
    public class PlayerResponse
    {
        
        
        

        char badGuess = ' ';

        

        public static void GetPlayerGuess()
        {
            var NewWord = new WordGenerator();
            string newWord = NewWord.GetWord();
        
            char playerGuess = Convert.ToChar(Console.ReadLine());        
            List<char> badGuessList = new List<char>();
            int guessesRemaining = 5;
            string maskedWord = newWord.Replace(newWord, "_");

            foreach (char character in newWord)
            {
                if (playerGuess == newWord[character])
                {
                    
                }
                else 
                {
                    guessesRemaining--;
                    if (guessesRemaining == 0)
                    {
                        badGuessList.Add(playerGuess);
                        Messages.DisplayCurrentGameState( , badGuessList, guessesRemaining);

                    }
                    else
                    {
                        badGuessList.Add(playerGuess);
                        Messages.DisplayCurrentGameState( , badGuessList, guessesRemaining);
                        Messages.GuessAgain();
                    }
                    
                }
            }
        }
    }
}
