using CA_NorthwindDb.Crud;
using CA_NorthwindDb.Model;
using CA_NorthwindDb.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CA_NorthwindDb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductCrud productCrud = new ProductCrud();
            CategoryCrud categoryCrud = new CategoryCrud();
            SupplierCrud supplierCrud = new SupplierCrud();
            CustomerCrud customerCrud = new CustomerCrud();


            Urun urun = new Urun();
            Kategori kategori = new Kategori();
            Tedarikci tedarikci = new Tedarikci();
            Musteri musteri = new Musteri();
            Sorgu sorgu = new Sorgu();

            Console.WriteLine("Ana menüye hoş geldiniz.Lütfen aşağıdan gitmek istediğiniz menüyü seçiniz!");
            Console.ReadLine() ;
            while (true)
            {
                Console.WriteLine("1-Ürün İşlemleri\n2-Kategori İşlemleri\n3-Tedarikçi İşlemleri\n4-Müşteri İşlemleri\n5-Sorgular\n6-Çıkış");
                Console.ReadLine() ;
                Console.Write("Menü seçimi:");
                string secim = Console.ReadLine();
                try
                {
                    switch (secim)
                    {
                        case "1":
                            urun.UrunIslmeleri();
                            break;
                        case "2":
                            kategori.KategorıIslemlerı();
                            break;
                        case "3":
                            tedarikci.TedarikciIslemleri();
                            break;
                        case "4":
                            musteri.MusteriIslemleri();
                            break;
                        case "5":
                            sorgu.SorguIslemleri();
                            break;
                        case "6":
                            Console.WriteLine("Çıkış yapılıyor..");
                            return;
                        default:
                            Console.WriteLine("Lütfen geçerli bir seçim yapınız!!");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.ReadLine();
            }
                      
        }
    }
}
