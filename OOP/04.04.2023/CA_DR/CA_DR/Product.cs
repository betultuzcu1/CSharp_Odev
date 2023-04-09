using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_DR
{
    internal class Product
    {
        public string UrunAdı{ get; set; }

        public decimal Fiyat { get; set; }

        public decimal KDVFiyat { get { return Fiyat * 1.18m; } }
    }
}
