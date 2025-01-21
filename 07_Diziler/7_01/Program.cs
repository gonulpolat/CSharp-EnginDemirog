using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array kullanmadan
            //string student1 = "Gamze";
            //string student2 = "Ela";
            //string student3 = "Sena";

            // 1. Way:
            string[] students = new string[3];
            students[0] = "Gamze";
            students[1] = "Ela";
            students[2] = "Sena";

            // 2. Way:
            string[] students1 = new [] {"Gamze", "Ela", "Sena" };

            // 3. Way:
            string[] students2 = { "Gamze", "Ela", "Sena" };

            // 4. Way:
            string[] students3 = new string[3]{ "Gamze", "Ela", "Sena" };


            foreach (string s in students3)
            {
                Console.WriteLine(s);
            }

            Console.ReadLine();
        }
    }
}
