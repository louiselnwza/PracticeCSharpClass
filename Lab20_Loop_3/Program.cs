using System;

namespace Lab20_Loop_3
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

            double maxscore = 0;
            double minscore = 0;

            // 2 : Input 
            while (isPositive)
            {
                Console.Write("Enter a score : ");
                scoreOfStudent = Convert.ToDouble(Console.ReadLine());

                if (scoreOfStudent >= 0)
                {
                    summaryScoreOfStudent = summaryScoreOfStudent + scoreOfStudent;
                    iCountNoOfStudent = iCountNoOfStudent + 1; // iCountNoOfStudent++

                    if (iCountNoOfStudent == 1)
                    {
                        maxscore = scoreOfStudent;
                        minscore = scoreOfStudent;
                    }
                    else
                    {           
                        if (maxscore <= scoreOfStudent)
                        {
                            maxscore = scoreOfStudent;
                        }
                              
                        if (scoreOfStudent <= minscore)
                        {
                            minscore = scoreOfStudent;
                        }
                    }
                }
                else
                {
                    isPositive = false;
                }
            }
            averageScoreOfStudent = (summaryScoreOfStudent / iCountNoOfStudent);

            Console.WriteLine("Number of Student is {0}", iCountNoOfStudent);
            Console.WriteLine("Max score is {0} ", string.Format("{0:N2}", maxscore));
            Console.WriteLine("Min score is {0} ", string.Format("{0:N2}", minscore));
            Console.WriteLine("Average score is {0} ", string.Format("{0:N2}", averageScoreOfStudent));
        }
    }
}
