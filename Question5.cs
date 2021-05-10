////using System;
////using System.Collections.Generic;
////using System.Text;

////namespace Assesment3
////{
////    class Question5
////    {
////        public static void Main()
////        {
////            string username = "Admin", password = "admin";
////            int count = 0, pass = 0;
////            Console.Write("\n\nCheck username and password :\n");
////            do
////            {
////                Console.Write("Input a username: ");
////                string user = Console.ReadLine();
////                Console.Write("Input a password: ");
////                string passw = Console.ReadLine();
////                if (username == user && password == passw)
////                {
////                    pass = 1;
////                    count = 3;
////                }
////                else
////                {
////                    Console.WriteLine("Try again");
////                    pass = 0;
////                    count++;
////                }
////            }
////            while ((username != "username" || password != "password") && (count != 3));
////            if (pass == 0)
////            {
////                Console.Write("\nLogin attemp more than three times. Try later!\n\n");
////            }
////            else
////            if (pass == 1)
////            {
////                Console.Write("\nPassword entered successfull!\n\n");
////            }
////        }
////    }
////}

