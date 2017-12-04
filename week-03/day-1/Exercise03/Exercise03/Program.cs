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

            string[] array1 = File.ReadAllLines(InputMove);
        }
        static string InputMove()
        {
            string Input = @"./my-file.txt";
            return Input;
        }
    }
    
}
