using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num = 5;
            switch (num)
            {
                case 10:
                    Console.WriteLine("Number is 10");
                    break;
                case 20:
                    Console.WriteLine("Number is 20.");
                    break;
                default:
                    Console.WriteLine("Number is not 10 or 20.");
                    break;
            }
            Console.ReadLine();
        }
    }
}
