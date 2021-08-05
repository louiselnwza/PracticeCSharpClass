using System;

namespace Lab03_StudentInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentID = "";
            string firstName = "";
            //  string lastName = "";
            string lastName = "";
            Int32 age = 0;
            string msg = "";

            if (!string.IsNullOrEmpty(studentID))
            {
                Console.Write("Enter Your Student ID : ");
                studentID = Console.ReadLine();
            }



            Console.Write("Enter Your First Name : ");
            firstName = Console.ReadLine();

            Console.Write("Enter Your Last Name : ");
            lastName = Console.ReadLine();

            Console.Write("Enter Your Age : ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("-----------------------------------");
            // Console.WriteLine("Your StudentID is : " + studentID);
            // Console.WriteLine("Your First Name is : " + firstName);
            // Console.WriteLine("Your Last Name is : " + lastName);
            // Console.WriteLine("Your Age is " + age);

            msg = string.Format(@"
Your Student ID is : {0}
Your First Name is : {1}  
Your Last Name is : {2}
Your Age is : {3}", studentID, firstName, lastName, age);

            Console.WriteLine(msg);

        }
    }
}
