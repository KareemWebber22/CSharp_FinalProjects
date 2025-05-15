//using System;
//using System.Security.Cryptography.X509Certificates;

//namespace Application_2
//{
//    class Quiz_Game
//    {

//        /*
//            Simple Text-Based Quiz Game
//            Load multiple questions and answers from a text file or hardcoded arrays.
//            Ask questions one by one and take user input.
//            Keep track of the score and show final result.
//        */

//        static void Main(string[] args)
//        {
//            string[] Quiz_Questions = { "Write the first letter in this question.", "What's the sun little brother?" };

//            string[] Quiz_Answers = { "w", "moon" };

//            int score = 0;

//            Console.WriteLine("Welcome to Quiz game!");

//            for (int i = 0; i < 2; i++)
//            {
//                Console.WriteLine($"Question number {i+1}:");

//                Console.WriteLine($"{Quiz_Questions[i]}");

//                Console.Write("Answer: ");

//                string User_Input = Console.ReadLine();

//                if (Quiz_Answers[i] == User_Input.ToLower())
//                {
//                    Console.WriteLine("Right Answer!");

//                    score += 1;
//                }
//                else
//                {
//                    Console.WriteLine("That's not quite right...");
//                }
//            }

//            float Final_Score = (score / Quiz_Questions.Length)*100;

//            Console.WriteLine($"Your final score is: {Final_Score}%");

//        }

//    }
//}