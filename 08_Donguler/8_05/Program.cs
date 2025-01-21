using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bir sayının asal olup olmadığını bulan program

            // Benim Çözüm:
            bool asalMi = true;
            var sayi = 7;
            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    asalMi = false;
                    break;
                }
            }
            Console.WriteLine(asalMi);

            Console.WriteLine(IsPrimeNumber(563));

            Console.ReadLine();
        }

        // Hocanın Çözüm:
        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number; i++)
            {
                if(number% i == 0)
                {
                    result = false;
                    i = number;
                }
            }
            return result;
        }
    }
}
