using System;
using System.Collections.Generic;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "anagram";
            Console.WriteLine(Extract(original));
            Console.ReadLine();
        }
        static string Extract(string original)
        {
            List<char> characters = new List<char>();
            string unique = string.Empty;
            foreach (char letter in original.ToCharArray())
            {
                if (!characters.Contains(letter))
                {
                    characters.Remove(letter);
                }
            }
            foreach (char letter in characters)
            {
                unique += letter;
            }
            return unique;
        }
    }
}
