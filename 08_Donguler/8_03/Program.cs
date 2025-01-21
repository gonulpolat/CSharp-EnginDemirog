using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 100);


            Console.WriteLine("-------------");


            // Şartı sağlamamasına rağmen bir defa döngüye giriyor
            var num = 10;
            do
            {
                Console.WriteLine(num);
                num++;
            } while (num > 500);



            Console.ReadLine();
        }
    }
}
