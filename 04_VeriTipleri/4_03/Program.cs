using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Value Type --> short (16 bit)
            short num = 895;
            Console.WriteLine(num);
            Console.WriteLine(num.GetType());
            Console.WriteLine(short.MinValue);
            Console.WriteLine(short.MaxValue);
            Console.ReadLine();
        }
    }
}
