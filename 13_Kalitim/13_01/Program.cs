using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Kamil";
            customer.LastName = "Han";
            customer.City = "Samsun";

            Student student = new Student();
            student.Id = 2;
            student.FirstName = "Melike";
            student.LastName = "Kara";
            student.Department = "Engineering";


            Person[] people = new Person[2] { new Customer(), new Student() };

            Person[] people1 = new Person[3] { new Customer(), new Student(), new Person() };

            Person[] people2 = new Person[3]
            {
                new Customer{ FirstName="Selin"},
                new Student{ FirstName="Mert"}, 
                new Person{ FirstName="Adil"}
            };

            foreach (var person in people2)
            {
                Console.WriteLine(person.FirstName);
            }


            Console.ReadLine();
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer : Person
    {
        public string City { get; set; }
    }
    class Student : Person
    {
        public string Department { get; set; }
    }
}
