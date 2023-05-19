using System;
using System.Collections.Generic;
using System.IO;

namespace Lab_4
{
    class Program
    {
        /*static int CountPunctuation(List<char> chars)
        {
            int count = 0;

            foreach (char c in chars)
            {
                if (char.IsPunctuation(c))
                {
                    count++;
                }
            }

            return count;
        }*/
        
        static int CountPunctuationMarks(List<char> characters)
        {
            int count = 0;
            char[] punctuationMarks = { '.', ',', ';', ':', '!', '?', '(', ')', '[', ']', '{', '}', '<', '>', '"', '\'', '/', '\\', '@', '#', '$', '%', '&', '*', '_', '`', '~', '^' };

            foreach (char character in characters)
            {
                if (IsPunctuationMark(character, punctuationMarks))
                {
                    count++;
                }
            }

            return count;
        }

        static bool IsPunctuationMark(char character, char[] punctuationMarks)
        {
            // Перевірка, чи символ є знаком пунктуації
            if (Array.IndexOf(punctuationMarks, character) >= 0 && !IsSpecialCharacter(character))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool IsSpecialCharacter(char character)
        {
            // Перевірка, чи символ є спеціальним(+, - і так далі)
            if (character == '+' || character == '-' || character == '"' || character == '№')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Work of Vadym Rybchynchuk PP-21");
            string file = "File1_Lab4.txt";

            try
            {
                string fileContent = File.ReadAllText(file);
                List<char> characters = new List<char>(fileContent);
                Console.WriteLine("Text from file: " + fileContent);

                int punctuationCount = CountPunctuationMarks(characters);

                Console.WriteLine("Number of punctuation marks:" + punctuationCount);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error. This file" + file + " does not exist");
            }
        }

    }
}
