using System;

namespace Lab04_TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1 : Declare Variable 
            double areaTriangleArea = 0.0;
            int baseTriangleArea = 0;
            int widthTriangleArea = 0;

            // 2 : Input 
            Console.Write("Enter Base : ");
            baseTriangleArea = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Width : ");
            widthTriangleArea = Convert.ToInt32(Console.ReadLine());

            // 3 : Process 
            areaTriangleArea = (0.5) * baseTriangleArea * widthTriangleArea;

            // 4 : Output
            Console.WriteLine("Area TriangleArea is : {0}", areaTriangleArea);
        }
    }


}
