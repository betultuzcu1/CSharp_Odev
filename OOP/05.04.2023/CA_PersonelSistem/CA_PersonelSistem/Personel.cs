using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_PersonelSistem
{
    internal class Personel
    {
        public string  FirstName { get; set; }

        public string LastName { get; set; }

        public decimal Salary { get; set; }

        public string Depertman { get; set; }

        public string TckNo { get; set; }

        public string FullName 
        { 
            get 
            {
                return FirstName + " " + LastName;
            } 
        }

        public virtual decimal Price()
        {     
                return Salary;            
        }
    }
}
