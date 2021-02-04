// <copyright file="PigLatin.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PigLatinTranslator
{
    using System.Text;
    using System.Text.RegularExpressions;

    /// <summary>
    /// The class which is used to represent Pig Latin translations.
    /// </summary>
    public class PigLatin : ITranslate
    {
        /// <summary>
        /// Handles translating from English to Pig Latin.
        /// </summary>
        /// <param name="stringToTranslate">The input to translate.</param>
        /// <returns>Returns the input translated to pig latin.</returns>
        public StringBuilder Translate(StringBuilder stringToTranslate)
        {
            char firstLetter = stringToTranslate[0];

            // Handle words that begin with vowels differently.
            if (Regex.IsMatch(firstLetter.ToString(), "[aeiou]"))
            {
                stringToTranslate.Append("way");
            }
            else
            {
                stringToTranslate.Remove(0, 1);
                stringToTranslate.Append(firstLetter);
                stringToTranslate.Append("ay");
            }

            return stringToTranslate;
        }
    }
}
