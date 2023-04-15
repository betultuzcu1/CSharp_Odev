using CA_HamburgerMenu.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_HamburgerMenu.Data
{
    internal class EkstraData
    {
        public static List<Ekstra> ekstraList = new List<Ekstra>()
        {
            new Ekstra{estraAd="1-BBQ", ekstraFiyat = 2m},
            new Ekstra{estraAd="2-Ketçap", ekstraFiyat= 2m},
            new Ekstra{estraAd="3-Mayonez",ekstraFiyat = 3m},
            new Ekstra{estraAd="4-Buffalo",ekstraFiyat = 5m}
        };
    }
}
