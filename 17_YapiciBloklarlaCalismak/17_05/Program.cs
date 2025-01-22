using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher.Number = 10;

            Utilities.Validate();



            Manager.DoSomething();  // metot static olduğu için instance üretmeden direkt kullanabilirsin

            Manager manager = new Manager();
            manager.DoSomething2();



            Console.ReadLine();
        }
    }
    static class Teacher
    {
        public static int Number { get; set; }
    }
    static class Utilities
    {
        // Genelde validation (doğrulama) teknikleri için kullanılır

        public static void Validate()
        {
            Console.WriteLine("Validation is done!");
        }

    }
    class Manager
    {
        public static void DoSomething()
        {
            Console.WriteLine("Done");
        }
        public void DoSomething2()
        {
            Console.WriteLine("Done 2");
        }
    }
    static class Student
    {
        static Student()
        {
            
        }
    }
}
