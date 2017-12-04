using System;
using System.IO;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @".\my-file.txt";
            try
            {
                string[] stuff = File.ReadAllLines(path);

                foreach (var line in stuff)
                {
                    Console.WriteLine(line);
                }

            }
            catch (FileNotFoundException e)
            {

                Console.WriteLine("Unable to read file: my-file.txt");
            }          

            Console.ReadLine();
        }
    }
}
