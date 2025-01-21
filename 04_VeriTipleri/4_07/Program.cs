using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Value Type --> double (64 bit)
            double num1 = 26597464;
            double num2 = 26597464.65262;
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);
            Console.ReadLine();
        }
    }
}
