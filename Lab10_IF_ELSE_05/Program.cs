using System;

namespace Lab10_IF_ELSE_06
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 : Declare Variable 
            int number = 0;

            // 2 : Input 
            number = Convert.ToInt32(Console.ReadLine());
            bool isMoreThan10 = false;


            #region :: Option 1 :: 
            // 3 : Process 
            if (number >= 10)
            {
                Console.WriteLine("Equal or More than 10");
            }
            else
            {
                Console.WriteLine("less than 10");
            }

            #endregion

            #region :: Option 2 :: 
            // 3 : Process 
            if (number >= 10)
            {
                isMoreThan10 = true;
            }

            // 4 : Output 
            Console.WriteLine("Is this number more than 10 ? {0}", isMoreThan10);

            #endregion

        }
    }
}
