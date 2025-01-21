using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = Add(10, 56);
            Console.WriteLine(result);
            Console.ReadLine();
        }
        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
