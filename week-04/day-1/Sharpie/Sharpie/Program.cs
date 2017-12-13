using System;

namespace Sharpie
{
    class Program
    {
        static void Main(string[] args)
        {
            var sharpie1 = new Sharpie();

            Console.WriteLine(sharpie1.Color = "orange");
            Console.WriteLine(sharpie1.Width = 3.2);
            Console.WriteLine("Ink Amount: " + sharpie1.InkAmount);
            sharpie1.Use();
            Console.WriteLine("Ink Amount after usage: " + sharpie1.InkAmount);
            Console.ReadLine();
        }
    }
}
