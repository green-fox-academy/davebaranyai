using System;
using System.Text;

namespace Exercise29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many lines would you want: ");
            int LineNumber = Convert.ToInt32(Console.ReadLine());
            StringBuilder builder = new StringBuilder();

            for (int i = 1; i < LineNumber; i++)
            {
                builder.Append(' ', (LineNumber - 1)).Append('*',i).Append(' ', (LineNumber - 1)).Append("\r\n");
                Console.WriteLine(builder);
            }
            
            Console.ReadLine();

            // Write a program that reads a number from the standard input, then draws a
            // pyramid like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //
            // The pyramid should have as many lines as the number was
        }       
    }
}
