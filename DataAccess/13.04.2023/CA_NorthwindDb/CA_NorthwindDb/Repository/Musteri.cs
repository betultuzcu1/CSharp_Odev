using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CA_NorthwindDb.Crud;
using CA_NorthwindDb.Model;

namespace CA_NorthwindDb.Repository
{
    internal class Musteri
    {
        NORTHWNDEntities db = new NORTHWNDEntities();

        CustomerCrud customerCrud = new CustomerCrud();

        public void MusteriIslemleri()
        {
            Console.WriteLine("Lütfen bir alt kategori seçiniz!");
            Console.ReadLine();
            Console.WriteLine("1.Müşteri Listeleme\n2.Müşteri Ekleme\n3.Müşteri Güncelleme\n4.Müşteri Silme");
            Console.Write("Kategori Seçimi: ");
            string secim4 = Console.ReadLine();
            switch (secim4)
            {
                case "1":
                    //Listeleme
                    foreach (Customer customer in customerCrud.GetCustomers())
                    {
                        string format = $"{customer.CustomerID} {customer.CompanyName} {customer.ContactName} {customer.ContactTitle} {customer.City} ";
                        Console.WriteLine(format);
                    }
                    break;
                case "2":
                    //ekleme
                    Customer customer1 = new Customer();
                    string sonuc = customerCrud.AddCustomer(customer1);
                    Console.WriteLine(sonuc);
                    Console.ReadLine();
                    break;
                case "3":
                    //Güncelleme
                    Customer updateCustomer = new Customer();
                    Console.Write("Lütfen güncellemek istediğiniz tedarikçinin ID'sini giriniz:");
                    updateCustomer.CustomerID = Console.ReadLine();
                    Console.Write("Lütfen tedarikçi şirket adını giriniz:");
                    updateCustomer.CompanyName = Console.ReadLine();
                    Console.Write("Lütfen bağlatı ad bilgisini giriniz:");
                    updateCustomer.ContactName = Console.ReadLine();
                    Console.Write("Lütfen şehir bilgisini giriniz:");
                    updateCustomer.City = Console.ReadLine();
                    var value=db.Customers.Where(x => x.CustomerID == updateCustomer.CustomerID).Select(x => x.CompanyName).FirstOrDefault();
                    Console.WriteLine($"{value} isimli müşteriyi güncellemek istediğinizden emin misiiz?(e/h)");
                    string gülcellemeSecim = Console.ReadLine();
                    if (gülcellemeSecim == "e")
                    {
                        string sonuc1 = customerCrud.UpdateCustomer(updateCustomer);
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
                    int customerId = int.Parse(Console.ReadLine());
                    var value2 = db.Customers.Where(x => x.CustomerID == "customerId").Select(x => x.CompanyName).FirstOrDefault();
                    Console.WriteLine($"{value2} isimli müşteriyi silmek istediğinizden emin misiiz?(e/h)");
                    string silmeSecim = Console.ReadLine();
                    if( silmeSecim == "e")
                    {
                        string sonuc3 = customerCrud.DeleteCustomer(customerId);
                        Console.WriteLine(sonuc3);
                    }
                    else { return; }
                    break;
                default:
                    Console.WriteLine("Lütfen geçrli bir seçim yapınız!");
                    break;
            }
        }
    }
}
