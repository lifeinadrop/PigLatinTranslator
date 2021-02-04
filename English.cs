// <copyright file="English.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PigLatinTranslator
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;

    /// <summary>
    /// The class which is used to represent translations to English.
    /// </summary>
    public class English : ITranslate
    {
        /// <summary>
        /// Handles the translation of the user input to English.
        /// </summary>
        /// <param name="stringToTranslate">The string to be translated.</param>
        /// <returns>Returns a translated string.</returns>
        public StringBuilder Translate(StringBuilder stringToTranslate)
        {
            char firstLetter = stringToTranslate[0];
            int firstLetterIndex = stringToTranslate.Length - 3;
            int ayIndex = stringToTranslate.Length - 2;
            int wayIndex = stringToTranslate.Length - 3;
            char letter = stringToTranslate[firstLetterIndex];

            stringToTranslate.Insert(0, letter);
            stringToTranslate.Remove(ayIndex, 3);

            return stringToTranslate;
        }
    }
}
