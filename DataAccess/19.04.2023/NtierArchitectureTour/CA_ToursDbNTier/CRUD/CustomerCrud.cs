using BusinessLogicLayer.DesingPatterns.GenericRepository.ConcRep;
using CA_ToursDbNTier.ViewModels;
using DataAcsessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_ToursDbNTier.CRUD
{
    public class CustomerCrud
    {
        CustomerRepository _customerRepository= new CustomerRepository();

        //listeleme
        public void ListCustomers()
        {
            foreach (Customer customer in _customerRepository.GetAll())
            {
                Console.WriteLine(customer.Id+" "+customer.FullName+" "+customer.Email+" "+customer.PhoneNumber);
            }
        }

        //ekleme
        public void AddCustomers(CustomerRepository customerRepository)
        {
            Customer customer = new Customer();
            Console.Write("Eklemek istediğiniz müşteri ismini giriniz:");
            customer.FullName= Console.ReadLine();
            Console.Write("Eklemek istediğiniz müşterinin mail adresini giriniz:");
            customer.Email= Console.ReadLine();
            Console.Write("Eklemek istediğiniz müşterinin telefon numarasını giriniz:");
            customer.PhoneNumber= Console.ReadLine();
            customerRepository.Add(customer);
        }

        //silme
        public void DeleteCustomers(CustomerRepository customerRepository)
        {
            Console.Write("Silmek istedğiniz müşteri Id numarasını giriniz:");
            int _ıd=int.Parse(Console.ReadLine());
            var customerValue = customerRepository.Find(_ıd);
            customerRepository.Delete(customerValue);
        }

        //Güncelleme
        public void UpdateCustomers(CustomerRepository customerRepository)
        {
            Console.Write("Güncellemek istedğiniz müşteri Id numarasını giriniz:");
            int _ıd = int.Parse(Console.ReadLine());
            var customerValue = customerRepository.Find(_ıd);
            Console.Write("Müşteri ismini giriniz:");
            customerValue.FullName= Console.ReadLine();
            Console.Write("Müşteri mail adresini giriniz");
            customerValue.Email= Console.ReadLine();
            Console.Write("Müşteri telefon numarasını giriniz:");
            customerValue.PhoneNumber= Console.ReadLine();
            customerRepository.Update(customerValue);
        }

    }
}
