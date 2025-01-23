using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Manisa");
            cities.Add("Hakkari");


            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            cities.Add(56);
            cities.Add('k');

            Console.WriteLine(cities[3]);
            Console.WriteLine(cities[4]);



            Console.ReadLine();
        }
    }
}
