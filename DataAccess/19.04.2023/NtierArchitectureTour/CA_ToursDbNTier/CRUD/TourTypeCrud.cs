using BusinessLogicLayer.DesingPatterns.GenericRepository.ConcRep;
using DataAcsessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_ToursDbNTier.CRUD
{
    public class TourTypeCrud
    {
        TourTypeRepository _tourTypeRepository= new TourTypeRepository();

        //listeleme
        public void ListTourTypes()
        {
            foreach (TourType tourType in _tourTypeRepository.GetAll())
            {
                Console.WriteLine(tourType.Id + " " + tourType.Name );
            }
        }

        //ekleme
        public void AddTourTypes(TourTypeRepository tourTypeRepository)
        {
            TourType tourType = new TourType();
            Console.Write("Eklemek istediğiniz tür tipini giriniz:");
            tourType.Name = Console.ReadLine();
            tourTypeRepository.Add(tourType);
        }

        //silme
        public void DeleteCustomers(TourTypeRepository tourTypeRepository)
        {
            Console.Write("Silmek istedğiniz tur tipinin Id numarasını giriniz:");
            int _ıd = int.Parse(Console.ReadLine());
            var tourTypeValue = tourTypeRepository.Find(_ıd);
            tourTypeRepository.Delete(tourTypeValue);
        }

        //Güncelleme
        public void UpdateCustomers(TourTypeRepository tourTypeRepository)
        {
            Console.Write("Güncellemek istedğiniz tur tipinin Id numarasını giriniz:");
            int _ıd = int.Parse(Console.ReadLine());
            var tourTypeValue = tourTypeRepository.Find(_ıd);
            Console.Write("Tur tipini giriniz:");
            tourTypeValue.Name = Console.ReadLine();
            tourTypeRepository.Update(tourTypeValue);
        }
    }
}
