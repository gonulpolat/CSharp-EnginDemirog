using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num = 103.5;
            if (num >= 0&& num<=100)
            {
                Console.WriteLine("Number is between 0-100.");
            }
            else if(num>100&& num <= 200)
            {
                Console.WriteLine("Number is between 101-200.");
            }
            else
            {
                Console.WriteLine("Number is less than 0 or greater than 200.");
            }
            Console.ReadLine();
        }
    }
}
