using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_ProductCrud.Classes
{
    internal class Category:BaseClass
    {
        private static int _Idsayac = 0;

        public Category()
        {
            Id = ++_Idsayac;
        }
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}
