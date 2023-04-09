using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Kitaplık
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kitap
            //kitap özellikleri
            //Fiyat
            //KDVDahil
            //Kullancııdan 5 adet kitap oluşturulsun.
            //Oluşturulan kitaplar listeye aktarılsın.
            //liste içerisindeki kitapların özellikleri console da gösterilsin.

            Console.WriteLine("Kitaplık Uygulamasına Hoş Geldiniz");
            Console.ReadLine();
            Console.WriteLine("Lütfen oluşturacağınız kitaplar için açağıdaki bilgileri doldurunuz");
            Console.ReadLine();
            Console.WriteLine("Kitap 1 için gerekli bilgiler:");
            Console.ReadLine();
            Kitap kitap1 = new Kitap();
            Console.Write("Kitap Kategori:");
            kitap1.Kategori = Console.ReadLine();
            Console.Write("Kitap Adı:");
            kitap1.Ad=Console.ReadLine();
            Console.Write("Yazar:");
            kitap1.Yazar = Console.ReadLine();
            Console.Write("Yayınevi:");
            kitap1.Yayınevi = Console.ReadLine();
            Console.Write("Dil:");
            kitap1.Dil = Console.ReadLine();
            Console.Write("Sayfa Sayısı:");
            kitap1.SayfaSayısı =int.Parse(Console.ReadLine());
            Console.Write("Fiyat:");
            kitap1.Fiyat = decimal.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Kitap 2 için gerekli bilgiler:");
            Console.ReadLine();
            Kitap kitap2 = new Kitap();
            Console.Write("Kitap Kategori:");
            kitap2.Kategori = Console.ReadLine();
            Console.Write("Kitap Adı:");
            kitap2.Ad = Console.ReadLine();
            Console.Write("Yazar:");
            kitap2.Yazar = Console.ReadLine();
            Console.Write("Yayınevi:");
            kitap2.Yayınevi = Console.ReadLine();
            Console.Write("Dil:");
            kitap2.Dil = Console.ReadLine();
            Console.Write("Sayfa Sayısı:");
            kitap2.SayfaSayısı = int.Parse(Console.ReadLine());
            Console.Write("Fiyat:");
            kitap2.Fiyat = decimal.Parse(Console.ReadLine());

            Console.WriteLine();


            Console.WriteLine("Kitap 3 için gerekli bilgiler:");
            Console.ReadLine();
            Kitap kitap3 = new Kitap();
            Console.Write("Kitap Kategori:");
            kitap3.Kategori = Console.ReadLine();
            Console.Write("Kitap Adı:");
            kitap3.Ad = Console.ReadLine();
            Console.Write("Yazar:");
            kitap3.Yazar = Console.ReadLine();
            Console.Write("Yayınevi:");
            kitap3.Yayınevi = Console.ReadLine();
            Console.Write("Dil:");
            kitap1.Dil = Console.ReadLine();
            Console.Write("Sayfa Sayısı:");
            kitap3.SayfaSayısı = int.Parse(Console.ReadLine());
            Console.Write("Fiyat:");
            kitap3.Fiyat = decimal.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Kitap 4 için gerekli bilgiler:");
            Console.ReadLine();
            Kitap kitap4 = new Kitap();
            Console.Write("Kitap Kategori:");
            kitap4.Kategori = Console.ReadLine();
            Console.Write("Kitap Adı:");
            kitap4.Ad = Console.ReadLine();
            Console.Write("Yazar:");
            kitap4.Yazar = Console.ReadLine();
            Console.Write("Yayınevi:");
            kitap4.Yayınevi = Console.ReadLine();
            Console.Write("Dil:");
            kitap4.Dil = Console.ReadLine();
            Console.Write("Sayfa Sayısı:");
            kitap4.SayfaSayısı = int.Parse(Console.ReadLine());           
            Console.Write("Fiyat:");
            kitap4.Fiyat = decimal.Parse(Console.ReadLine());

            Console.WriteLine();


            Console.WriteLine("Kitap 5 için gerekli bilgiler:");
            Kitap kitap5 = new Kitap();
            Console.Write("Kitap Kategori:");
            kitap5.Kategori = Console.ReadLine();
            Console.Write("Kitap Adı:");
            kitap5.Ad = Console.ReadLine();
            Console.Write("Yazar:");
            kitap5.Yazar = Console.ReadLine();
            Console.Write("Yayınevi:");
            kitap5.Yayınevi = Console.ReadLine();
            Console.Write("Dil:");
            kitap5.Dil = Console.ReadLine();
            Console.Write("Sayfa Sayısı:");
            kitap5.SayfaSayısı = int.Parse(Console.ReadLine());            
            Console.Write("Fiyat:");
            kitap5.Fiyat = decimal.Parse(Console.ReadLine());

            Console.WriteLine();

            List<Kitap> kitaplik= new List<Kitap>();
            kitaplik.Add(kitap1);
            kitaplik.Add(kitap2);
            kitaplik.Add(kitap3);
            kitaplik.Add(kitap4);
            kitaplik.Add(kitap5);

            Console.WriteLine("********Kitaplık********");
            foreach (Kitap kitap in kitaplik)
            {
                Console.WriteLine($"Kategori:{kitap.Kategori}\nKitap adı: {kitap.Ad}\nYazar:{kitap.Yazar}\nYayınevi:{kitap.Yayınevi}\nDil:{kitap.Dil}\nSayfa Sayısı:{kitap.SayfaSayısı}\nFiyat:{kitap.Fiyat}\n**********");
            }

            Console.ReadLine();
        }
    }
}
