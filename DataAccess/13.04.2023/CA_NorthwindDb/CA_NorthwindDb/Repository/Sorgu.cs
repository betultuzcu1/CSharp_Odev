using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CA_NorthwindDb.Model;
using CA_NorthwindDb.Crud;


namespace CA_NorthwindDb.Repository
{
    internal class Sorgu
    {
        NORTHWNDEntities db=new NORTHWNDEntities();
        public void SorguIslemleri() 
        {
            try
            {
                Console.WriteLine("Lütfen gerçekleştirmek istediğiniz sorguyu saçiniz.");

                Console.ReadLine();

                Console.WriteLine("1-Ürünler fiyat sorgusu\n2-Ürünler fiyat aralığı sorgusu\n3-Çalışan bilgisi sorgusu\n4-Kargo durum sorgusu\n5-Çalışan ikamet sorgusu");
                Console.Write("Sorgu seçim:");
                string secim= Console.ReadLine();
                switch(secim)
                {
                    case"1":
                        Console.Write("Lütfen sorgulamak istediğiniz ürün fiyatını giriniz:");
                        decimal fiyat=decimal.Parse(Console.ReadLine());
                        Console.WriteLine($"Ürünler tablosundan ürün fiyatı {fiyat}'dan büyük olanları listeyin");
                        var result = db.Products.Where(x => x.UnitPrice > fiyat).Select(x => new
                        {
                            x.ProductID,
                            x.ProductName,
                            x.UnitPrice,
                            x.UnitsInStock
                        });

                        foreach(var p in result.ToList())
                        {
                            Console.WriteLine(p);
                        }
                        break;
                    case"2":
                        Console.Write("Lütfen sorgulamak istediğiniz ürün fiyat aralıklarını giriniz!");
                        Console.Write("Fiyat 1:");
                        decimal fiyat1 = decimal.Parse(Console.ReadLine());
                        Console.Write("Fiyat 2:");
                        decimal fiyat2 = decimal.Parse(Console.ReadLine());
                        if(fiyat1 > fiyat2)
                        {
                            Console.WriteLine("Lütfen ilk fiyattan daha büyük bir fiyat giriniz!");
                        }
                        else
                        {
                            Console.WriteLine($"Ürünler tablosundan ürün fiyatı {fiyat1} ile {fiyat2} arasında ürünleri listeleyin.");
                            var sonuc = db.Products.Where(x => x.UnitPrice > fiyat1 && x.UnitPrice<fiyat2).Select(x => new
                            {
                                x.ProductID,
                                x.ProductName,
                                x.UnitPrice,
                                x.UnitsInStock
                            });

                            foreach (var p in sonuc.ToList())
                            {
                                Console.WriteLine(p);
                            }
                        }                        
                        break;
                    case"3":
                        Console.WriteLine("Lütfen sorgulamak istediğiniz çalışan adını giriniz!");
                        Console.Write("Çalışan adı:");
                        string ad=Console.ReadLine();
                        Console.WriteLine($"Adı {ad} olan çalışanın bilgilerini listeleyin.");
                        var sonuc1 = db.Employees.Where(x => x.FirstName.Contains(ad)).ToList();
                        foreach (var e in sonuc1.ToList())
                        {
                            string format = $"{e.FirstName} {e.LastName} {e.Title} {e.City}";
                            Console.WriteLine(format);
                        }
                        break;
                    case"4":
                        Console.WriteLine("Kargo durum sorgusu:");
                        var durum=db.Orders.Where(x=>x.ShippedDate==null).ToList();
                        foreach (var shipped in durum.ToList())
                        {
                            string format = $"{shipped.OrderID} {shipped.ShipName} {shipped.ShipAddress} {shipped.ShippedDate}";
                            Console.WriteLine(format);
                        }
                        break;
                    case"5":
                        Console.WriteLine("Lütfen sorgulamak istediğiniz şehir bilgisini giriniz!");
                        Console.Write("Çalışan şehir:");
                        string city = Console.ReadLine();
                        Console.WriteLine($"Yaşadığı şehir {city} olan çalışanların bilgilerini listeleyin.");
                        var sonuc2 = db.Employees.Where(x => x.FirstName.Contains(city)).ToList();
                        foreach (var e in sonuc2.ToList())
                        {
                            string format = $"{e.FirstName} {e.LastName} {e.Title} {e.City}";
                            Console.WriteLine(format);
                        }
                        break;                      
                    default:
                        Console.WriteLine("Lütfen geçerli bir seçim yapınız!");
                        break;
                }

            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
