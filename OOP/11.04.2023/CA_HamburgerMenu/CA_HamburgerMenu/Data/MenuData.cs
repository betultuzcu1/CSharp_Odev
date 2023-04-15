using CA_HamburgerMenu.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_HamburgerMenu.Data
{
    internal class MenuData
    {
        public static List<Menu> menuList = new List<Menu>()
        {
            new Menu() {UrunAd="Whopper Menu" ,UrunFiyat=105m},
            new Menu() {UrunAd="Big King Menu" ,UrunFiyat=99m},
            new Menu() {UrunAd="CheeseBurger Menu" ,UrunFiyat=75m},
            new Menu() {UrunAd="Steakhouse Burger Menu" ,UrunFiyat=125m}
        };
    }
}
