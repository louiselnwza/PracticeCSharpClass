using System;

namespace Lab06_DateTimeNow
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 : Declare Variable
            int hour = 0;
            int min = 0;
            int sec = 0;
            DateTime nowdate = new DateTime();

            // 2 : Input 
            Console.Write("Hour : ");
            hour = Convert.ToInt32(Console.ReadLine());

            Console.Write("Minute : ");
            min = Convert.ToInt32(Console.ReadLine());

            Console.Write("Sec : ");
            sec = Convert.ToInt32(Console.ReadLine());


            // 3 : Process 
            nowdate = nowdate.AddHours(hour);
            nowdate = nowdate.AddMinutes(min);
            nowdate = nowdate.AddSeconds(sec);


            //4 : Output 
            Console.WriteLine(nowdate.ToString("HH:mm:ss"));
            //Console.WriteLine("{0}:{1}:{2}", hour, min, sec);
        }
    }
}
