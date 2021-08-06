using System;

namespace Lab21_Method_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;

            Console.Write("Please Enter the number : ");
            number = Convert.ToInt32(Console.ReadLine());

            PrintSign(number);

        }

        public static void PrintSign(int number)
        {
            if (number > 0)
            {
                Console.WriteLine("I +");
            }
            else if (number == 0 )
            {
                Console.WriteLine("I0");
            }
            else
            {
                Console.WriteLine("I-");
            }
        }
    }
}
