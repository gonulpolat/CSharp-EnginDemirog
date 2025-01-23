using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // action delegasyonu

            HandleException(() => 
            {
                Find();
            });


            Console.ReadLine();
        }

        private static void HandleException(Action value)   // Genelde merkezi bir class içine konur, ordan çağrılır
        {
            try
            {
                value.Invoke();
            }
            catch (Exception exception)
            {

                Console.WriteLine(exception.Message);
            }
        }

        private static void Find()
        {
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
