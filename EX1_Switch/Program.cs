using System;

namespace EX1_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu = 0;

            menu = Convert.ToInt32(Console.ReadLine());

            switch (menu)
            {
                case 101:
                    Console.WriteLine("Deposite");
                    break;

                case 201:
                    Console.WriteLine("Withdraw");
                    break;

                case 301:
                    Console.WriteLine("Check Balance");
                    break;

                default:
                    Console.WriteLine("Please Enter Menu Code");
                    break;
            }
        }
    }
}
