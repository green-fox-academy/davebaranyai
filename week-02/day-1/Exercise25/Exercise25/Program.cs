using System;

namespace Exercise25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your number: ");
            int UserInput = Convert.ToInt32(Console.ReadLine());

            Multiplication(UserInput);
            Console.ReadLine();
        }
        static void Multiplication(int UserInput)
        {
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i + " * " + UserInput + " = " + (i * UserInput));
            }
        }
    }
}
