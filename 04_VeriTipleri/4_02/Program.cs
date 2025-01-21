using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Value Type --> long (64 bit)
            long num = 895946462;
            Console.WriteLine(num);
            Console.WriteLine(num.GetType());
            Console.WriteLine(long.MinValue);
            Console.WriteLine(long.MaxValue);
            Console.ReadLine();
        }
    }
}
