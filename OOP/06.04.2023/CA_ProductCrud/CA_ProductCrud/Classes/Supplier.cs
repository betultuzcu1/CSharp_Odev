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
        public static int _Idsayac = 0;
        public int _id;

        public Supplier()
        {
            _id = ++_Idsayac;
        }

        public int Id
        {
            get { return _id; }
        }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string PhoneNumber { get; set; }

        public Supplier(string name, string contact , string phone)
        {
            CompanyName = name;
            ContactName = contact;
            PhoneNumber = phone;
            _id = ++_Idsayac;
        }

        public override string ToString()
        {
            return $"Id: {Id} Company: {CompanyName}  Contact: {ContactName}  Phone Number: {PhoneNumber}";
        }




    }
}
