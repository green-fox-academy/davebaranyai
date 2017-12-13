using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            AppleString applestring = new AppleString();
            applestring.PrintMessage();

            Console.ReadLine();
        }
    }
    public class AppleString
    {
        private string message;

        public AppleString()
        {
            this.message = "kutya";
        }
        public string PrintMessage()
        {
            Console.WriteLine(message);
            return message;
        }
    }
}
