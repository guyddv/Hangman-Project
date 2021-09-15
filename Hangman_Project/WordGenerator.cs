﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_Project
{
    public class WordGenerator
    {
        public List<string> Words = new List<string>()
        {
            "instantiate",
            "polymorphism",
            "encapsulate",
            "constructor",
            "inheritance",
            "algorithm",
            "overload",
            "argument",
            "concantenation",
            "variable",
        };

        public string GetWord()
        {
            Random random = new Random();
            int randomIndex = random.Next(0, Words.Count);
            return Words[randomIndex];
        }
    }
}


