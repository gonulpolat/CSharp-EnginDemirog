using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { Id=1, FirstName="Ali"});   // Add --> en sona ekler
            customers.Add(new Customer { Id=2, FirstName="Akif"});
            customers.Add(new Customer { Id=3, FirstName="Ayşe"});
            customers.Add(new Customer { Id=4, FirstName= "Anıl" });

            Customer c = new Customer { Id = 5, FirstName = "Hakan" };
            customers.Add(c);
            customers.Add(c);
            customers.Add(c);
            customers.Add(c);
            customers.Add(c);

            Console.WriteLine(customers.IndexOf(c));
            Console.WriteLine(customers.LastIndexOf(c));

            Customer c1 = new Customer { Id = 6, FirstName = "Melike" };
            customers.Insert(2, c1);

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }

            customers.Remove(c);  // Remove --> Bulduğu ilk değeri siler


            Console.WriteLine("--------------");

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }

            customers.RemoveAll(custom=>custom.FirstName=="Hakan");  // RemoveAll --> Hepsini siler


            Console.WriteLine("--------------");

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }

            Console.ReadLine();
        }
    }
    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
