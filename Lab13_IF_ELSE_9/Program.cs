using System;

namespace Lab13_IF_ELSE_9
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 : Declare Variable 
            string text = "";
            int number = 0;

            // 2 : Input 
            Console.Write("Enter Text : ");
            text = Console.ReadLine();

            Console.Write("Enter Number : ");
            number = Convert.ToInt32(Console.ReadLine());

            // 3 : Process 
            if (text.ToUpper() != "Y")
            {
                // True
                //4 : Output 
                Console.WriteLine("{0} IS NOT Y", number);
            }
            else
            {
                //False
                //4 : Output 
                Console.WriteLine("{0} IS Y", number);
            }
        }
    }
}
