using System;
using System.Collections.Generic;
using System.IO;

namespace Lab_4
{
    class Program
    {
        static int CountPunctuation(List<char> chars)
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
        }
        
        static int CountPunctuationMarks(List<char> characters)
        {
            int count = 0;
            char[] punctuationMarks = { '.', ',', ';', ':', '!', '?', '(', ')', '[', ']', '{', '}', '<', '>', '"'};

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

            byte select;
            do
            {
                Console.WriteLine("     ***");
                Console.WriteLine("1. First way of count punctuation marks");//Метод для вираховування певних знаків пунктуації
                Console.WriteLine("2. Second way of count punctuation marks");//Метод для вираховування всіх знаків пунктуації
                Console.WriteLine("0. To end the task");
                Console.WriteLine("     ***");
                select = Convert.ToByte(Console.ReadLine());
                Console.WriteLine();
                switch (select)
                {
                    case 1:
                        //Перевірка на існування такого файлу
                        try
                        {
                            string fileContent = File.ReadAllText(file);
                            char[] characters = fileContent.ToCharArray();//Масив символів
                            Console.WriteLine("Text from file: " + fileContent);

                            int punctuationCount = CountPunctuationMarks(characters);

                            Console.WriteLine("Number of punctuation marks:" + punctuationCount);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Error. This file " + file + " does not exist");
                        }
                        break;
                    case 2:
                        //Перевірка на існування такого файлу
                        try
                        {
                            string fileContent = File.ReadAllText(file);
                            List<char> characters = new List<char>(fileContent);//Список символів
                            Console.WriteLine("Text from file: " + fileContent);

                            int punctuationCount = CountPunctuation(characters);

                            Console.WriteLine("Number of punctuation marks:" + punctuationCount);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Error. This file " + file + " does not exist");
                        }
                        break;
                    
                    default:
                        break;
                }
            }
            while (select != 0);
            
            Console.WriteLine("The End of The Program.");
        }

    }
}
