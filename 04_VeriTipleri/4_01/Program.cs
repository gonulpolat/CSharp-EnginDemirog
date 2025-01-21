using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Value Type --> int (32 bit)
            int num = 8962;
            Console.WriteLine(num);
            Console.WriteLine(num.GetType());
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);
            Console.ReadLine();
        }
    }
}
