using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Method Overloading
            Console.WriteLine(Multiply(2, 5));
            Console.WriteLine(Multiply(2, 5, 4));
            Console.ReadLine();
        }

        static int Multiply(int num1, int num2) { return num1 * num2; }
        static int Multiply(int num1, int num2, int num3) { return num1 * num2 * num3; }
    }
}
