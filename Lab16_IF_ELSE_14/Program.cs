using System;

namespace Lab16_IF_ELSE_14
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 : Declare Variable 
            const int ratePerHour = 350;
            int totalWorkHour = 0;
            int calSalary = 0;
            int payTheMoney = 0;
            int change = 0;

            // 2 : Input 
            Console.Write("Enter Hour : ");
            totalWorkHour = Convert.ToInt32(Console.ReadLine());
            calSalary = totalWorkHour * ratePerHour;

            Console.WriteLine("Total Salary : {0}", calSalary);
            Console.Write("Pay : ");
            payTheMoney = Convert.ToInt32(Console.ReadLine());

            // 3 : Process 
            if (payTheMoney > calSalary)
            {
                change = payTheMoney - calSalary;
                //4 : Output 

                Console.WriteLine("Change : {0}", change);
            }
            else
            {
                change = calSalary - payTheMoney;
                //4 : Output 
 
                Console.WriteLine("Please found some money \"{0}\" THB for pay", change);
            }



        }
    }
}
