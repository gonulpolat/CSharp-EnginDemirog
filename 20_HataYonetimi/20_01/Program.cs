using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3]
            {
                "Devran", "Devrim","Deren"
            };

            //students[3] = "Ahmet";  // System.IndexOutOfRangeException: 'Dizin, dizi sınırlarının dışındaydı.'

            //HataYonetimi1(students);

            //HataYonetimi2(students);

            //HataYonetimi3(students);

            //HataYonetimi4(students);

            try
            {
                students[3] = "Caner";
            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }



            Console.ReadLine();
        }

        private static void HataYonetimi4(string[] students)
        {
            try
            {
                students[3] = "Selen";
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void HataYonetimi3(string[] students)
        {
            try
            {
                students[3] = "Melike";
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.InnerException);  // varsa daha detaylı bilgi döner
            }
        }

        private static void HataYonetimi2(string[] students)
        {
            try
            {
                students[3] = "Semih";
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);   // Dizin, dizi sınırlarının dışındaydı.       normalde kullanıcıya göstermek yerine veri tabanına loglarız
            }
        }

        private static void HataYonetimi1(string[] students)
        {
            try
            {
                students[3] = "Ahmet";
            }
            catch (Exception)
            {
                Console.WriteLine("EXCEPTION!");
            }
        }
    }
}
