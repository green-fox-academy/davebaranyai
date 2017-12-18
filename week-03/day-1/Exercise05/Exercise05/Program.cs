using System;
using System.IO;

namespace Exercise05
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"./TextFile1.txt";
            UserInput(path);
        }

        static void UserInput(string path)
        {
            Console.WriteLine("What is the word?");
            string word = Console.ReadLine();
            Console.WriteLine("How many lines?");
            int number = Convert.ToInt32(Console.ReadLine());
            FileWriter(path, word, number);
        }

        static void FileWriter(string path, string word, int number)
        {
            try
            {
                string[] allStrings = new string[number];
                for (int i = 0; i < (number); i++)
                {
                    allStrings[i] = word;
                }
                File.WriteAllLines(path, allStrings);
                Console.WriteLine("File updated!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);                
            }
            Console.ReadLine();
        }
    }
}
