using System;

namespace EX6_Method
{
    class Program
    {
        static double pocketMoney = 0;

        static void Main(string[] args)
        {
            // จงเขียนโปรแกรมสร้างเมท็อด ฝากเงิน ถอนเงินและเช็คยอดเงิน
            // โดยให้รับค่าจำนวนเงินที่จะต้องทำการฝาก หรือ ถอน  

            // 1 : Declare Variable 
            string menuNumber = "";
            double myMoney = 0;
            bool isExit = false;

            do
            {
                // 2 : Input 
                Console.WriteLine("---- ATM Online ----  ");
                Console.WriteLine("Press 1 : Deposite");
                Console.WriteLine("Press 2 : Withdraw");
                Console.WriteLine("Press 3 : Check Balance");
                Console.WriteLine("");
                Console.Write("Please Select Menu : ");

                menuNumber = Console.ReadLine();
                // 3 : Process 
                switch (menuNumber)
                {
                    case "1":
                        Console.Write("Enter you money that you need to deposite : ");
                        myMoney = Convert.ToDouble(Console.ReadLine()); // ส่งเลขไปโดยที่ไม่ต้อง Return ค่ากลับ 
                        Deposite(myMoney);
                        break;
                    case "2":
                        Console.Write("Enter you money that you need to withdraw : ");
                        myMoney = Convert.ToDouble(Console.ReadLine());
                        Withdraw(myMoney);
                        break;
                    case "3":
                        myMoney = CheckBalance();
                        Console.WriteLine("Thank you, Your current balance is {0}", myMoney);
                        break;

                    default:
                        Console.WriteLine("You not select the menu, Please try again later");
                        break;
                }


                Console.Write("Did you need to do anything else ? (Y/N) : ");
                if (Console.ReadLine().ToUpper() == "Y")
                {
                    isExit = false;
                }
                else
                {
                    isExit = true;
                    Console.WriteLine("");
                    Console.WriteLine(" Thank you ");
                }
                Console.WriteLine("");
                Console.WriteLine("");
            } while (!isExit);
        }

        public static void Deposite(double mymoney ) // ฟังก์ชันนี้ไม่ส่งค่ากลับ แต่รับค่าจากตัวที่ถูกเรียกมา 
        {

            //Console.WriteLine("This is Deposite Menu");
            double currentMoneyBalance = pocketMoney;
            currentMoneyBalance = currentMoneyBalance + mymoney;

            pocketMoney = currentMoneyBalance;

            Console.WriteLine("Thank you, Your current balance is {0}", currentMoneyBalance);

        }

        public static void Withdraw(double mymoney ) // ฟังก์ชันนี้ไม่ส่งค่ากลับ แต่รับค่าจากตัวที่ถูกเรียกมา 
        {
            //Console.WriteLine("This is Withdraw Menu");
            double currentMoneyBalance = pocketMoney;
            currentMoneyBalance = currentMoneyBalance - mymoney;
            pocketMoney = currentMoneyBalance;
            Console.WriteLine("Thank you, Your current balance is {0}", currentMoneyBalance);
        }

        public static double CheckBalance() // ฟังก์ชันแบบ ไม่รับค่า แต่ส่งค่ากลับ
        {
            return pocketMoney; // ส่งค่า 1000 กลับไปยังตัวที่เรียกมัน 
        }

    }
}
