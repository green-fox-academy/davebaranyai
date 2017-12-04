using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mi a szam?");

            try
            {
                int divisor = int.Parse(Console.ReadLine());
                int result = 10 / divisor;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Fail");
            }
            finally
            {
                Console.ReadLine();
            }
        }

    }
}
