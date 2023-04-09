using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CA_ProductCrud.Classes
{
    internal class Category:BaseClass
    {
        public static int _Idsayac = 0;
        public int _id;

        public Category()
        {
            _id = ++_Idsayac;
        }

        public int Id
        {
            get { return _id; }
        }
        public string CategoryName { get; set; }
        public string Description { get; set; }

        public Category(string name, string description)
        {
            CategoryName = name;
            Description = description;
            _id = ++_Idsayac;
        }

        public override string ToString()
        {
            return $"Id: {Id} Category: {CategoryName} ({Description})";
        }
    }
}
