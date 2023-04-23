using BusinessLogicLayer.DesingPatterns.GenericRepository.ConcRep;
using CA_ToursDbNTier.CRUD;
using DataAcsessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_ToursDbNTier.ConsoleSpec
{
    internal class ConsoleMenu
    {
        public static void Kullanıcı()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Tour uygulamasına hoş geldiniz.Lütfen giriş yapınız!");
                    Console.Write("Kullanıcı adı:");
                    string kullanıcıAdı = Console.ReadLine();
                    if (kullanıcıAdı == "bilgeadam")
                    {
                        Console.Write("Şifre:");
                        string sifre = Console.ReadLine();
                        if (sifre == "123")
                        {
                            Console.WriteLine("Giriş başarılı.Ana menüye yönlendiriliyorsunuz..");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Hatalı şifre tekrar deneyiniz..");
                        }
                    }
                    else { Console.WriteLine("Kullanıcı adı hatalı tekrar deneyiniz"); }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }


        }

        
        
        public static void TourSelectMenu()
        {
            Console.WriteLine("Tour Menu");
            Console.WriteLine("1-Tur Bilgileri");
            Console.WriteLine("2-Rezervasyon Bilgileri");
            Console.WriteLine("3-Tur Rehber Bilgileri");
            Console.WriteLine("4-Müşteri Bilgileri");
            Console.WriteLine("5-Ödeme Bilgileri");
            Console.WriteLine("6-Lokasyon Bilgileri");
            Console.WriteLine("7-Tur Çeşitleri Bilgileri");
            Console.WriteLine("8-Çıkış");

            Console.Write("Lütfen bir seçim yapın:");
        }

        public static void SelectedMenu(int selected)
        {
            switch (selected)
            {
                case 1:
                    SelectAltMenu();
                    int secim1 = int.Parse(Console.ReadLine());
                    TourCrud _tourCrud = new TourCrud();
                    TourRepository _tourRepository = new TourRepository();

                    switch (secim1)
                    {
                       case 1:
                            _tourCrud.ListTours();
                            break;
                        case 2:                           
                            _tourCrud.AddTours(_tourRepository);
                            break;
                        case 3:
                            _tourCrud.UpdateTours(_tourRepository);
                            break;
                        case 4:
                            _tourCrud.DeleteTours(_tourRepository);
                            break;
                        default:
                            Console.WriteLine("Lütfen geçerli bir seçim yapınız");
                            break;
                    }
                    break;
                case 2:
                    SelectAltMenu();
                    int secim2 = int.Parse(Console.ReadLine());
                    ReservationCrud _reservationCrud = new ReservationCrud();
                    ReservationRepository _reservationRepository = new ReservationRepository();
                    switch (secim2)
                    {
                        case 1:
                            _reservationCrud.ListReservations();
                            break;
                        case 2:
                            _reservationCrud.AddReservations(_reservationRepository);
                            break;
                        case 3:
                            _reservationCrud.UpdateReservations(_reservationRepository);
                            break;
                        case 4:
                            _reservationCrud.DeleteReservations(_reservationRepository);
                            break;
                        default:
                            Console.WriteLine("Lütfen geçerli bir seçim yapınız!");
                            break;
                    }
                    break;
                case 3:
                    SelectAltMenu();
                    int secim3 = int.Parse(Console.ReadLine());
                    GuideCrud _guideCrud = new GuideCrud();
                    GuideRepository _guideRepository = new GuideRepository();
                    switch (secim3)
                    {
                        case 1:
                            _guideCrud.ListGuides();
                            break;
                        case 2:
                            _guideCrud.AddGuides(_guideRepository);
                            break;
                        case 3:
                            _guideCrud.Updateguides(_guideRepository);
                            break;
                        case 4:
                           _guideCrud.Deleteguides(_guideRepository);
                            break;
                        default:
                            Console.WriteLine("Lütfen geçerli bir seçim yapınız!");
                            break;
                    }
                    break;
                case 4:
                    SelectAltMenu();
                    int secim4 = int.Parse(Console.ReadLine());
                    CustomerCrud _customerCrud = new CustomerCrud();
                    CustomerRepository _customerRepository = new CustomerRepository();
                    switch (secim4)
                    {
                        case 1:
                            _customerCrud.ListCustomers();
                            break;
                        case 2:
                            _customerCrud.AddCustomers(_customerRepository);
                            break;
                        case 3:
                           _customerCrud.UpdateCustomers(_customerRepository);
                            break;
                        case 4:
                            _customerCrud.DeleteCustomers(_customerRepository);
                            break;
                        default:
                            Console.WriteLine("Lütfen geçerli bir seçim yapınız!");
                            break;
                    }
                    break;
                case 5:
                    SelectAltMenu();
                    int secim5 = int.Parse(Console.ReadLine());
                    PaymentCrud _paymentCrud = new PaymentCrud();
                    PaymentRepository _paymentRepository = new PaymentRepository();
                    switch (secim5)
                    {
                        case 1:
                            _paymentCrud.ListPayments();
                            break;
                        case 2:
                           _paymentCrud.AddPayments(_paymentRepository);
                            break;
                        case 3:
                            _paymentCrud.UpdatePayments(_paymentRepository);
                            break;
                        case 4:
                            _paymentCrud.DeletePayments(_paymentRepository);
                            break;
                        default:
                            Console.WriteLine("Lütfen geçerli bir seçim yapınız!");
                            break;
                    }
                    break;
                case 6:
                    SelectAltMenu();
                    int secim6 = int.Parse(Console.ReadLine());
                    TourLocationCrud _tourLocationCrud = new TourLocationCrud();
                    TourLocationRepository _tourLocationRepository = new TourLocationRepository();
                    switch (secim6)
                    {
                        case 1:
                            _tourLocationCrud.ListTourLocations();
                            break;
                        case 2:
                            _tourLocationCrud.AddTourLocations(_tourLocationRepository);
                            break;
                        case 3:
                            _tourLocationCrud.UpdateTourLocations(_tourLocationRepository);
                            break;
                        case 4:
                            _tourLocationCrud.DeleteTourLocations(_tourLocationRepository);
                            break;
                        default:
                            Console.WriteLine("Lütfen geçerli bir seçim yapınız!");
                            break;
                    }
                    break;
                case 7:
                    SelectAltMenu();
                    int secim7 = int.Parse(Console.ReadLine());
                    TourTypeCrud _tourTypeCrud = new TourTypeCrud();
                    TourTypeRepository _tourTypeRepository = new TourTypeRepository();
                    switch (secim7)
                    {
                        case 1:
                            _tourTypeCrud.ListTourTypes();
                            break;
                        case 2:
                            _tourTypeCrud.AddTourTypes(_tourTypeRepository);
                            break;
                        case 3:
                            _tourTypeCrud.UpdateCustomers(_tourTypeRepository);
                            break;
                        case 4:
                            _tourTypeCrud.DeleteCustomers(_tourTypeRepository);
                            break;
                        default:
                            Console.WriteLine("Lütfen geçerli bir seçim yapınız!");
                            break;
                    }
                    break;
                case 8:
                    Console.WriteLine("Çıkış yapılıyor,lütfen bekleyin..");
                    break;
                default : 
                    Console.WriteLine("Lütfen geçerli bir seçim yapınız!");
                    break;               
            }
        }

        public static void SelectAltMenu() 
        {
            Console.WriteLine("Aşağıdan bir işlem seçiniz!");
            Console.WriteLine("1-Listeleme");
            Console.WriteLine("2-Ekleme");
            Console.WriteLine("3-Güncelleme");
            Console.WriteLine("4-Silme");
            Console.Write("İşlem seçimi:");
            
        }
    }
}
