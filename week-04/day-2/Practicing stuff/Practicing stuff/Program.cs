using System;

namespace Practicing_stuff
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.Lives = 134;

            Console.WriteLine(player.Lives);
            Console.ReadLine();

        }
    }
}
