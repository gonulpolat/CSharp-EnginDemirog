using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Customer
    {
        int id;  // default --> private
        protected string name;

        public void Save()
        {
            id = 1;
            name = "Test";
        }
    }
    class Student
    {
        public void Save()
        {
            Customer c = new Customer();
            
        }
    }

    class Client : Customer
    {
        public void Add()
        {
            name = "Test";  // protected olduğu için
        }
    }
}
