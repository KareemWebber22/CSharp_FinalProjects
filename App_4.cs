//using System;
//using System.Runtime.CompilerServices;
//using System.Security.Cryptography.X509Certificates;

///*
//    Menu-driven console app: Celsius ↔ Fahrenheit ↔ Kelvin.
//    Use switch or if-else logic.
//*/

//namespace Application_4
//{
//    class Temperature_Converter
//    {
//        static float Temp_Type = 0;

//        static float Temp_Degree = 0;

//        static void Main(string[] args)
//        {
//            Console.WriteLine("Welcome to Temperature converter application.");

//            Console.WriteLine("Please choose the temperature type you want to enter.");

//            Console.Write("Please type '1' for Celsius, '2' for Fahrenheit or '3' for Kelvin: ");

//            Temp_Type = float.Parse(Console.ReadLine());

//            Console.Write("Please enter the temperature degree for conversion: ");

//            Temp_Degree = float.Parse(Console.ReadLine());

//            switch (Temp_Type)
//            {
//                case 1:

//                    Console.WriteLine($"Your temperature in Fahrenheit = {Math.Round((Temp_Degree * 1.8) + 32,2)}");
//                    Console.WriteLine($"Your temperature in Kelvin = {Math.Round(Temp_Degree + 273.15,2)}");
//                    break;

//                case 2:

//                    Console.WriteLine($"Your temperature in Celsius = {Math.Round((Temp_Degree - 32) * 0.556,2)}");
//                    Console.WriteLine($"Your temperature in Kelvin = {Math.Round((Temp_Degree - 32) * 0.556 + 273.15,2)}");
//                    break;

//                case 3:

//                    Console.WriteLine($"Your temperature in Celsius = {Math.Round(Temp_Degree -  273.15,2)}");
//                    Console.WriteLine($"Your temperature in Fahrenheit = {Math.Round((Temp_Degree - 273.15) * 1.8 + 32,2)}");
//                    break;
//            }
//        }
//    }
//}

