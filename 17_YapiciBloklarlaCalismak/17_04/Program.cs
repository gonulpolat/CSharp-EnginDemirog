﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonManager personManager = new PersonManager("Product");
            personManager.Add();

            Console.ReadLine();
        }
    }
    class BaseClass
    {
        private string _entity;
        public BaseClass(string entity)
        {
            _entity = entity;
        }
        public void Message()
        {
            Console.WriteLine("{0} message", _entity);
        }
    }
    class PersonManager : BaseClass
    {
        public PersonManager(string entity):base(entity)
        {
            
        }
        public void Add()
        {
            Console.WriteLine("Added!");
            Message();
        }
    }
}
