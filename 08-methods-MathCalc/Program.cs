﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_methods_MathCalc
{
    class Program
    {

        static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("Math Quiz");
            Console.WriteLine("**********\n");
            Console.WriteLine("a) \tAddition Question");
            Console.WriteLine("s) \tSubtraction Question");
            Console.WriteLine("m) \tMultiplication Question");
            Console.WriteLine("d) \tDivision Question");
            Console.WriteLine("q) \tQuit");
        }
        
        static double Add(double a, double b)
        {
            return a + b;
        }

        static double Subtract(double a, double b)
        {
            return a - b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static double Divide(double a, double b)
        {
            return a / b;
        }

        static string GetChoice()
        {
            Console.Write("Please enter a choice: ");
            string initial = Console.ReadLine();
            string c = initial.ToLower();
            switch (c)
            {
                case "a":
                case "s":
                case "m":
                case "d":
                case "q":
                    return c;

                default:
                    Console.WriteLine("Invalid Option.");
                    return GetChoice();
            }
        }

        static double DoThatMath(string c)
        {
            double a, b;
            Console.Write("Enter Number 1: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Enter Number 2: ");
            b = double.Parse(Console.ReadLine());

            if (c == "a") return Add(a, b);
            if (c == "s") return Subtract(a, b);
            if (c == "m") return Multiply(a, b);
            else return Divide(a, b);
        }

        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                DisplayMenu();
                string c = GetChoice();
                if (c == "q")
                    running = false;
                else
                {
                    Console.WriteLine("Result is: " + DoThatMath(c));
                    Console.WriteLine("Press Enter to Continue");
                    Console.ReadLine();
                }
            }
            Console.WriteLine("Goodbye!");
        }
    }
}
