using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CA_NorthwindDb.Model;
using CA_NorthwindDb.Crud;

namespace CA_NorthwindDb.Repository
{
    internal class Tedarikci
    {
        SupplierCrud supplierCrud = new SupplierCrud();
        
        public void TedarikciIslemleri()
        {
            Console.WriteLine("Lütfen bir alt kategori seçiniz!");
            Console.ReadLine();
            Console.WriteLine("1.Tedarikçi Listeleme\n2.Tedarikçi Ekleme\n3.Tedarikçi Güncelleme\n4.Tedarikçi Silme");
            Console.Write("Kategori Seçimi: ");
            string secim3 = Console.ReadLine();
            switch (secim3)
            {
                case "1":
                    //Listeleme
                    foreach (Supplier supplier1 in supplierCrud.GetSuppliers())
                    {
                        string format = $"{supplier1.SupplierID} {supplier1.CompanyName} {supplier1.ContactName} {supplier1.ContactTitle} {supplier1.City} ";
                        Console.WriteLine(format);
                    }
                    break;
                case "2":
                    //ekleme
                    Supplier supplier = new Supplier();
                    string sonuc = supplierCrud.AddSupplier(supplier);
                    Console.WriteLine(sonuc);
                    Console.ReadLine();
                    break;
                case "3":
                    //Güncelleme
                    Supplier updateSuppleir = new Supplier();
                    Console.Write("Lütfen güncellemek istediğiniz tedarikçinin ID'sini giriniz:");
                    updateSuppleir.SupplierID = int.Parse(Console.ReadLine());
                    Console.Write("Lütfen tedarikçi şirket adını giriniz:");
                    updateSuppleir.CompanyName = Console.ReadLine();
                    Console.Write("Lütfen bağlatı ad bilgisini giriniz:");
                    updateSuppleir.ContactName = Console.ReadLine();
                    Console.Write("Lütfen şehir bilgisini giriniz:");
                    updateSuppleir.City = Console.ReadLine();
                    Console.WriteLine($"{updateSuppleir.SupplierID} ID'li müşteriyi güncellemek istediğinizden emin misiiz?(e/h)");
                    string gülcellemeSecim = Console.ReadLine();
                    if (gülcellemeSecim == "e")
                    {
                        string sonuc1 = supplierCrud.UpdateSupplier(updateSuppleir);
                        Console.WriteLine(sonuc1);
                    }
                    else
                    {
                        return;
                    }
                    break;
                case "4":
                    //silme
                    Console.Write("Silmek istediğiniz ürün ID'sini giriniz:");
                    int supplierId = int.Parse(Console.ReadLine());
                    Console.WriteLine($"{supplierId} ID'li tedarikçiyi silmek istediğinizden emin misiiz?(e/h)");
                    string silmeSecim = Console.ReadLine();
                    if (silmeSecim == "e")
                    {
                        string sonuc3 = supplierCrud.DeleteSupplier(supplierId);
                        Console.WriteLine(sonuc3);
                    }
                    else
                    {
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Lütfen geçrli bir seçim yapınız!");
                    break;
            }
        }
    }
}
