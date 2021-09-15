using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_Project
{
    public class WordMask
    {
        public static string displayWord { get; set; }

        public string DisplayedWord(string MyWord)
        {
            for (int i = 0; i < MyWord.Length; i++)
            {
                displayWord += "*";
            }

            return displayWord;
        }
    }
}


