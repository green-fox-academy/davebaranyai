using System;
using System.Text;

namespace practicex
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "anagramanagram";
            var reBuiltString = new StringBuilder(input);

            foreach (char uniqueChar in input)
            {
                reBuiltString.Replace(uniqueChar.ToString(), string.Empty)
                             .Append(uniqueChar.ToString());
            }

            Console.WriteLine(reBuiltString);
            Console.ReadLine();
        }
    }
}
