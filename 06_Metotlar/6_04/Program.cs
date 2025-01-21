using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 56;
            int number2 = 23;
            int result = Add(number1, number2);
            Console.WriteLine(result);   // 24
            Console.WriteLine(number1);  // 56

            int number3 = 56;            // number3 ref tanımlandığı için fonksiyon çağırmadan önce ona değer ataman gerekli
            int number4 = 23;
            int r = Add2(ref number3, number4);
            Console.WriteLine(r);        // 24
            Console.WriteLine(number3);  // 1

            Console.ReadLine();
        }
        static int Add(int num1, int num2)
        {
            num1 = 1;
            return num1 + num2;
        }

        static int Add2(ref int num3, int num4)
        {
            num3 = 1;
            return num3 + num4;
        }
    }
}
