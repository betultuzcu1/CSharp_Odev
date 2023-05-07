using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    internal class MenuSecim
    {
        public static void MenuSecimi() 
        {
            Console.Write("Lütfen menü seçiniz:");
            int secim=int.Parse(Console.ReadLine());    
            switch(secim)
            {
                case 1:
                    Mesassage.UrunMesaj();
                    UrunMenu.Urun();
                    break;
                default: Console.WriteLine("Geçerli Menü seçiniz");
                    break;
            }
        }
    }
}
