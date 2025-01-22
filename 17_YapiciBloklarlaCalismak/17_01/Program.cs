using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.List();

            StudentManager studentManager = new StudentManager(5);
            studentManager.List();

            ClientManager clientManager = new ClientManager();
            ClientManager clientManager1 = new ClientManager(5);

            Console.ReadLine();
        }
    }
    class CustomerManager
    {
        public CustomerManager()
        {

        }
        internal void List()
        {
            Console.WriteLine("Listed!");
        }
        internal void Add()
        {
            Console.WriteLine("Added!");
        }
    }
    class StudentManager
    {
        private int _count;
        public StudentManager(int count)
        {
            _count = count;
        }
        internal void List()
        {
            for (int i = 1; i <= _count; i++)
            {
                Console.WriteLine("{0}. item listed!", i);
            }
        }
    }
    class ClientManager
    {
        private int _count = 10;
        public ClientManager()
        {

        }
        public ClientManager(int count)
        {
            _count = count;
        }
    }
}
