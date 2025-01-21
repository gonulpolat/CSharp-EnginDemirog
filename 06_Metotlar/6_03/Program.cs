using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(12));
            Console.WriteLine(Add(12, 85));
            Console.ReadLine();
        }
        static int Add(int num1, int num2 = 30)
        {
            return num1 + num2;
        }
    }
}
