using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence1 = "My name is John Snow.";

            Console.WriteLine(sentence1.Length);    // 21

            var result1 = sentence1.Clone();
            Console.WriteLine(sentence1);             // My name is John Snow.
            Console.WriteLine(result1);               // My name is John Snow.
            sentence1 = "My name is Emilia Clarke.";
            Console.WriteLine(sentence1);             // My name is Emilia Clarke.
            Console.WriteLine(result1);               // My name is John Snow.

            sentence1 = "My name is John Snow.";

            var result2 = sentence1;
            Console.WriteLine(sentence1);             // My name is John Snow.
            Console.WriteLine(result2);               // My name is John Snow.
            sentence1 = "My name is Emilia Clarke.";
            Console.WriteLine(sentence1);             // My name is Emilia Clarke.
            Console.WriteLine(result2);               // My name is John Snow.

            bool result3 = sentence1.StartsWith("l");
            bool result4 = sentence1.EndsWith("l");
            var result5 = sentence1.IndexOf("na");    // Bulamazsa -1 döner
            var result6 = sentence1.IndexOf(" ");
            var result7 = sentence1.LastIndexOf(" ");
            var result8 = sentence1.Insert(0, "Hi ");
            var result9 = sentence1.Substring(3);     // 3. indexten itibaren al
            var result10 = sentence1.Substring(3, 4);     // 3. indexten itibaren 4 karakter al
            var result11 = sentence1.ToLower();
            var result12 = sentence1.ToUpper();
            var result13 = sentence1.Replace(" ", "");
            var result14 = sentence1.Remove(3);   // 3. indexten itibaren at
            var result15 = sentence1.Remove(3, 4);   // 3. indexten itibaren 4 karakteri at

            Console.WriteLine(result15);
            Console.ReadLine();
        }
    }
}
