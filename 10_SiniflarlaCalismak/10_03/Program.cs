using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id = 1, FirstName="Sema", LastName="Yılmaz", City="Van" };

            Console.WriteLine(customer.FirstName);

            Console.ReadLine();
        }
    }
}
