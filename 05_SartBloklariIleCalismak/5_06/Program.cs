using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nested if
            var num = 50;
            if (num <= 100)
            {
                if (num >= 90)
                {
                    Console.WriteLine("Number is between 90-100.");
                }
            }
            Console.ReadLine();
        }
    }
}
