using System;
using System.Collections.Generic;

namespace Matchmaking
{
    public class Matchmaking
    {
        public static void Main(string[] args)
        {
            var girls = new List<string> { "Eve", "Ashley", "Bözsi", "Kat", "Jane" };
            var boys = new List<string> { "Joe", "Fred", "Béla", "Todd", "Neef", "Jeff" };
            var order = new List<string>();

            for (int i = 0; i < girls.Count; i++)
            {
                order.Add(girls[i]);
                order.Add(boys[i]);
            }

            foreach (string member in order)
            {

                Console.WriteLine(member);

            }
            Console.ReadLine();
            
        }
    }
}