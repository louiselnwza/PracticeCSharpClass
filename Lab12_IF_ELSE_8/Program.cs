using System;

namespace Lab12_IF_ELSE_8
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
            if (text.ToUpper() == "A")
            {
                //4 : Output 
                Console.WriteLine("{0} IS A", number);
            }
            else
            {
                //4 : Output 
                Console.WriteLine("{0} IS NOT A", number);
            }
        }
    }
}
