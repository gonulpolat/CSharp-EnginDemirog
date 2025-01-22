using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Şirketin verilerini hem Sql veri tabanına hem Oracle hem de MySql veri tabanına yazma işlemi

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MySqlCustomerDal()
            };

            foreach (var customerDal in customerDals) { customerDal.Add(); }



            Console.ReadLine();
        }
    }
}
