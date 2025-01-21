using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var i = 1;
            while (i<=100)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.WriteLine("Number i is {0} after while loop.",i);
            Console.ReadLine();
        }
    }
}
