using System;

namespace Lab15_IF_ELSE_12
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 : Declare Variable 
            int money = 0;
            int THB1000 = 0;
            int THB500 = 0;
            int THB100 = 0;


            // 2 : Input 
            Console.Write("Enter Withdraw : ");
            money = Convert.ToInt32(Console.ReadLine());

            // Assume 3600 

            // 3 : Process 
            if (money >= 1000)
            {

                if (money % 1000 == 0)
                {
                    THB1000 = money / 1000;
                }
                else
                {
                    THB1000 = money / 1000; // 3
                }
                money = money % 1000;
            }

            if (money >= 500)
            {

                if (money % 500 == 0)
                {
                    THB500 = money / 500;
                }
                else
                {
                    THB500 = money / 500; // 3
                }
                money = money % 500;
            }

            if (money >= 100)
            {

                if (money % 100 == 0)
                {
                    THB100 = money / 100;
                }
                else
                {
                    THB100 = money / 100; // 3
                }
                money = money % 100;
            }

            Console.WriteLine("THB 1000 : {0} || THB 500 : {1} || THB 100 : {2}", THB1000, THB500 ,THB100);

            //if (money >= 500 && money < 1000)
            //{

            //}

            //if (money >= 100 && money < 500)
            //{

            //}


            //4 : Output 
        }
    }
}
