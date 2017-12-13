using System;

namespace Exercise26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First number: ");
            int Number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second number: ");
            int Number2 = Convert.ToInt32(Console.ReadLine());
            Comparing(Number1, Number2);
            // Create a program that asks for two numbers
            // If the second number is not bigger than the first one it should print:
            // "The second number should be bigger"
            //
            // If it is bigger it should count from the first number to the second by one
            //
            // example:
            //
            // first number: 3, second number: 6, should print:
            //
            // 3
            // 4
            // 5
        }
        static void Comparing(int Number1, int Number2)
        {

        }
        static void Counting(int Number1, int Number2)
        {

        }
    }
}
