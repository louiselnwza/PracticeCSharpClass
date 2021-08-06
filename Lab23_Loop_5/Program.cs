using System;

namespace Lab23_Loop_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberIsFactorial = 9999;
            int summary = 1;
            int i = 1;


            Console.Write("Enter your number : ");
            numberIsFactorial = Convert.ToInt32(Console.ReadLine());

            while (i <= numberIsFactorial)
            {
                summary = summary * i;
                i++;
            }

            Console.Write("{0}", summary);
        }
    }
}
