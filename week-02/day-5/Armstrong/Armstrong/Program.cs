using System;

namespace Armstrong
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type your number: ");
            string usernumber = Console.ReadLine();
            int n = usernumber.Length;

            int[] intArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                intArray[i] = int.Parse(usernumber);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
