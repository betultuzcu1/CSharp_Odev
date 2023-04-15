using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CA_NorthwindDb.Model;

namespace CA_NorthwindDb.Crud
{
    internal class CustomerCrud
    {
        NORTHWNDEntities db = new NORTHWNDEntities();
        //Listeleme
        public List<Customer> GetCustomers()
        {
            return db.Customers.ToList();
        }

        //Ekleme
        public string AddCustomer(Customer customer)
        {
            try
            {
                Customer customer1 = new Customer();
                Console.Write("Lütfen müşteri şirket adını giriniz:");
                customer1.CompanyName = Console.ReadLine();
                Console.Write("Lütfen müşteri adını giriniz:");
                customer1.ContactName = Console.ReadLine();
                Console.Write("Lütfen müşteri ünvan bilgisi giriniz:");
                customer1.ContactTitle = Console.ReadLine();
                Console.Write("Lütfen şehir bilgisi giriniz:");
                customer1.City = Console.ReadLine();

                db.Customers.Add(customer1);

                if (db.SaveChanges() > 0)
                {
                    return "Müşteri bilgisi başarı ile eklendi!";
                }
                else
                {
                    return "Ekleme işlemi başarısız!";
                }
            }
            catch (Exception ex)
            {
                return $"{ex}.Message";
            }
        }

        //güncelleme

        public string UpdateCustomer(Customer customer)
        {
            try
            {
                Customer updateCustomer = db.Customers.Find(customer.CustomerID);
                updateCustomer.CompanyName=customer.CompanyName;
                updateCustomer.ContactName=customer.ContactName;
                updateCustomer.ContactTitle=customer.ContactTitle;
                updateCustomer.City=customer.City;

                if (db.SaveChanges() > 0)
                {
                    return "Müşteri bilgisi başarı ile güncellendi!";
                }
                else
                {
                    return "Güncelleme işlemi başarısız!";
                }
            }
            catch (Exception ex)
            {
                return $"{ex}.Message";
            }
        }

        //silme 

        public string DeleteCustomer(int id)
        {
            try
            {
                var value = db.Customers.Find(id);
                db.Customers.Remove(value);

                if (db.SaveChanges() > 0)
                {
                    return "Müşteri bilgisi başarı ile silindi!";
                }
                else
                {
                    return "Silme işlemi başarısız!";
                }
            }
            catch (Exception ex)
            {
                return $"{ex}.Message";
            }
        }
    }
}
