using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            sqlServer.Delete();

            MySql mySql = new MySql();
            mySql.Add();
            mySql.Delete();


            Console.ReadLine();
        }
    }
    class Database
    {
        public virtual void Add() { Console.WriteLine("Added by default!"); }
        public virtual void Delete() { Console.WriteLine("Deleted by default!"); }
    }

    class SqlServer : Database
    {
        public override void Add()
        {
            base.Add();  // defalut değer --> base classındaki işlemleri gerçekleştirir
        }

        public override void Delete()
        {
            //base.Delete();
            Console.WriteLine("Added by Sql Server!");
        }
    }
    class MySql : Database
    {
        public override void Add()
        {
            Console.WriteLine("MySql Added!");
            base.Add();
        }

    }
}
