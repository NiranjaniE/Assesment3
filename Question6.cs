////using System;
////using System.Collections.Generic;
////using System.Text;

////namespace Assesment3
////{
////    class Question6
////    {
////        public static void Main()
////        {
////            string[] arr = { "kite", "four", "neat", "play", "goal" };

////            Console.WriteLine("Play.......");
////            for (int i = 0; i < arr.Length; i++)
////            {
////                Console.WriteLine("Enter the guess");
////                string Word = Console.ReadLine();
////                string Entered = arr[i];
////                int cows = 0, bulls = 0;
////                if (Entered.Length == Word.Length)
////                {

////                    for (i = 0; i < Entered.Length; i++)
////                    {
////                        if (Entered[i] == Word[i])
////                        {
////                            cows += 1;
////                        }
////                        else
////                        {
////                            for (int j = 0; j < Entered.Length; j++)
////                            {
////                                if (Entered[i] == Word[j] && i != j)
////                                {
////                                    bulls += 1;
////                                }
////                            }
////                        }
////                        Console.WriteLine("*Cows*" + cows + " *Bulls*" + bulls);
////                        Console.WriteLine("\n\n");

////                    }

////                    if (cows == Entered.Length)
////                    {
////                        Console.WriteLine("Congratulations You Won the Game");
////                    }                 
////                }
////                else
////                {
////                    Console.WriteLine("Must enter " + Entered.Length + " letter a Word");
////                }
////            }
////        }
////    }
////}
