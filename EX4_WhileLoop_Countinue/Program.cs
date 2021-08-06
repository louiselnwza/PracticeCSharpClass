using System;

namespace EX4_WhileLoop_Countinue
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 : Declare Variable 
            bool isPlus = true;
            int number = 0;

            Console.Write("*** IF Number is I-, Program will terminate");

            //while (isPlus)
            //{
            //    Console.Write("Enter Number : ");
            //    number = Convert.ToInt32(Console.ReadLine());

            //    if (number < 0)
            //    {
            //        isPlus = false;
            //    }
            //}

            do
            {
                Console.Write("Enter Number : ");
                number = Convert.ToInt32(Console.ReadLine());

                if (number < 0)
                {
                    isPlus = false;
                }
            } while (isPlus);


            // 2 : Input

            // 3 : Process 

            // 4 : Output

        }
    }
}
