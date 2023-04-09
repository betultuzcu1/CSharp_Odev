using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_odevToplam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Uygulama ana ekranına hoş geldiniz.Lütfen aşağıdan gitmek istediğiniz menüyü seçiniz");
                Console.ReadLine();
                Console.WriteLine("1-Zar Atma Oyunu\n2-Sayısal Loto\n3-Tahmin Et\n4-MacAdam\n5-Bakiye Sorgulama");
                Console.Write("Menü seçimi:");
                string menuSecim = Console.ReadLine();
                switch (menuSecim)
                {
                    case "1":
                        ZarAtma();
                        break;
                    case "2":
                        SayısalLoto();
                        break;
                    case "3":
                        TahminEt();
                        break;
                    case "4":
                        MacAdam();
                        break;
                    case "5":
                        Bakiyeİslemleri();
                        break;
                    default:
                        Console.WriteLine("Lütfen geçerli bir menü seçiniz");
                        break;
                }
                break;
            }
            
            Console.ReadLine();
        }

        static void ZarAtma() 
        {
            Console.WriteLine("Zar Atma ekranına hoş geldiniz.Oyuna başlamak için lütfen enter'a basınız!");
            Console.ReadLine();
            Console.Write("Lütfen birinci oyuncunun adını giriniz:");
            string oyuncuBirAd= Console.ReadLine();
            Console.Write("Lütfen ikinci oyuncu adının adını giriniz:");
            string oyuncuİkiAd= Console.ReadLine();
            try
            {
                while(true)
                {
                    Console.Write($"{oyuncuBirAd} lütfen bir puan giriniz:");
                    int oyuncuBirPuan = int.Parse(Console.ReadLine());
                    if (oyuncuBirPuan < 0)
                    {
                        Console.WriteLine("Lütfen geçerli bir puan giriniz");
                    }
                    else
                    {
                        Console.Write($"{oyuncuİkiAd} lütfen bir puan giriniz:");
                        int oyuncuİkiPuan = int.Parse(Console.ReadLine());
                        if (oyuncuİkiPuan < oyuncuBirPuan)
                        {
                            Console.WriteLine("Lütfen birinci oyuncudan daha büyük bir puan giriniz!");
                        }
                        else
                        {
                            Console.WriteLine($"{oyuncuBirAd} zar atması bekleniyor");
                            Random rnd = new Random();
                            int oyuncuBirZar = rnd.Next(1, 7);
                            Console.WriteLine($"{oyuncuBirAd} atılan zar: {oyuncuBirZar}");
                            Console.WriteLine($"{oyuncuİkiAd} zar atması bekleniyor");
                            int oyuncuİkiZar = rnd.Next(1, 7);
                            Console.WriteLine($"{oyuncuİkiAd} atılan zar: {oyuncuİkiZar}");
                            int toplamPuan = oyuncuBirPuan + oyuncuİkiPuan;
                            if (oyuncuBirZar == oyuncuİkiZar)
                            {
                                Console.WriteLine("Oyun beraabere,lütfen tekrar zar atınız");
                            }
                            else if (oyuncuBirZar < oyuncuİkiZar)
                            {
                                Console.WriteLine($"{oyuncuİkiAd} tebrikler. {toplamPuan} puan kazandınız!! ");
                            }
                            else
                            {
                                Console.WriteLine($"{oyuncuBirAd} tebrikler. {toplamPuan} puan kazandınız!!");
                            }
                            break;
                        }
                    }
                   
                }


            }
            catch (Exception ex) 
            { 
                Console.WriteLine(ex.Message); 
            }
            
        }

        static void Bakiyeİslemleri()
        {
            Console.WriteLine("Bakiye sorgulama ekranına hoş geldiniz.Devam edebilmek için lütfen giriş yapınız!");
            Console.ReadLine();
            
            while (true)
            {
                Console.Write("Kullanıcı adı:");
                string kullanıcıAdı = Console.ReadLine();
                if (kullanıcıAdı == "bilgeadam")
                {
                    Console.Write("şifre:");
                    string kullanıcıSifre= Console.ReadLine();
                    if (kullanıcıSifre == "1234")
                    {
                        int bakiye = 1000;
                        Console.WriteLine($"Merhaba {kullanıcıAdı} bakiye sorgulama ekranına hoş geldin.Lütfen aşağıdaki menüden yapmak istediğiniz işlemi seçiniz!");
                        Console.WriteLine("1-Bakiye Görüntüleme\n2-Para Yatırma\n3-Para Çekme");
                        string islemSecim= Console.ReadLine();
                        switch (islemSecim)
                        {
                            case "1":
                                Console.WriteLine($"Bakiye sorgulama ekranına hoş geldiniz.Mevcut bakiyeniz: {bakiye}");
                                break;
                            case "2":
                                Console.WriteLine("Para yatırma ekranına hoş geldiniz.Lütfen yatırılacak miktarı giriniz:");
                                int yatırılacakMiktar=int.Parse( Console.ReadLine() );
                                try
                                {
                                    Console.WriteLine("İşleminiz gerçekleştiriliyor.Lütfen bekleyiniz..");
                                    bakiye += yatırılacakMiktar;
                                    Console.WriteLine($"işleminiz tamamlandı.Mevcut bakiyeniz:{bakiye} ");
                                }catch (Exception e)
                                {
                                    Console.WriteLine(e.Message); 
                                }
                                break;
                            case "3":
                                Console.WriteLine("Para çekme ekranına hoş geldiniz.Lütfen çekilecek para miktarını giriniz:");
                                int cekilecekMiktar=int.Parse ( Console.ReadLine() );
                                try
                                {
                                    if (cekilecekMiktar > bakiye)
                                    {
                                        Console.WriteLine("Yeterli bakiyeniz bulunmamaktadır.");
                                    }
                                    else if (cekilecekMiktar < 0)
                                    {
                                        Console.WriteLine("Lütfen geçerli bir değer giriniz");
                                    }
                                    else
                                    {
                                        Console.WriteLine("İşleminiz gerçekleştiriliyor.Lütfen bekleyiniz");
                                        bakiye -= cekilecekMiktar;
                                        Console.WriteLine($"İşleminiz tamamlandı.Mevcut bakiyeniz: {bakiye}");
                                    }
                                }
                                catch (Exception ee)
                                {
                                    Console.WriteLine(ee.Message);
                                }
                                break;
                            default:
                                Console.WriteLine("Lütfen geçerli bir menü giriniz!");
                                break;
                        }
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Şifre hatalı,lütfen tekrar deneyiniz!");
                    }
                }
                else
                {
                    Console.WriteLine("Kullanıcı bulunamadı.Lütfen tekrar deneyiniz!");
                }


            }
        }

        static void TahminEt()
        {
            Console.WriteLine("Tahmin et oyununa hoş geldiniz.Devam etmek için lütfen enter'a basınız.");
            Console.ReadLine();
            int seviye = 1;
            int tahminHakkı = 5;
            int tahmin;
            Random rnd = new Random();
            try
            {
                while (seviye <= 10)
                {
                    Console.WriteLine($"Seviye : {seviye}");
                    Console.ReadLine();
                    int tahminAralığı = (seviye * 10);
                    int TutulanSayı = rnd.Next(1, tahminAralığı + 1);

                    while (tahminHakkı > 0)
                    {
                        Console.WriteLine($"Lütfen 1 ile {tahminAralığı} arasında bir sayı giriniz :");
                        tahmin = int.Parse(Console.ReadLine());
                        if (tahmin < 0)
                        {
                            Console.WriteLine("Lütfen geçerli bir sayı giriniz..");
                        }
                        else if (tahmin > tahminAralığı)
                        {
                            Console.WriteLine($"Lütfen 1 ile {tahminAralığı} arasında bir sayı girinz");
                        }
                        else
                        {
                            if (TutulanSayı < tahmin)
                            {
                                Console.WriteLine("Lütfen daha küçük bir sayı giriniz!");
                                tahminHakkı--;
                            }
                            else if (TutulanSayı > tahmin)
                            {
                                Console.WriteLine("Lütfen daha büyük bir sayı giriniz!");
                                tahminHakkı--;
                            }
                            else
                            {
                                Console.WriteLine("Tebrikler!Doğru tahmin.");
                                tahminHakkı = 5;
                                seviye++;
                                Console.Beep(369, 200); Console.Beep(369, 200); Console.Beep(369, 200); Console.Beep(293, 200);
                                Console.Beep(246, 200); Console.Beep(329, 200); Console.Beep(329, 200); Console.Beep(329, 200);
                                Console.Beep(415, 200); Console.Beep(415, 200); Console.Beep(440, 200); Console.Beep(493, 200);
                                Console.Beep(440, 200); Console.Beep(440, 200); Console.Beep(440, 200); Console.Beep(329, 200);
                                Console.Beep(293, 200);

                                break;
                            }
                            if (tahminHakkı == 0)
                            {
                                Console.WriteLine($"Tahmin hakkınız bitti.Tutulan sayı : {TutulanSayı} ");
                                tahminHakkı = 5;
                            }

                            Console.WriteLine($"Kalan tahmin hakkınız : {tahminHakkı}");
                        }
                    }
                }
                Console.WriteLine("Tebrikler!Tüm seviyeleri başarı ile geçtiniz.Oyun bitti.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        static void SayısalLoto() 
        {
            Console.WriteLine("Sayısal Loto ekranına hoş geldiniz.Devam etmek için lütfen enter'a basınız!");
            Console.ReadLine();
            int[] sayilar=new int[6];
            Random rnd = new Random();
            for (int z=0; z<8; z++)
            {
                for (int i = 0; i < 6; i++)
                {
                    int rndNumber = rnd.Next(1, 50);
                    sayilar[i] = rndNumber;
                    for (int j = 0; j < i; j++)
                    {
                        if (sayilar[i] == sayilar[j])
                        {
                            i--;
                            continue;
                        }
                    }
                }
               
                foreach (int sayi in sayilar)
                {
                    Console.Write(sayi + " ");
                }
                Console.WriteLine();
               
                Console.WriteLine("********");
            }

        }

        static void MacAdam()
        {
            string[] menu = { "1-Whooper ", "2-Bigmac ", "3-McChicken", "4-Texas Smoke House", "5-BerkeninOzelBurgeri" };
            decimal[] fiyatlar = { 70, 65, 55, 85, 110 };
            string[] ekstra = { "1-Ketçap", "2-Mayonez", " 3-BBQ", "4-Buffalo " };
            decimal[] ekstraFiyat = { 2.5m, 2, 2, 2.5m };

            while (true)
            {

                for (int i = 0; i < menu.Length; i++)
                {
                    Console.WriteLine($"{menu[i]} {fiyatlar[i]} TL");
                }




                Console.WriteLine("bir menü seçin:");
                try
                {
                    int secilenMenu = int.Parse(Console.ReadLine());
                    if (secilenMenu - 1 > menu.Length)
                    {
                        Console.WriteLine($"lütfen 0 ile {menu.Length} arasında bir değer girin");
                    }
                    else
                    {
                        //Menü seçimi

                        string gelenMenu = menu[secilenMenu - 1];
                        decimal fiyat = fiyatlar[secilenMenu - 1];

                        //Adet 
                        Console.WriteLine("Adet: ");
                        int adet = int.Parse(Console.ReadLine());


                        //ekstra seçimi
                        Console.WriteLine("Ekstra seçmek ister misin?(E/H)");
                        string cevap = Console.ReadLine().ToLower();
                        switch (cevap)
                        {
                            case "e":
                                Console.WriteLine("1-Ketçap (2.5 TL)\n2-Mayonez (2)\n3-BBQ (2)\n4-Buffalo (2.5)\nLütfen bir ekstra seçiniz:");
                                string gelenEkstra = Console.ReadLine().ToLower();
                                gelenEkstra = ekstra[ekstra.Length - 1];
                                decimal gelenekstraFiyat = ekstraFiyat[ekstra.Length - 1];
                                Console.WriteLine("Adet: ");
                                int adet2 = int.Parse(Console.ReadLine());
                                Console.WriteLine("Toplam Sipariş Bedeli");
                                Console.WriteLine($"Toplam Sipariş bedeli {gelenekstraFiyat * adet2 + fiyat * adet} TL");
                                //Sipariş Bilgisi

                                Kullanıcı();
                                Console.WriteLine($"Sipariş Özeti: Siparişiniz alınmıştır. Ortalama teslimat süresi 40 dk. Menu:{gelenMenu} Adet: {adet} Ekstra:{gelenEkstra} Adet: {adet2} Toplam Tutar: {fiyat * adet + gelenekstraFiyat * adet2} TL ");

                                break;
                            case "h":
                                Kullanıcı();
                                Console.WriteLine($"Sipariş Özeti: Siparişiniz alınmıştır. Ortalama teslimat süresi 40 dk. Menu:{gelenMenu} Adet: {adet} Toplam Tutar: {fiyat * adet} TL ");
                                break;
                            default:
                                Console.WriteLine("Lütfen E/H şeklinde seçim yapınız!");
                                break;
                        }

                        Console.WriteLine("Siparişi devam ettirmek için 'd' tuşuna basın, sonlandırmak için herhangi bir tuşa basın...");
                        string devam = Console.ReadLine();
                        if (devam.ToLower() != "d")
                        {
                            break;
                        }



                    }



                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.ToString());
                }

            }
        }
        static void Kullanıcı()
        {
            Console.WriteLine("Adınız: ");
            string ad = Console.ReadLine();
            Console.WriteLine("Soyadınız: ");
            string soyad = Console.ReadLine();
            Console.WriteLine($"Kullanıcı Bilgileri: {ad} {soyad}");
        }

    }
}
