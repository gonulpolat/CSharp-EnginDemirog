using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Çok Boyutlu Diziler (multidimensional)

            string[,] regions = new string[7, 3] {  // 7 satır 3 kolon
                {"İstanbul", "Çanakkale", "Tekirdağ"},
                {"Manisa", "Aydın", "Denizli"},
                {"Ankara", "Konya", "Çankırı"},
                {"Samsun", "Sinop", "Tokat"},
                {"Van", "Erzurum", "Ağrı"},
                {"Mardin", "Diyarbakır", "Hakkari"},
                {"Antalya", "Hatay", "Adana"}
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("------------------------");
            }

            Console.ReadLine();
        }
    }
}
