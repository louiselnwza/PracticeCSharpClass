using System;

namespace Lab14_IF_ELSE_10
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 : Declare Variable 
            int number1 = 0, number2 = 0;

            // 2 : Input 
            Console.Write("Enter 1st Number : ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd Number : ");
            number2 = Convert.ToInt32(Console.ReadLine());

            // 3 : Process 
            if (number1 > number2)
            {
                Console.WriteLine("{0} > {1}", number1, number2);
            }
            else
            {
                Console.WriteLine("{0} <= {1}", number1, number2);
            }
        }
    }
}
