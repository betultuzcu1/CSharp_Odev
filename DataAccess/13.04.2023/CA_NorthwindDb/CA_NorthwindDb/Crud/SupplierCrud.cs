using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CA_NorthwindDb.Model;

namespace CA_NorthwindDb.Crud
{
    internal class SupplierCrud
    {
        NORTHWNDEntities db = new NORTHWNDEntities();
        //Listeleme
        public List<Supplier> GetSuppliers()
        {
            return db.Suppliers.ToList();
        }

        //Ekleme
        public string AddSupplier(Supplier supplier)
        {
            try
            {
                Supplier supplier1 = new Supplier();
                Console.Write("Lütfen tedarikçi şirket adını giriniz:");
                supplier1.CompanyName = Console.ReadLine();
                Console.Write("Lütfen tedarikçi bağlantı adını giriniz:");
                supplier1.ContactName = Console.ReadLine();
                Console.Write("Lütfen ünvan bilgisi giriniz:");
                supplier1.ContactTitle = Console.ReadLine();
                Console.Write("Lütfen şehir bilgisi giriniz: ");
                supplier1.City = Console.ReadLine();

                db.Suppliers.Add(supplier1);

                if (db.SaveChanges() > 0)
                {
                    return "Tedarikçi başarı ile eklendi!";
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
        public string UpdateSupplier(Supplier supplier)
        {
            try
            {
                Supplier updateSupplier = db.Suppliers.Find(supplier.SupplierID);
                updateSupplier.CompanyName = supplier.CompanyName;
                updateSupplier.ContactName = supplier.ContactName;
                updateSupplier.ContactTitle = supplier.ContactTitle;
                updateSupplier.City = supplier.City;

                if (db.SaveChanges() > 0)
                {
                    return "Tedarikçi başarı ile güncellendi!";
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
        public string DeleteSupplier(int id)
        {
            try
            {
                var value = db.Suppliers.Find(id);
                db.Suppliers.Remove(value);

                if (db.SaveChanges() > 0)
                {
                    return "Tedarikçi başarı ile silindi!";
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
