using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_Project
{
    public class WordMask
    {
        public static string displayWord = "";
        public string BadGuesses = "";
        public int guessesRemaining = 5;

        public static string DisplayedWord()
        {
            var NewWord = new WordGenerator();
            string newWord = NewWord.GetWord();

            for (int i = 0; i < newWord.Length; i++)
            {
                displayWord += "*";
            }
            return displayWord;
        }
    }
}
