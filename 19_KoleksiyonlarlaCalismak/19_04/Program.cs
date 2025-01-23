using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Koleksiyon Methodları

            List<Customer> customers = new List<Customer>
            {
                new Customer(1, "Seren"),
                new Customer(2, "Saliha"),
                new Customer(3, "Seher"),
                new Customer(4, "Serap")
            };


            var c = new Customer(5, "Selen");
            customers.Add(c);


            customers.AddRange(new Customer[2] {new Customer(6, "Serrin"), new Customer(7, "Semiha") });

            // customers.Clear();

            foreach (var customer in customers) { Console.WriteLine(customer.FirstName); };

            var count = customers.Count;
            Console.WriteLine(count);

            Console.WriteLine(customers.Contains(c));  // True
            Console.WriteLine(customers.Contains(new Customer(1, "Seren")));  // False  değerler aynı olsa bile sen yeni bir nesne yarattın






            Console.ReadLine();
            
        }
    }
    class Customer
    {
        private int _id;
        private string _name;
        public Customer(int id, string name)
        {
            _name = name;
            _id = id;
        }
        public int Id 
        {
            get { return _id; }
            set { _id = value; }
        }
        public string FirstName
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
