using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Value Type --> byte (8 bit)
            byte num = 241;
            Console.WriteLine(num);
            Console.WriteLine(num.GetType());
            Console.WriteLine(byte.MinValue);
            Console.WriteLine(byte.MaxValue);
            Console.ReadLine();
        }
    }
}
