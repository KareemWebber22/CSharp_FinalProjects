//using System;
//using System.Runtime.CompilerServices;
//using System.Security.Cryptography.X509Certificates;

//namespace Application_1
//{
//    class Student_Grading_System
//    {

//        /*
//            Student Marks Calculator (Console App)
//            Input student names and marks using arrays or lists.
//            Calculate average, highest, and lowest scores.
//            Display results with formatting
//            All logic can go in static methods in a Program class.
//        */

//        static void Main(string[] args)
//        {
//            Console.Write("Please enter number of students: ");

//            int Enter_Students_Number = int.Parse(Console.ReadLine());

//            int[] Students_number = new int[Enter_Students_Number];

//            float Subject_Mark = 0;

//            float Previous_Mark = 0;

//            float Highest_Mark = 0;

//            float Lowest_Mark = 0;

//            float Total = 0;

//            for (int i = 1; i < (Students_number.Length)+1; i++)
//            {
//                Console.Write($"Please enter student '{i}' name: ");

//                string Student_Name = Console.ReadLine();

//                Console.Write("Please enter number of subjects: ");

//                int Enter_Subjects_Number = int.Parse(Console.ReadLine());

//                int[] Subjects = new int[Enter_Subjects_Number];

//                Total = 0;

//                Console.WriteLine($"Please enter {Subjects.Length} subjects grades: ");
//                for (int j = 0; j < Subjects.Length; j++)
//                {

//                    Console.Write($"Subject {j+1}: ");
//                    Subjects[j] = int.Parse(Console.ReadLine());
//                    Console.WriteLine();

//                    Total += Subjects[j];
//                }

//                Console.WriteLine($"Hello {Student_Name}!, Welocme to our student grading system.");

//                Console.WriteLine($"Your Average Score is: {Math.Round((Total / Subjects.Length),2)}");
//                Console.WriteLine($"Your Highest Score is: {Subjects.Max()}");
//                Console.WriteLine($"Your Lowest Score is: {Subjects.Min()}");
//            }
//        }
//    }
    
//}