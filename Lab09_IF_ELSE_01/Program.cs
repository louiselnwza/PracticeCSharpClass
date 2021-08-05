using System;

namespace Lab09_IF_ELSE_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 : Declare Variable 
            int number = 0;
            bool isMoreThan10 = false;

            // 2 : Input 
            number = Convert.ToInt32(Console.ReadLine());

            // 3 : Process 
            if (number > 10)
            {
                Console.WriteLine("More than 10");
                //isMoreThan10 = true;
            }

            //4 : Output 
            //Console.WriteLine("Is number more than 10 ? {0}", isMoreThan10);

        }
    }
}
