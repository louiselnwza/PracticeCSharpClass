using System;

namespace Lab11_IF_ELSE_07
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 : Declare Variable 
            string text = "";

            // 2 : Input 
            Console.Write("Enter Text : ");
            text = Console.ReadLine();

            // 3 : Process 
            if (text.ToUpper() == "A")
            {
                //4 : Output 
                Console.WriteLine("IS A");
            }
            else
            {
                //4 : Output 
                Console.WriteLine("IS NOT A");
            }
        }
    }
}
