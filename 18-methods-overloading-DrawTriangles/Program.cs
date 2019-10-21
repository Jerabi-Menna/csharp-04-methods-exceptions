using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_methods_overloading_DrawTriangles
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows;
            char drawChar;
            rows = GetNumber("welcome to Triangle drawing inc. Please enter the number of rows: ");
            drawChar = getChar();
            DrawTriangle(rows, drawChar);
            DrawTriangle(rows);
        }
        static void DrawTriangle(int rows)
        {
            char drawChar = '*';
            Console.WriteLine("\nDefault character triangle \n");
            for(int i = 1;i<=rows;i++)
                {
                    DrawRow(drawChar, i);
                }
        }
        static void DrawTriangle(int rows, char drawChar)
        {
            Console.WriteLine("\nCustom character triangle \n");
            for(int i = 1;i<=rows;i++)
                {
                    DrawRow(drawChar, i);
                }
        }
        static int GetNumber(string message)
        {
            Console.Write($"{message}");
            int rows = int.Parse(Console.ReadLine());

            if(rows>0 && rows <=10)
            {
            }

            else
                {
                    Console.WriteLine("invalid number. please pick between 1 and 10");
                    rows = GetNumber(message);
                }
            return rows;
        }
        static char getChar()
        {
            Console.Write("Now for a custom character: ");
            char drawChar = char.Parse(Console.ReadLine());
            return drawChar;
        }
        static void DrawRow(char drawChar, int len)
        {
            for (int i = 0; i < len; i++)
            {
                Console.Write(drawChar);
            }
            Console.Write("\n");
        }

    }
}
