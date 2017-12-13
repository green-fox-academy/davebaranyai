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
            Console.ReadLine();         
        }
        static void Comparing(int Number1, int Number2)
        {
            if (Number2 <= Number1)
            {
                Console.WriteLine("The second number should be bigger");
            }
            else
	        {
                Counting(Number1, Number2);
            }
        }
        static void Counting(int Number1, int Number2)
        {
            for (int i = Number1; i < Number2; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
