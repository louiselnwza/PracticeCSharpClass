using System;

namespace EX2_WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //โจทย์ : จงเขียนโปรแกรมเพื่อพิมพ์ค่าตั้งแต่ 1 ถึง N โดยรับค่า N จากผู้ใช้งานระบบ

            // 1 : Declare Variable 
            int countingNumber = 0;
            int i = 1; // i = iteration 

            // 2 : Input 
            Console.Write("Enter couting number : ");
            countingNumber = Convert.ToInt32(Console.ReadLine());


            // 3 : Process 
            while (i <= countingNumber)
            {
                // 4 : Output
                Console.Write("{0} ", i);
                i = i + 1; // iteration ++ 
            }
        }
    }
}
