using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            AppleString applestring = new AppleString("apple");
            applestring.PrintMessage();

            Console.ReadLine();
        }
    }
    public class AppleString
    {
        private string message;

        public AppleString(string message)
        {
            this.message = message;
        }
        public string PrintMessage()
        {
            Console.WriteLine(message);
            return message;
        }
    }
}
