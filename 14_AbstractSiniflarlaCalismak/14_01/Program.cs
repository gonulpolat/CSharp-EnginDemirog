using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ABSTRACT CLASS --> İçi dolu olmayan virtual method

            Database d1 = new SqlServer();
            Database d2 = new Oracle();
            d1.Add();
            d1.Delete();
            d2.Add();
            d2.Delete();


            Console.ReadLine();
        }
    }
    abstract class Database
    {
        // ekleme işlemi heryerde aynı, silme işlemi heryerde farklı
        public void Add()                 // TAMAMLANMIŞ METHOD
        {
            Console.WriteLine("Added by default!");
        }
        public abstract void Delete();    // TAMAMLANMAMIŞ METHOD
    }
    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Sql Server!");
        }
    }
    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Oracle!");
        }
    }
}
