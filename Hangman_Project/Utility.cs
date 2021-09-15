using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_Project
{
    public static class Utility
    {
        public static bool IsGuessInWord(char guess, string answer)
        {
            foreach (char letter in answer)
            {
                if (letter == guess)
                {
                    return true;
                }
            }

            return false;
        }

        public static string ReplaceMask(string maskWord, string newWord, char guess)
        {
            var newString = new StringBuilder(maskWord);
            for (int i = 0; i < newWord.Length; i++)
            {
                if (guess == newWord[i])
                {
                    newString[i] = guess;
                }
            }
            return newString.ToString();
        }
    }
}
