using System;
using System.Collections.Generic;

namespace Hangman_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Messages.WelcomeMessage();
            Messages.PlayerGuess();
            PlayerResponse.GetPlayerGuess();
        }
    }
}
