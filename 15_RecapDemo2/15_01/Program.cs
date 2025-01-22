using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Logger = new FileLogger();                // property injection (normalde constructor ile yapılır)
            customerManager.Add();

            CustomerManager c1 = new CustomerManager();
            c1.Logger = new SmsLogger();
            c1.Add();


            Console.ReadLine();
        }
    }
}
