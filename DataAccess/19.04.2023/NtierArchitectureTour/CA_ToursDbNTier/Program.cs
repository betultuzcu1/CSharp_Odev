using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer.DesingPatterns.GenericRepository.ConcRep;
using CA_ToursDbNTier.ConsoleSpec;
using CA_ToursDbNTier.CRUD;

namespace CA_ToursDbNTier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerCrud _customerCrud = new CustomerCrud();
            GuideCrud _guideCrud = new GuideCrud();
            PaymentCrud _paymentCrud = new PaymentCrud();
            ReservationCrud _reservationCrud = new ReservationCrud();
            TourCrud _tourCrud = new TourCrud();
            TourLocationCrud _tourLocationCrud = new TourLocationCrud();
            TourTypeCrud _tourTypeCrud = new TourTypeCrud();

            ConsoleMenu.Kullanıcı();
            while (true)
            {

                ConsoleMenu.TourSelectMenu();

                int secim = int.Parse(Console.ReadLine());

                ConsoleMenu.SelectedMenu(secim);

                Console.ReadLine();
            }

            

        }
    }
}
