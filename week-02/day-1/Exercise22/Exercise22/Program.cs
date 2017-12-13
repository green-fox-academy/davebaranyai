using System;

namespace Exercise22
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = 22;
            int Out = 0;            
            Console.WriteLine("Result A: " + MethodA(A, Out));            

            int B = 13;
            string Out2 = "";
            Console.WriteLine("Result B: " + MethodB(B, Out2));

            int C = 123;
            int Credits = 100;
            bool Isbonus = false;
            Console.WriteLine("Result C: " + MethodC(C, Credits, Isbonus));            

            int D = 8;
            int Time = 123;
            string Out3 = "";
            Console.WriteLine("Result D: " + MethodD(D, Time, Out3));
            Console.ReadLine();

        }
        static int MethodA(double A, int Out)
        {
            if (A % 2 > 0)
            {
                return Out;
            }
            return Out += 1;
        }
        static string MethodB(int B, string Out2)
        {
            if (B < 10)
            {
                return Out2 = "Less!";
            }
            else if (B > 20)
            {
                return Out2 = "More!";
            }
            else
            {
                return Out2 = "Sweet!";
            }
        }
        static int MethodC(int C, int Credits, bool Isbonus)
        {
            if (Isbonus == true)
            {
                return C;
            }
            else if (Credits >= 50 && Isbonus == false)
            {
                return C - 2;
            }
            else
            {
                return C--;
            }
        }
        static string MethodD(int D, int Time, string Out3)
        {
            if (Time > 200)
            {
                return Out3 = "Time out";
            }
         //   else if (D % 4 == 0)
         //   {
         //       return Out3 = "Check";
         //   }
         //   else
	        //{
         //       return Out3 = "Run, Forest, run!";
         //   }
            else if (D % 4 > 0)
            {
                return Out3 = "Run, Forest, run!";                
            }
            else
            {
                return Out3 = "Check";
            }
        }
    }
}
