using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_DR
{
    internal class Program
    {   static void Main(string[] args)
        {
            Roman roman = new Roman();
            roman.UrunAdı = "Gece Yarısı Kütüphanesi";
            roman.Yazar = "Matt Haig";
            roman.YayınEvi = "Domingo Yayınevi";
            roman.Fiyat=68.60m;
            roman.SayfaSayısı = 296;

            Bilim bilim = new Bilim();
            bilim.UrunAdı = "Zamanın Kısa Tarihi";
            bilim.Yazar = "Stephen Hawking";
            bilim.YayınEvi = "Alfa Yayıncılık";
            bilim.BaskıYılı = 2017;
            bilim.Fiyat = 60.55m;

            Felsefe felsefe = new Felsefe();
            felsefe.UrunAdı = "Tanrılar Okulu";
            felsefe.Yazar = "Stefano D'Anna";
            felsefe.YayınEvi = "Sinedie Yayınları";
            felsefe.Dil = "Türkçe";
            felsefe.CevirmenAd = "Nehir Ötgüt";
            felsefe.Fiyat = 112.50m;

            CepTelefonu cepTelefonu= new CepTelefonu();
            cepTelefonu.Marka = "Xiaomi";
            cepTelefonu.UrunAdı = "Xiaomi Redmi Note 11 128Gb 6Gb Ram Gri";
            cepTelefonu.İsletimSistemi = "Android 11";
            cepTelefonu.EkranBoyutu = 6.43m;
            cepTelefonu.Kapasite =128;
            cepTelefonu.Fiyat = 6999;

            Bilgisayar bilgisayar= new Bilgisayar();
            bilgisayar.Marka = "Lenovo";
            bilgisayar.UrunAdı = "LENOVO IdeaPad";
            bilgisayar.Kapasite =512;
            bilgisayar.EkranBoyutu = "13.3";
            bilgisayar.IslemciType = "Intel";
            bilgisayar.Fiyat =11399;

            Kulaklık kulaklık=new Kulaklık();
            kulaklık.Marka = "JBL";
            kulaklık.UrunAdı = "JBL Tune 500BT Wireless Kulaklık ";
            kulaklık.Agırlık = 148;
            kulaklık.Frekans =20;
            kulaklık.Fiyat =829;

            Kalem kalem=new Kalem();
            kalem.Marka = "Rotring";
            kalem.UrunAdı = "Rotring Visumax";
            kalem.UcKalınlıgı = 0.7m;
            kalem.Materyal ="Metal";
            kalem.Fiyat =34.90m;


            Utu utu=new Utu();
            utu.Marka = "Tefal";
            utu.UrunAdı = "Tefal Ultimate Pure";
            utu.Materyal = "Plastik";
            utu.Guc =3200;
            utu.Fiyat =2189;

            KutuOyunları kutuOyunları=new KutuOyunları();
            kutuOyunları.Marka = "Hasbro Games";
            kutuOyunları.UrunAdı = "Hasbro B7404 Risk Strateji Oyunu";
            kutuOyunları.Yas =10;
            kutuOyunları.OyuncuSayısı =2;
            kutuOyunları.Fiyat =688.55m;

            List<Product> productList = new List<Product>();
            productList.Add(roman);
            productList.Add(bilim);
            productList.Add(felsefe);
            productList.Add(cepTelefonu);
            productList.Add(bilgisayar);
            productList.Add(kulaklık);
            productList.Add(kalem);
            productList.Add(utu);
            productList.Add(kutuOyunları);

            foreach(Product product in productList)
            {
                if (product is Roman)
                {
                    Roman roman1 = (Roman)product;
                    Console.WriteLine($"*****Kitap*****\nRoman:\nKitap İsim: {roman1.UrunAdı}\nYazar:{roman1.Yazar}\nYayınevi:{roman1.YayınEvi}\nSayfa Sayısı:{roman1.SayfaSayısı}\nFiyat:{roman1.KDVFiyat}\n");
                }
                else if (product is Bilim)
                {
                    Bilim bilim1 = (Bilim)product;

                    Console.WriteLine($"Bilim:\nKitap İsim: {bilim1.UrunAdı}\nYazar:{bilim1.Yazar}\nYayınevi:{bilim1.YayınEvi}\nBaskı Yılı:{bilim1.BaskıYılı}\nFiyat:{bilim1.KDVFiyat}\n");
                }
                else if(product is Felsefe)
                {
                    Felsefe felsefe1 = (Felsefe)product;

                    Console.WriteLine($"Felsefe:\nKitap İsim: {felsefe1.UrunAdı}\nYazar:{felsefe1.Yazar}\nYayınevi:{felsefe1.YayınEvi}\nDil:{felsefe1.Dil}\nÇevirmen:{felsefe1.CevirmenAd}\nFiyat:{felsefe1.KDVFiyat}\n");
                }
                else if(product is CepTelefonu)
                {
                    CepTelefonu cepTelefonu1= (CepTelefonu)product;

                    Console.WriteLine($"*****Elektronik*****\nCep Telefonu:\nMarka:{cepTelefonu1.Marka}\nÜrün:{cepTelefonu1.UrunAdı}\nİşletim Sistemi:{cepTelefonu1.İsletimSistemi}\nEkran Boyutu:{cepTelefonu1.EkranBoyutu}\nKapasite:{cepTelefonu1.Kapasite}\nFiyat:{cepTelefonu1.KDVFiyat}\n");
                }
                else if (product is Bilgisayar)
                {
                    Bilgisayar bilgisayar1 = (Bilgisayar)product;

                    Console.WriteLine($"Bilgisayar:\nMarka:{bilgisayar1.Marka}\nÜrün:{bilgisayar1.UrunAdı}\nİşlemci:{bilgisayar1.IslemciType}\nEkran Boyutu:{bilgisayar1.EkranBoyutu}\nKapasite:{bilgisayar1.Kapasite}\nFiyat:{bilgisayar1.KDVFiyat} \n");
                }
                else if (product is Kulaklık)
                {
                    Kulaklık kulaklık1=(Kulaklık)(product);

                    Console.WriteLine($"Kulaklık:\nMarka:{kulaklık1.Marka}\nÜrün:{kulaklık1.UrunAdı}\nAğırlık:{kulaklık1.Agırlık}\nFrekans:{kulaklık1.Frekans}\nFiyat:{kulaklık1.KDVFiyat}\n");
                }
                else if(product is Kalem)
                {
                    Kalem kalem1 = (Kalem)product;
                    Console.WriteLine($"*****Kırtasiye*****\nKalem:\nMarka:{kalem1.Marka}\nÜrün:{kalem1.UrunAdı}\nUç Kalınlığı:{kalem1.UcKalınlıgı}\nMateryal:{kalem1.Materyal}\nFiyat:{kalem1.KDVFiyat}\n");
                }
                else if(product is Utu)
                {
                    Utu utu1 = (Utu)product;

                    Console.WriteLine($"*****Ev Aletleri*****\nÜtü:\nMarka:{utu1.Marka}\nÜrün:{utu1.UrunAdı}\nMateryal:{utu1.Materyal}\nGüç:{utu1.Guc}\nFiyat:{utu1.KDVFiyat} \n");
                }
                else if(product is KutuOyunları)
                {
                    KutuOyunları kutuOyunları1=(KutuOyunları)(product);
                    Console.WriteLine($"*****Hobi*****\nKutu Oyunları:\nMarka:{kutuOyunları1.Marka}\nÜrün:{kutuOyunları1.UrunAdı}\nYaş:{kutuOyunları1.Yas}\nOyuncu Sayısı:{kutuOyunları1.OyuncuSayısı}\nFiyat:{kutuOyunları1.KDVFiyat}\n");
                }
            }

            Console.ReadLine();
        }
    }
}
