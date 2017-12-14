using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = 4;
            int height = 4;

            int[,] matrix = new int[width, height];

            for (int i = 0; i < width; i++)
            {
                matrix[i, i] = 1;
            }

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Console.Write(matrix[x, y] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

            // - Create (dynamically) a two dimensional array
            //   with the following matrix. Use a loop!
            //
            //   1 0 0 0
            //   0 1 0 0
            //   0 0 1 0
            //   0 0 0 1
            //
            // - Print this two dimensional array to the output
        }
    }
}
