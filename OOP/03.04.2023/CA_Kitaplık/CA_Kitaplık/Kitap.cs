using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Kitaplık
{
    internal class Kitap
    {
        public string Kategori { get; set; }

        public string Ad { get; set; }

        public string Yazar { get; set; }

        public string Yayınevi { get; set; }

        public string Dil { get; set; }

        public int SayfaSayısı { get; set; }

        public decimal Fiyat { get; set; }

        public decimal KdvDahilFiyat { get { return Fiyat * 1.18m; } }

        
    }
}
