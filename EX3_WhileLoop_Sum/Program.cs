using System;

namespace EX3_WhileLoop_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //จงเขียนโปรแกรมเพื่อพิมพ์ค่าผลรวมของตั้งแต่ 1 ถึง N  โดยรับค่า N จากผู้ใช้งานระบบ

            // 1 : Declare Variable 
            int sum = 0;
            int nCount = 0;
            int i = 1;

            // 2 : Input 
            Console.Write("Enter N : ");
            nCount = Convert.ToInt32(Console.ReadLine());

            // 3 : Process 
            while (i <= nCount)
            {
                sum = sum + i;
                i = i + 1; // i++;
                int a = 0;
            }
  
            // 4 : Output
            Console.WriteLine("Summary is : {0}", sum);

        }
    }
}
