using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CA_ProductCrud.Classes
{
    internal class Product : BaseClass
    {
        public static int _Idsayac = 0;
        public int _id;

        public Product()
        {
            _id = ++_Idsayac;
        }

        public int Id
        {
            get { return _id; }
        }
        
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }

        public Product(string name, decimal price,short stock)
        {
            ProductName = name;            
            UnitPrice = price;
            UnitsInStock = stock;
            _id = ++_Idsayac;
        }

        public override string ToString()
        {
            return $"Id: {Id} Product: {ProductName}  Price: {UnitPrice}  Stock: {UnitsInStock}";
        }
    }
}
