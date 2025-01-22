using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_01
{
    internal class CustomerManager
    {
        public ILogger Logger { get; set; }

        public void Add()
        {
            //DatabaseLogger logger = new DatabaseLogger();
            //logger.Log();


            Logger.Log();



            Console.WriteLine("Customer Added!");
        }
    }
}
