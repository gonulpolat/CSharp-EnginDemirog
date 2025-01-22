using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonManager personManager1 = new PersonManager();
            personManager1.Add(new Customer { Id = 1, FirstName = "Ela", LastName = "Işıl", Address = "12. Sokak" });



            PersonManager personManager2 = new PersonManager();
            Customer c1 = new Customer
            {
                Id = 2,
                FirstName = "Selin",
                LastName = "Gün",
                Address = "Madi Mah."
            };
            personManager2.Add(c1);



            PersonManager personManager3 = new PersonManager();
            personManager3.Remove(new Customer { Id = 3, FirstName = "Hicran", LastName = "Kalın", Address = "Antalya" });
            personManager3.Remove(new Student { Id = 4, FirstName = "Ayşe", LastName = "Yılmaz", Departmant = "Computer Science" });

            Console.ReadLine();
        }
    }

    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
    class PersonManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " added.");
        }
        public void Remove(IPerson person)
        {
            Console.WriteLine(person.FirstName + " deleted.");
        }
    }

}
