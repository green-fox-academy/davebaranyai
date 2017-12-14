using System;

namespace PrintArguments
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = { "stuff", "more stuff", "third stuff", "fourth one" };
            // - Create a function called `printer`
            //   which prints the input String parameters
            // - It can have any number of parameters

            // Examples
            // printer("first")
            // printer("first", "second")
            // printer("first", "second", "third", "fourh")
            // ...
        }
        static void Printer(string[] inputs)
        {
            for (int i = 0; i < inputs.Length; i++)
            {
                Console.WriteLine();
            }

        }
    }
}
