using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Value Type --> decimal (128 bit)
            decimal num1 = 26597464;
            decimal num2 = 26597464.65262m;
            decimal num3 = 26597464.65262M;
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            Console.WriteLine(decimal.MinValue);
            Console.WriteLine(decimal.MaxValue);
            Console.ReadLine();
        }
    }
}
