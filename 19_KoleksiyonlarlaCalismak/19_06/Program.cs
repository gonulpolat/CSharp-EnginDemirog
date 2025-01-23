using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_06
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Dictionary

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book", "kitap");
            dictionary.Add("table", "tablo");
            dictionary.Add("computer", "bilgisayar");

            Console.WriteLine(dictionary["computer"]);
            //Console.WriteLine(dictionary["glass"]);   // System.Collections.Generic.KeyNotFoundException: 'Verilen anahtar sözlükte yoktu.'

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Value);
            }

            Console.WriteLine(dictionary.ContainsKey("glass"));  // False
            Console.WriteLine(dictionary.ContainsKey("table"));  // True


            Console.ReadLine();
        }
    }
}
