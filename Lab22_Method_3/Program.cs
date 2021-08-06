using System;

namespace Lab22_Method_3
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1 : Declare Variable 
            double width = 0, height = 0, areaOfTriangle = 0;

            // 2 : Input 
            Console.Write("Enter width : ");
            width = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter height : ");
            height = Convert.ToDouble(Console.ReadLine());

            // 3 : Process 
            areaOfTriangle = CalculateTriangle(width, height);
            // 4 : Output
            Console.WriteLine("Area Triangle is {0}", areaOfTriangle);
        }

        public static double CalculateTriangle(double width, double height)
        {
            double areaTrignable = (0.5) * width * height;
            return areaTrignable;
        }
    }
}
