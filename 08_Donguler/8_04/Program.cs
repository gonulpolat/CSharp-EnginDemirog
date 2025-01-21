using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[5] { "Selin", "Merve", "Seda", "Elif", "Hayriye" };

            foreach (string name in names) { Console.WriteLine(name); }

            Console.ReadLine();
        }
    }
}
