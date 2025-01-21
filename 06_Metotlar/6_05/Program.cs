using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 56;  // altı noktalı zaten değer atamana gerek yok, tanımlasan yeter
            int number2 = 23;
            int result = Add(out number1, number2);
            Console.WriteLine(result);   // 24
            Console.WriteLine(number1);  // 1


            Console.ReadLine();
        }
        static int Add(out int num1, int num2)
        {
            num1 = 1;
            return num1 + num2;
        }
    }
}
