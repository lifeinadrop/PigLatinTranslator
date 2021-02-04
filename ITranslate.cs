// <copyright file="ITranslate.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PigLatinTranslator
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Text;

    /// <summary>
    /// Interface which handles translation.
    /// </summary>
    public interface ITranslate
    {
        /// <summary>
        /// Handles the translation of a string to Pig Latin, English, or a ROT13 cypher.
        /// </summary>
        /// <param name="stringToTranslate">The string to be translated.</param>
        /// <returns>A translated string.</returns>
        StringBuilder Translate(StringBuilder stringToTranslate);
    }
}
