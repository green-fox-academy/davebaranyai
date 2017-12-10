using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which Fibonacci number would you want? Enter a number:");
            int Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The " + Number + "th Fibonacci number is: " + NthFibonacci(Number));
            Console.ReadLine();
        }
        static int NthFibonacci(int Number)
        {
            if (Number == 0)
            {
                return 0;
            }
            else if (Number <= 2)
            {
                return 1;
            }            
            return NthFibonacci(Number - 1) + NthFibonacci(Number - 2);            
        }
    }   
}