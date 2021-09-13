using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_Project
{
    public class WordMask
    {
        public string displayWord { get; set; }
        public static string DisplayedWord()
        {
            var NewWord = new WordGenerator();
            string newWord = NewWord.GetWord();
            char[] displayWord = new char[newWord.Length];

            for (int i = 0; i < newWord.Length; i++)
            {
                displayWord[i] = '_';
            }
            Console.WriteLine(displayWord.ToString());
            return displayWord.ToString();
        }
    }
}
