using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a word:");
            string input = Console.ReadLine();

            if (IsPalindrome(input))
            {
                Console.WriteLine("It is a palindrome!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("It is NOT a palindrome!");
                Console.ReadLine();
            }
        }

        static bool IsPalindrome(string input)
        {
            for (int i = 0, j = input.Length - 1; i < j; i++, j--)
            {
                if (input[i] != input[j])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
