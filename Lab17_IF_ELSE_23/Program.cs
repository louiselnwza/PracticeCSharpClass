using System;

namespace Lab17_IF_ELSE_23
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 : Declare Variable 
            int number = 0;
            bool isOdd = false;

            // 2 : Input 
            Console.Write("Enter Number : ");
            number = Convert.ToInt32(Console.ReadLine());

            // 3 : Process 
            if (number % 2 != 0)
            {
                isOdd = true;
            }

            //4 : Output 
            Console.WriteLine("Is Odd ? {0}", isOdd);
        }
    }
}
