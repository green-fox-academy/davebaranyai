using System;
using System.Collections.Generic;


namespace UniqueChars
{
    public class UniqueChars
    {
        public static void Main(string[] args)
        {
            string inputString = "testing";
            // Create a method called `UniqueCharacters` that takes a string as parameter
            // and returns a list with the unique letters of the given string
            // Create basic unit tests for it with at least 3 different test cases
            // Print the characters from that list in the following format:
            // "n", "g", "r", "m"
        }
        public List<char> UniqueCharacters(string inputString)        
        {
            char[] charArray = inputString.ToCharArray();            

            List<char> charList = new List<char>();

            foreach (char character in charArray)
            {
                charList.Add(character);
            }            

            return charList;
        }
    }
}
