﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_03
{
    internal class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql Added!");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Deleted!");
        }

        public void Update()
        {
            Console.WriteLine("Sql Updated!");
        }
    }
}
