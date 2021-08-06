using System;

namespace Lab18_Loop_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // จงเขียนโปรแกรมเพื่อรับตัวเลขจำนวนเต็มพร้อมทั้งแสดงผลรวมของตัวเลข
            // โดยที่ผู้ใช้งานระบบจะต้องกรอกตัวเลขจำนวนเต็มได้เรื่อย ๆ
            // จนกว่าผู้ใช้จำป้อนจำนวนติดลบเข้ามา ( ผลรวมที่จะแสดงนั้นต้องไม่รวมจำนวนเต็มลบที่กรอกมา ) 

            // 1 : Declare Variable 
            int number = 0;
            int sum = 0;
            bool isPlus = true;


            // 3 : Process 
            do
            {
                // 2 : Input 
                sum = sum + number;
                Console.Write("Please Input : ");
                number = Convert.ToInt32(Console.ReadLine());

                if (number < 0)
                {
                    isPlus = false;
                }

            } while (isPlus);

            // 4 : Output
            Console.WriteLine("SUM : {0}", sum);
        }
    }
}
