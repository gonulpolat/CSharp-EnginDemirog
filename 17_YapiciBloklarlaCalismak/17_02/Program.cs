using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();
            p1.Id = 1;
            p1.Name = "Eda";

            Product p2 = new Product { Id = 2,Name="Gül" };

            Product p3 = new Product(3, "Jale");

            Product p4 = new Product();

            Console.ReadLine();
        }
    }
    class Product
    {

        public Product()
        {
            
        }


        private int _id;
        private string _name;
        public Product(int id, string name)
        {
            _id = id;
            _name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
