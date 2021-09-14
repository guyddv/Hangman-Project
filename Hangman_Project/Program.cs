using System;
using System.Collections.Generic;

namespace Hangman_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            string badGuessList = "";
            Messages.WelcomeMessage();
            Messages.PlayerGuess();
            Console.WriteLine(WordMask.DisplayedWord());
            
            Messages.DisplayCurrentGameState(WordMask.displayWord, badGuessList, 5);
            PlayerResponse.GetPlayerGuess();
            //while (guessesRemaining != 0)
            //{
                
            //}
            //PlayerResponse.GetPlayerGuess();
            




        }
    }
}
