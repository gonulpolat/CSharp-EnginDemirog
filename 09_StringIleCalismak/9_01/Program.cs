using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = "Manisa";
            Console.WriteLine(city[0]);
            Console.WriteLine((int)city[0]);

            foreach (var item in city) { Console.WriteLine(item); }

            string city2 = "Hatay";
            string result = city + " " + city2;

            Console.WriteLine(result);

            Console.WriteLine(String.Format("{0} {1}", city, city2));

            Console.WriteLine("{0} {1}", city, city2);

            Console.ReadLine();
        }
    }
}
