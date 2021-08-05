using System;

namespace EX1_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu = 0;
            string name = "";

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

            name = Console.ReadLine();

            switch (name)
            {
                case "A":
                    Console.WriteLine("Hello A !!!");
                    break;
                case "B":
                    Console.WriteLine("Hello B !!!");
                    break;
                case "C":
                    Console.WriteLine("Hello C !!!");
                    break;
                //default:
                //    Console.WriteLine("Hello Someone");
                //    break;
            }
        }
    }
}
