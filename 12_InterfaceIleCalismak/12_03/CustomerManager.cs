using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_03
{
    internal class CustomerManager
    {
        public void Add(ICustomerDal customerDal)  // normalde parametre verilmez, constructordan alınır
        {
            customerDal.Add();
        }
        public void Delete(ICustomerDal customerDal)
        {
            customerDal.Delete();
        }
        public void Update(ICustomerDal customerDal)
        {
            customerDal.Update();
        }
    }
}
