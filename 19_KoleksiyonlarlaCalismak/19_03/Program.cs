using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bu şekilde string int veri tipleri ile çok çalışılmaz
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("İstanbul");
            // cities.Add(1);

            foreach (string city in cities)
            {
                Console.WriteLine(city);
            }



            // Daha çok class nesnesi verilir
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { Id = 1, FirstName = "Selena" });
            customers.Add(new Customer { Id = 2, FirstName = "Devrim" });

            foreach (Customer customer in customers) { Console.WriteLine(customer.FirstName); }



            List<Customer> customers2 = new List<Customer>
            {
                new Customer { Id = 1, FirstName = "Selena" },
                new Customer { Id = 2, FirstName = "Devrim" },
            };

            Console.ReadLine();
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
