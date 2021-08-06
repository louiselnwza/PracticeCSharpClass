using System;

namespace Lab19_Loop_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 : Declare Variable 
            double averageScoreOfStudent = 0;
            double summaryScoreOfStudent = 0;
            int iCountNoOfStudent = 0;
            double scoreOfStudent = 0;
            bool isPositive = true;

            // 2 : Input 
            while (isPositive)
            {
                Console.Write("Enter a score : ");
                scoreOfStudent = Convert.ToDouble(Console.ReadLine());

                if (scoreOfStudent >= 0)
                {
                    summaryScoreOfStudent = summaryScoreOfStudent + scoreOfStudent;
                    iCountNoOfStudent = iCountNoOfStudent + 1; // iCountNoOfStudent++
                }
                else
                {
                    isPositive = false;
                }
            }
            averageScoreOfStudent = (summaryScoreOfStudent / iCountNoOfStudent);

            Console.WriteLine("Number of Student is {0}", iCountNoOfStudent);
            Console.WriteLine("Average score is {0} ", string.Format("{0:N2}", averageScoreOfStudent));

        }
    }
}
