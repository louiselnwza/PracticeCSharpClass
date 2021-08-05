using System;

namespace Lab07_CalSumGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 : Declare Variable 
            double midterm = 0;
            double final = 0;
            double homework = 0;
            double total = 0;

            // 2 : Input 
            Console.Write("Mid term : ");
            midterm = Convert.ToDouble(Console.ReadLine());
            Console.Write("Final Term : ");
            final = Convert.ToDouble(Console.ReadLine());
            Console.Write("Homework : ");
            homework = Convert.ToDouble(Console.ReadLine());

            // 3 : Process 
            total = (0.4 * midterm) + (0.5 * final) + (0.1 * homework);

            //4 : Output 
            Console.WriteLine("Summary Score is : {0}", total);

        }
    }
}
