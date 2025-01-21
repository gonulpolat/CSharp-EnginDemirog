using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1, 2, 3, 4, 5));   // 15
            Console.WriteLine(Add());                // 0

            Console.WriteLine(Add2(1, 2, 3, 4, 5));  // 15
            Console.WriteLine(Add2(1));              // 1

            Console.ReadLine();
        }
        static int Add(params int[] numbers)
        {
            return numbers.Sum();
        }
        static int Add2(int number, params int[] numbers)
        {
            return number + numbers.Sum();
        }
    }
}
