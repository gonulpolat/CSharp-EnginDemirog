using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_03
{
    internal class Customer
    {
        public int Id { get; set; }

        private string _firstName;


        // Implimentasyon detayının gizlenmesi => Encapsulation
        // Kullanımı az
        // Eski tip yazılımlarda çok görebilirsin
        public string FirstName
        {
            get
            {
                return "Mrs. " + _firstName;
            }
            set
            {
                _firstName = value;  // value set ettiğin değer
            }
        }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
