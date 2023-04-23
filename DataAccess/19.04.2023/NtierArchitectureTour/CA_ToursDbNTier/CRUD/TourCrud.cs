using BusinessLogicLayer.DesingPatterns.GenericRepository.ConcRep;
using DataAcsessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_ToursDbNTier.CRUD
{
    public class TourCrud
    {
        TourRepository _tourRepository=new TourRepository();

        //listeleme
        public void ListTours()
        {
            foreach (Tour tour in _tourRepository.GetAll())
            {
                Console.WriteLine(tour.Id + " " + tour.Name + " " + tour.Description + " " + tour.Capacity+" "+tour.StartDate+" "+tour.EndDate+" "+tour.Price);
            }
        }

        //ekleme
        public void AddTours(TourRepository tourRepository)
        {
            Tour tour=new Tour();
            Console.Write("Eklemek istediğiniz tur adını giriniz:");
            tour.Name = Console.ReadLine();
            Console.Write("Eklemek istediğiniz tur açıklama bilgisini giriniz:");
            tour.Description = Console.ReadLine();
            Console.Write("Eklemek istediğiniz tur kapasite bilgisini giriniz:");
            tour.Capacity=short.Parse(Console.ReadLine());
            Console.Write("Eklemek istediğiniz tur başlangıç tarihini giriniz:");
            tour.StartDate=DateTime.Parse(Console.ReadLine());
            Console.Write("Eklemek istediğiniz tur bitiş tarihini giriniz:");
            tour.EndDate=DateTime.Parse(Console.ReadLine());
            tourRepository.Add(tour);
        }

        //silme
        public void DeleteTours(TourRepository tourRepository)
        {
            Console.Write("Silmek istedğiniz turun Id numarasını giriniz:");
            int _ıd = int.Parse(Console.ReadLine());
            var tourValue = tourRepository.Find(_ıd);
            tourRepository.Delete(tourValue);
        }

        //Güncelleme
        public void UpdateTours(TourRepository tourRepository)
        {
            Console.Write("Silmek istedğiniz turun Id numarasını giriniz:");
            int _ıd = int.Parse(Console.ReadLine());
            var tourValue = tourRepository.Find(_ıd);
            Console.Write("Tur adını giriniz:");
            tourValue.Name = Console.ReadLine();
            Console.Write("Tur açıklamasını giriniz:");
            tourValue.Description = Console.ReadLine();
            Console.Write("Tur kapasite bilgisini giriniz:");
            tourValue.Capacity = short.Parse(Console.ReadLine());
            Console.Write("Tur ücret bilgisini giriniz:");
            tourValue.Price = decimal.Parse(Console.ReadLine());
            Console.Write("Tur başlangıç tarihini giriniz:");
            tourValue.StartDate = DateTime.Now;
            Console.Write("Tur bitiş tarihini giriniz:");
            tourValue.EndDate = DateTime.Now;
            tourRepository.Update(tourValue);
        }
    }
}
