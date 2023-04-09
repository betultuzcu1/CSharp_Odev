using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_ProductCrud.Classes
{
    internal class Supplier:BaseClass
    {
        private static int _Idsayac = 0;

        public Supplier()
        {
            Id = ++_Idsayac;
        }
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string PhoneNumber { get; set; }


       

    }
}
