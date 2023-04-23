using BusinessLogicLayer.DesingPatterns.GenericRepository.ConcRep;
using DataAcsessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_ToursDbNTier.CRUD
{
    public class TourLocationCrud
    {
        TourLocationRepository _tourLocationRepository=new TourLocationRepository();

        //listeleme
        public void ListTourLocations()
        {
            foreach (TourLocation tourLocation in _tourLocationRepository.GetAll())
            {
                Console.WriteLine(tourLocation.Id + " " + tourLocation.City + " " + tourLocation.Country);
            }
        }

        //ekleme
        public void AddTourLocations(TourLocationRepository tourLocationRepository)
        {
            TourLocation tourLocation=new TourLocation();
            Console.Write("Eklemek istediğiniz tur şehir bilgisini giriniz:");
            tourLocation.City = Console.ReadLine();
            Console.Write("Eklemek istediğiniz tur ülke bilgisini giriniz:");
            tourLocation.Country = Console.ReadLine();
            tourLocationRepository.Add(tourLocation);
        }

        //silme
        public void DeleteTourLocations(TourLocationRepository tourLocationRepository)
        {
            Console.Write("Silmek istedğiniz tur lokasyon Id numarasını giriniz:");
            int _ıd = int.Parse(Console.ReadLine());
            var tourLocationValue = tourLocationRepository.Find(_ıd);
            tourLocationRepository.Delete(tourLocationValue);
        }

        //Güncelleme
        public void UpdateTourLocations(TourLocationRepository tourLocationRepository)
        {
            Console.Write("Güncellemek istedğiniz tur lokasyon Id numarasını giriniz:");
            int _ıd = int.Parse(Console.ReadLine());
            var tourLocationValue = tourLocationRepository.Find(_ıd);
            Console.Write("Şehir bilgisini giriniz:");
            tourLocationValue.City = Console.ReadLine();
            Console.Write("Ülke bilgisini giriniz");
            tourLocationValue.Country = Console.ReadLine();
            tourLocationRepository.Update(tourLocationValue);
        }
    }
}
