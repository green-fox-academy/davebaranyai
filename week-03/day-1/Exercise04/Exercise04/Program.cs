using System;
using System.IO;

namespace Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @".\My-File.txt";
            FileWriter(fileName);
        }
        static void FileWriter(string fileName)
        {
            try
            {
                File.WriteAllText(fileName, "Baranyai David");
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine("Unable to write file: my-file.txt");
                Console.Read();                
            }            
        }
    }
}
