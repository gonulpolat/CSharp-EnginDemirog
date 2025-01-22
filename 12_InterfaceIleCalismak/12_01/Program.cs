using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.ReadLine();
        }
    }

    interface IPerson  // soyut nesne (tek başına hiçbir anlamı yok)
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    class Customer : IPerson     // somut nesne
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }    // Sadece Customer'a ait özellik
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }   // Sadece Student'a ait özellik
    }
}
