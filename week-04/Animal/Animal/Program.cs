using System;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            var animal1 = new Animal();

            Console.WriteLine("This Hungry: " + animal1.Hunger);
            animal1.Eat();
            Console.WriteLine("Aaaand now this Hungry: " + animal1.Hunger);
            Console.ReadLine();

        }
    }
}
