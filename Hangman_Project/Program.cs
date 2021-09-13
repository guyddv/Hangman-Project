using System;

namespace Hangman_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Messages.WelcomeMessage();
            Messages.PlayerGuess();
            WordMask.DisplayedWord();
            //Messages.DisplayCurrentGameState(displayedWord, ' ', 5);
            //var NewWord = new WordGenerator();
            //string newWord = NewWord.GetWord();
            //var MaskedWord = new WordMask(newWord);
            //var NewWord = WordMask.DisplayedWord();
            //var NewWord = new WordGenerator();
            //string newWord = NewWord.GetWord();
            //Messages.DisplayCurrentGameState(NewWord,'0', 5);
            //Messages.PlayerGuess();

            //while (badGuesses != 0)
            //{

            //}
            
            //Messages.PlayerGuess();




        }
    }
}
