using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_PersonelSistem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Personel Kayıt Sistemine hoş geldiniz.Lütfen personel bilgilerini giriniz.");
            Console.ReadLine();

            List<Personel> personelList = new List<Personel>();

            string secim;
            do
            {               
                Personel personel = PersonelBilgi();
                Console.WriteLine("Personel bilgileri girildi. Personel bilgilerini girmeye devam etmek ister misin? (e/h)");
                secim = Console.ReadLine().ToLower();
                personelList.Add(personel);
                if(secim == "h")
                {
                    Console.WriteLine("Personel Listesi");
                    Console.ReadLine();

                    foreach (Personel p in personelList)
                    {
                        Console.WriteLine($"Ad Soyad: {p.FullName}\nTC Kimlik No: {p.TckNo}\nDepartman: {p.Depertman}\nMaaş: {p.Price()}");
                    }
                }

            } while (secim == "e");
            
            Console.ReadLine();

        }

        static Personel PersonelBilgi()
        {
            
                Personel personel = new Personel();
                Console.Write("Personel adını giriniz:");
                personel.FirstName = Console.ReadLine();
                Console.Write("Personel soyadını giriniz:");
                personel.LastName = Console.ReadLine();
                Console.Write("Personel Tc kimlik numarasını giriniz:");
                personel.TckNo = Console.ReadLine();
                Console.Write("Depertman seçiniz(Muhasebe, Satın Alma, Geliştirme, Yönetici):");
                personel.Depertman = Console.ReadLine();
                Console.Write("Personel maaşını giriniz:");
                personel.Salary = decimal.Parse(Console.ReadLine());

                switch (personel.Depertman.ToLower())
                {
                    case "muhasebe":
                        personel = new Muhasebe()
                        {
                            FirstName = personel.FirstName,
                            LastName = personel.LastName,
                            TckNo = personel.TckNo,
                            Depertman = personel.Depertman,
                            Salary = personel.Salary
                        };
                        break;
                    case "satın alma":
                        personel = new SatınAlma()
                        {
                            FirstName = personel.FirstName,
                            LastName = personel.LastName,
                            TckNo = personel.TckNo,
                            Depertman = personel.Depertman,
                            Salary = personel.Salary
                        };
                        break;
                    case "geliştirme":
                        personel = new Gelistirme()
                        {
                            FirstName = personel.FirstName,
                            LastName = personel.LastName,
                            TckNo = personel.TckNo,
                            Depertman = personel.Depertman,
                            Salary = personel.Salary
                        };
                        break;
                    case "yönetici":
                        personel = new Yönetici()
                        {
                            FirstName = personel.FirstName,
                            LastName = personel.LastName,
                            TckNo = personel.TckNo,
                            Depertman = personel.Depertman,
                            Salary = personel.Salary
                        };
                        break;
                    default:
                        Console.WriteLine("Geçersiz departman!");
                        break;
                }

                return personel;
            
            
            
        }

    }
}
