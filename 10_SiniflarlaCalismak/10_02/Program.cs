using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Way:
            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Selin";   // set bloğu çalışıyor
            customer.LastName = "Kara";
            customer.City = "Hatay";
            customer.Address = "Hatay/ Karaburun";


            // 2. Way:
            Customer customer2 = new Customer { Id = 2, FirstName = "Derin", LastName = "Yılan", City = "Sivas" };

            Console.WriteLine(customer2.FirstName);

            Console.ReadLine();
        }
    }
}
