// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PigLatinTranslator
{
    using System;

    /// <summary>
    /// The class which is used to represent the Console Application.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The method which contains the logic used within the Console app.
        /// </summary>
        /// <param name="args">The console arguments.</param>
        public static void Main(string[] args)
        {
            Console.Title = "Pig Translator 1.0";
            Console.WriteLine("Translate English to Pig-Latin!");
            string command;
            bool exit = false;

            try
            {
                while (!exit)
                {
                    Console.WriteLine("Would you like to translate to English or Pig Latin? (Type 'help' for options)");
                    Console.Write("> ");
                    command = Console.ReadLine();
                    command = command.ToLower().Trim();
                    string[] commandWords = command.Split();
                    switch (commandWords[0])
                    {
                        case "pig":
                            ConsoleHelper.UserPrompt();
                            PigLatin pl = new PigLatin();
                            Console.WriteLine($"Translated Word: " + " " + pl.Translate(ConsoleHelper.ProcessString()));
                            break;

                        case "english":
                            ConsoleHelper.UserPrompt();
                            English e = new English();
                            Console.WriteLine($"Translated Word: " + " " + e.Translate(ConsoleHelper.ProcessString()));
                            break;

                        case "exit":
                            exit = true;
                            break;

                        case "clear":
                            Console.Clear();
                            break;

                        case "help":
                            Console.WriteLine("You can type 'Pig Latin', 'English', 'Exit' (To exit the program), or 'Clear' to clear the console.");
                            break;

                        default:
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
