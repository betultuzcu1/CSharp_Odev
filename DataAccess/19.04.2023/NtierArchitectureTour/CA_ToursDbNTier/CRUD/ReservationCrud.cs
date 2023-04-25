using BusinessLogicLayer.DesingPatterns.GenericRepository.ConcRep;
using DataAcsessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_ToursDbNTier.CRUD
{
    public class ReservationCrud
    {
        ReservationRepository _reservationRepository = new ReservationRepository();

        //listeleme
        public void ListReservations()
        {
            foreach (Reservation reservation in _reservationRepository.GetAll())
            {
                Console.WriteLine(reservation.Id/* + " " +reservation.ReservationDate*/ );
            }
        }

        //ekleme
        public void AddReservations(ReservationRepository reservationRepository)
        {
            Reservation reservation = new Reservation();
            //Console.Write("Eklemek istediğiniz reservasyon tarihini giriniz:");
            //reservation.ReservationDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Eklemek istediğiniz rezervasyon ücretini giriniz:");
            reservationRepository.Add(reservation);
        }

        //silme
        public void DeleteReservations(ReservationRepository reservationRepository)
        {
            Console.Write("Silmek istedğiniz rezervasyon Id numarasını giriniz:");
            int _ıd = int.Parse(Console.ReadLine());
            var reservationValue = reservationRepository.Find(_ıd);
            reservationRepository.Delete(reservationValue);
        }

        //Güncelleme
        public void UpdateReservations(ReservationRepository reservationRepository)
        {
            Console.Write("Güncellemek istedğiniz rezervasyon Id numarasını giriniz:");
            int _ıd = int.Parse(Console.ReadLine());
            var reservationValue = reservationRepository.Find(_ıd);
            //Console.Write("Rezervasyon tarihini giriniz:");
            //reservationValue.ReservationDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Rezervasyon ücretini giriniz:");
            reservationValue.TotalPrice=decimal.Parse(Console.ReadLine());
            reservationRepository.Update(reservationValue);
        }
    }
}
