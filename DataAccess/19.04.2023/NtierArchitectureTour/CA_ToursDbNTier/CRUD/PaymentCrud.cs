using BusinessLogicLayer.DesingPatterns.GenericRepository.ConcRep;
using DataAcsessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_ToursDbNTier.CRUD
{
    public class PaymentCrud
    {
        PaymentRepository _paymentRepository=new PaymentRepository();

        //listeleme
        public void ListPayments()
        {
            foreach (Payment payment in _paymentRepository.GetAll())
            {
                Console.WriteLine(payment.Id + " " + payment.PaymentDate + " " + payment.Price );
            }
        }

        //ekleme
        public void AddPayments(PaymentRepository paymentRepository)
        {
            Payment payment = new Payment();
            Console.Write("Eklemek istediğiniz ödeme tarihini giriniz:");
            payment.PaymentDate =DateTime.Now;
            Console.Write("Eklemek istediğiniz ödemenin ücretini giriniz:");
            payment.Price =decimal.Parse(Console.ReadLine());
            paymentRepository.Add(payment);
        }

        //silme
        public void DeletePayments(PaymentRepository paymentRepository)
        {
            Console.Write("Silmek istedğiniz ödeme bilgisinin Id numarasını giriniz:");
            int _ıd = int.Parse(Console.ReadLine());
            var paymentValue = paymentRepository.Find(_ıd);
            paymentRepository.Delete(paymentValue);
        }

        //Güncelleme
        public void UpdatePayments(PaymentRepository paymentRepository)
        {
            Console.Write("Güncellemek istedğiniz ödeme bilgisinin Id numarasını giriniz:");
            int _ıd = int.Parse(Console.ReadLine());
            var paymentValue = paymentRepository.Find(_ıd);
            Console.Write("Ödeme tarihini giriniz:");
            paymentValue.PaymentDate = DateTime.Now;
            Console.Write("Ödeme tutarını giriniz:");
            paymentValue.Price =decimal.Parse(Console.ReadLine());
            paymentRepository.Update(paymentValue);
        }
    }
}
