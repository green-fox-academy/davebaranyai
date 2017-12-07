using System;

namespace Factorio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your number? ");
            int input = Int32.Parse(Console.ReadLine());
            Console.WriteLine(Factorialing(input));
            Console.ReadLine();
        }
        public static int Factorialing(int input)
        {
            for (int i = 1; i < input; i++)
            {
                input = input* i;
            }
            
            return input;

        }
    }
}
