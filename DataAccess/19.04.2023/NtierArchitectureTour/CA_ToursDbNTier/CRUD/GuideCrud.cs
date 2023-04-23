using BusinessLogicLayer.DesingPatterns.GenericRepository.ConcRep;
using DataAcsessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_ToursDbNTier.CRUD
{
    public class GuideCrud
    {
        GuideRepository _guideRepository=new GuideRepository();

        //listeleme
        public void ListGuides()
        {
            foreach (Guide guide in _guideRepository.GetAll())
            {
                Console.WriteLine(guide.Id + " " + guide.FullName + " " + guide.EMail + " " + guide.PhoneNumber+" "+guide.Salary);
            }
        }

        //ekleme
        public void AddGuides(GuideRepository guideRepository)
        {
            Guide guide = new Guide();
            Console.Write("Eklemek istediğiniz rehber ismini giriniz:");
            guide.FullName = Console.ReadLine();
            Console.Write("Eklemek istediğiniz rehberin mail adresini giriniz:");
            guide.EMail = Console.ReadLine();
            Console.Write("Eklemek istediğiniz rehberin telefon numarasını giriniz:");
            guide.PhoneNumber = Console.ReadLine();
            Console.Write("Eklemek istediğiniz rehberin maaş bilgisini giriniz:");
            guide.Salary=decimal.Parse(Console.ReadLine());
            guideRepository.Add(guide);
        }

        //silme
        public void Deleteguides(GuideRepository guideRepository)
        {
            Console.Write("Silmek istedğiniz rehberin Id numarasını giriniz:");
            int _ıd = int.Parse(Console.ReadLine());
            var guideValue = guideRepository.Find(_ıd);
            guideRepository.Delete(guideValue);
        }

        //Güncelleme
        public void Updateguides(GuideRepository guideRepository)
        {
            Console.Write("Güncelleme istedğiniz rehberin Id numarasını giriniz:");
            int _ıd = int.Parse(Console.ReadLine());
            var guideValue = guideRepository.Find(_ıd);
            Console.Write("Rehberin ismini giriniz:");
            guideValue.FullName = Console.ReadLine();
            Console.Write("Rehber mail adresini giriniz");
            guideValue.EMail = Console.ReadLine();
            Console.Write("Rehber telefon numarasını giriniz:");
            guideValue.PhoneNumber = Console.ReadLine();
            Console.Write("Rehber maaş bilgisini giriniz:");
            guideValue.Salary=decimal.Parse(Console.ReadLine());
            guideRepository.Update(guideValue);
        }
    }
}
