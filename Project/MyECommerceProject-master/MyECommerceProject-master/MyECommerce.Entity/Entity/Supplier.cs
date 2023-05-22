using MyECommerce.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyECommerce.Entity.Entity
{
    internal class Supplier:BaseEntity
    {
        private static int _idCounter = 0;
        public string CompanyName { get; set; }
        public string ContactName { get; set; }

        public Supplier()
        {
            _idCounter++;
            Id = _idCounter;
        }
    }
}
