using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kendi hata sınıfını yaz

            //Find();


            // frontend
            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }

            Console.ReadLine();
        }

        private static void Find()
        {
            // backend
            List<string> students = new List<string> { "Eren", "Ecrin", "Esin" };
            if (!students.Contains("Ahmet"))
            {
                throw new RecordNotFoundException("Record Not Found!");
            }
            else
            {
                Console.WriteLine("Record Found!");
            }
        }
    }
}
