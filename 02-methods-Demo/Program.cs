using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_methods_Demo
{
    class Program
    {

        static void printIt(String myString){
            Console.WriteLine($"Hey my string is: {myString}");
        }


        static int add(int n1, int n2){
            return n1 + n2;
        }

        static void Main()
        {
            String s;
            printIt(add(3,3).ToString());
        }
    }
}
