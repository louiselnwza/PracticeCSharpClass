using System;

namespace Lab05_Cylindrical
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 : Declare Variable 
            int radius = 0;
            int height = 0;
            double area = 0;
             

            // 2 : Input 
            Console.Write("Enter Radius : ");
            radius = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Height : ");
            height = Convert.ToInt32(Console.ReadLine());

            // 3 : Process 
            area = Math.PI * radius * radius * height;

            //4 : Output 
            Console.WriteLine("Area is : {0}", area);
        }
    }
}
