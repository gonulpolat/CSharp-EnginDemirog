using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_05
{
    internal class Robot : IWorker
    {
        public void Eat()
        {
            // SORUN --> Robot yemek yemez
            // bir çözüm olarak fonksiyonun içini boş bırakabilirsin
            // diğer çözüm ise farklı interfaceler tanımlamak (12_05_1 içinde olduğu gibi)
        }

        public void GetSalary()
        {
            // Aynı sorun geçerli
        }

        public void Work()
        {
            
        }
    }
}
