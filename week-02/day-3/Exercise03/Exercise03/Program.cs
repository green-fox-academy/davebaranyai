using System;
using System.Text;

namespace TakesLonger
{
    public class TakesLonger
    {
        public static void Main(string[] args)
        {
            string quote = "Hofstadter's Law: It you expect, even when you take into account Hofstadter's Law.";

            // When saving this quote a disk error has occured. Please fix it.
            // Add "always takes longer than" to the StringBuilder (quote) between the words "It" and "you"
            // Using pieces of the quote variable (instead of just redefining the string)
            string piece1 = quote.Substring(0, 21);
            string piece2 = "always takes longer than ";
            string piece3 = quote.Substring(21);


            StringBuilder fullquote = new StringBuilder();
            fullquote.Append(piece1);
            fullquote.Append(piece2);
            fullquote.Append(piece3);


            Console.WriteLine(fullquote);
            Console.ReadLine();
        }
    }
}