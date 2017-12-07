using System;
using System.IO;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {

            // Write a function that takes a filename as string,
            // then returns the number of lines the file contains.
            // It should return zero if it can't open the file, and
            // should not raise any error.

            string Input = @"./my-file.txt";

            Console.WriteLine(InputMove(Input));

            Console.Read();
            
        }
        static int InputMove(string Input)
        {
            try
            {
                string[] array1 = File.ReadAllLines(Input);
                int ArrayLength = array1.Length;
                return ArrayLength;
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("zero");

            }
            catch (Exception e)
            {
                Console.WriteLine("should not happen");

            }
            finally
            {
                Console.ReadLine();
            }

        }
    }
    
}
