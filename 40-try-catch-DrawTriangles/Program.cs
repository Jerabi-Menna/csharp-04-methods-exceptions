﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40_try_catch_DrawTriangles
{
    class Program
    {
        /*
         * Purpose: 
         *      - Draw triangles on the screen using a specificed character
         *        while handling invalid inputs.
         * 
         * Input: 
         *    - Size of Triangle
         *    - Character to draw triangle with.
         * 
         * Process:
         *      - Use a for loop to draw the correct number of characters. 
         *
         * Output:
         *    - Display Asterix Triangle
         *    - Display Custom Triangle
         *         
         * Written By: Robbin Law
         * Date Modified: 2019-10-07
         * */
        static void Main(string[] args)
        {
            int num = GetNumber("Enter the number of rows: ");
            Console.Write("Enter the Draw Character: ");

            char c = char.Parse(Console.ReadLine());
            Console.WriteLine("\nDefault");
            DrawTriangle(num);
            Console.WriteLine("\nCustom");
            DrawTriangle(num, c);
        }

        static int GetNumber(string msg)
        {
            bool validInput = false;
            int num = 0;

            while (!validInput)
            {
                Console.Write(msg);
                try
                {
                    num = int.Parse(Console.ReadLine());

                    if (num > 0 && num <= 10)
                        validInput = true;
                    else
                    {
                        Console.WriteLine("Invalid Input. Number must be bigger than zero.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex}");
                }
            }
            return num;
        }

        static void DrawTriangle(int rows)
        {
            char c = '*';
            DrawTriangle(rows, c);
        }

        static void DrawTriangle(int rows, char drawChar)
        {
            for (int i = 1; i <= rows; i++)
            {
                DrawRow(i, drawChar);
            }
        }

        static void DrawRow(int len, char c)
        {
            for (int i = 0; i < len; i++)
            {
                Console.Write(c);
            }
            Console.Write("\n");
        }
    }
}
