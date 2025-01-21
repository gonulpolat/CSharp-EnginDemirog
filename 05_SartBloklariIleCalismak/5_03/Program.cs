using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num = 4;
            if (num == 10)
            {
                Console.WriteLine("Number is 10.");
            }
            else if (num == 20)
            {
                Console.WriteLine("Number is 20.");
            }
            else
            {
                Console.WriteLine("Number is not 10 or 20.");
            }
            Console.ReadLine();
        }
    }
}
