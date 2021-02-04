// <copyright file="ConsoleHelper.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PigLatinTranslator
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// The class which represents methods used within the console.
    /// </summary>
    public static class ConsoleHelper
    {
        /// <summary>
        /// Console prompt for user input.
        /// </summary>
        public static void UserPrompt()
        {
            Console.WriteLine("What is the word you would like to translate?");
            Console.Write("> ");
        }

        /// <summary>
        /// Processes the string input by the user.
        /// </summary>
        /// <returns>Returns a StringBuilder object for use in the Translate method in Program.Main().</returns>
        public static StringBuilder ProcessString()
        {
            English e = new English();
            string wordToTranslate = Console.ReadLine();
            StringBuilder sb = new StringBuilder(wordToTranslate);
            Console.WriteLine("ROT13 Equivalent: " + Rot13.Cypher(wordToTranslate));
            return sb;
        }
    }
}
