using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CA_HamburgerMenu.Data;
using CA_HamburgerMenu.Model;

namespace CA_HamburgerMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hamburger Uygulamasına Hoşgeldiniz.");
            Console.WriteLine("Lütfen aşağıdan bir menü seçiniz!");
            Console.WriteLine(Menu.HamburgerMenu());
            Console.Write("Menü seçimi:");
            string secim=Console.ReadLine();
            string secilenMenu = Menu.MenuSecim(secim);
            Console.WriteLine("Ekstra seçimini yapınız!");
            Console.WriteLine(Ekstra.EkstraMenu());
            string secimEstra=Console.ReadLine();
            string secilenEkstra=Ekstra.EkstraSecim(secimEstra);

            Console.ReadLine();
        }
    }
}
