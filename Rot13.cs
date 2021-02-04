// <copyright file="Rot13.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PigLatinTranslator
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;

    /// <summary>
    /// The class which is used to represent the ROT13 cypher.
    /// </summary>
    public class Rot13 : ITranslate
    {
        /// <summary>
        /// Handles the process of converting the string.
        /// </summary>
        /// <param name="input">The user input that should be converted.</param>
        /// <returns>Returns a string in ROT13.</returns>
        public static StringBuilder Cypher(string input)
        {
            StringBuilder result = new StringBuilder();
            Regex regex = new Regex("[A-Za-z]");

            foreach (char c in input)
            {
                if (regex.IsMatch(c.ToString()))
                {
                    int charCode = (((c & 223) - 52) % 26) + (c & 32) + 65;
                    result.Append((char)charCode);
                }
                else
                {
                    result.Append(c);
                }
            }

            return result;
        }

        /// <summary>
        /// Handles the translation of the input to ROT13.
        /// </summary>
        /// <param name="stringToTranslate">The input to be converted.</param>
        /// <returns>Returns a string converted to ROT13.</returns>
        public StringBuilder Translate(StringBuilder stringToTranslate)
        {
            stringToTranslate = Cypher(stringToTranslate.ToString());
            return stringToTranslate;
        }
    }
}
