using System;

namespace Lab08_Mean
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 : Declare Variable 
            double mean = 0.0, x1 = 0, x2 = 0, x3 = 0, x4 = 0;

            // 2 : Input 
            Console.Write("x1 : ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x2 : ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x3 : ");
            x3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x4 : ");
            x4 = Convert.ToDouble(Console.ReadLine());

            // 3 : Process 
            mean = (x1 + x2 + x3 + x4) / 4;

            //4 : Output
            Console.WriteLine("Mean is : {0}", mean);
        }
    }
}
