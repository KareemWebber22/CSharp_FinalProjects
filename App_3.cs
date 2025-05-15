//using System;
//using System.Diagnostics;
//using System.Runtime.CompilerServices;
//using System.Runtime.Intrinsics.X86;
//using System.Security.Cryptography.X509Certificates;
//using System.Threading.Channels;
//using static System.Net.Mime.MediaTypeNames;

//namespace Application_3
//{
//    class Budget_Tracker
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
//            /*
//            Basic Budget Tracker
//            Let the user input incomes and expenses.
//            Calculate current balance and total monthly expenditure.
//            Save data to a text file.
//            Use procedural logic only.
//            */

//            Console.WriteLine("Welcome to budget tracker application.");

//            var methods = new Methods();

//            methods.Print_out();
//        }

//    }

//    public class Methods
//    {
//        (int, int, int)Income_Expenses(int income, int transport, int food_drinks, int weekends)
//        {
//            Console.Write("Please enter your monthly income: ");

//            income = int.Parse(Console.ReadLine());

//            Console.Write("Transportation expenses: ");

//            transport = int.Parse(Console.ReadLine());

//            Console.Write("Food and drinks expenses: ");

//            food_drinks = int.Parse(Console.ReadLine());

//            Console.Write("Weekends expenses: ");

//            weekends = int.Parse(Console.ReadLine());

//            int total_expenses = transport + food_drinks + weekends;

//            int balance = income - total_expenses;

//            return (income, total_expenses, balance);

//        }


//        public void Print_out()
//        {
//            int income = 0;

//            int transport = 0;

//            int food_drinks = 0;

//            int weekends = 0;

//            var statement = Income_Expenses(income, transport, food_drinks, weekends);

//            Console.WriteLine($"Your income is: {statement.Item1}");

//            Console.WriteLine($"Your total expenses are: {statement.Item2}");

//            Console.Write($"Your balance is: {statement.Item3}");
//        }
//    }
//}