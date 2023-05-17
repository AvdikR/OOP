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
        static string OutputFileText(string form)
        {
            string plainText;
            plainText = form;
            return plainText;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Work of Vadym Rybchynchuk PP-21");
            Console.WriteLine("Variant 3");
            using StreamReader sr = new StreamReader("File1_Lab4.txt");
            string form = File.ReadAllText("File1_Lab4.txt");
            string form1 = File.ReadAllText("File2_Lab4.txt");
            Console.WriteLine(form);

            
            byte select;
            do
            {
                Console.WriteLine("     ***");
                Console.WriteLine("1. Task 1 ");
                Console.WriteLine("2. Task 2 ");
                Console.WriteLine("0. To end the task");
                Console.WriteLine("     ***");
                select = Convert.ToByte(Console.ReadLine());
                Console.WriteLine();
                switch (select)
                {
                    case 1:
                        Console.WriteLine("Count puctuation marks in text from file 'File1_Lab4.txt''");
                        List<char> textInFile1 = new List<char>(sr.ReadToEnd());
                        int punctuationCount1 = CountPunctuation(textInFile1);
                        Console.WriteLine("Number of punctuation marks: " + punctuationCount1);
                        break;
                    case 2:
                        Console.WriteLine();
                        string MainText = Console.ReadLine();
                        File.WriteAllText(form1, MainText);
                        List<char> textInFile2 = new List<char>(MainText);
                        int punctuationCount2 = CountPunctuation(textInFile2);
                        Console.WriteLine("Number of punctuation marks: " + punctuationCount2);
                        break;
                    
                    default:
                        break;
                }
            }
            while (select != 0);
            Console.WriteLine("The End of The Program!");
        }
    }
}
