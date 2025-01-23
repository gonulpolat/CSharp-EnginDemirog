using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;

            number2 = number1;
            number1 = 30;
            Console.WriteLine(number2);   // 10


            string[] cities1 = new string[] { "Ankara", "Adana", "Antalya" };
            string[] cities2 = new string[] { "Balıkesir", "Batman", "Bursa" };

            cities2 = cities1;
            Console.WriteLine("1: {0}", cities1);
            Console.WriteLine("2: {0}", cities2);

            cities1[0] = "Hakkari";

            Console.WriteLine("1: {0}", cities1);
            Console.WriteLine("2: {0}", cities2);


            //DataTable datatable1 = new DataTable();
            DataTable datatable1;        // new'lenmesine gerek yok, zaten aşağıda farklı bir referans veriyorsun
            DataTable datatable2 = new DataTable();
            datatable1 = datatable2;

            Console.ReadLine();
        }
    }
}
