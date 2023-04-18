using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CA_ImdbDbFirst.Repository;
using CA_ImdbDbFirst.Model;
using System.Runtime.Remoting.Contexts;
using System.Threading;

namespace CA_ImdbDbFirst.ConsoleSpec
{
    internal class ConsoleMenu
    {
        public static void Kullanıcı()
        {
            while(true)
            {
                try
                {
                    Console.WriteLine("IMDB uygulamasına hoş geldiniz.Lütfen giriş yapınız!");
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

        private static object date;
        ImdbDataEntities1 db=new ImdbDataEntities1();
        public static void MovieSelectMenu()
        {
            Console.WriteLine("IMDB MENU");
            Console.WriteLine("1-Filmler");
            Console.WriteLine("2-En iyi filmler");
            Console.WriteLine("3-Türe göre filmler");
            Console.WriteLine("4-Rastgele Film");

            Console.WriteLine("Lütfen bir seçim yapın.");
        }


        public static void SelectedMenu(int selected)
        {
            ImdbDataEntities1 db = new ImdbDataEntities1();

            MovieRepository movieRepository = new MovieRepository();
            switch (selected)
            {
                case 1:
                    foreach (Movy movie in movieRepository.GetAllMovy())
                    {

                        Console.WriteLine(movie.Id + " " + movie.Title);
                    }
                    break;

                case 2:
                    foreach (Movy movie in movieRepository.BestMovies())
                    {
                        Console.WriteLine(movie.Id + " " + movie.Title);
                    }

                    break;
                case 3:
                    Console.Write("Lütfen film türü giriniz:");
                    string turAdı=Console.ReadLine();
                    var sonuc = db.Genres.Where(x => x.Name.Contains(turAdı)).ToList();
                    foreach (var tur in sonuc.ToList())
                    {
                        Console.WriteLine(tur.Id+" "+tur.Name);
                    }

                    break;
                case 4:
                   
                    var gun = DateTime.Now.DayOfWeek.ToString();

                    Console.WriteLine(gun);

                    switch (gun)
                    {
                        case "Monday":
                            Console.WriteLine("Tür:Drama");
                            break;
                        case "Tuesday":
                            Console.WriteLine("Tür:Sci-Fi");
                            break;
                        case "Wednesday":
                            Console.WriteLine("Tür:Horror");
                            break;
                        case "Thursday":
                            Console.WriteLine("Tür:Comedy");
                            break;
                        case "Friday":
                            Console.WriteLine("Tür:Action");
                            break;
                        case "Saturday":
                            Console.WriteLine("Tür:Romantic");
                            break;
                    }

                    break;
                default:
                    Console.WriteLine("Yanlış seçim yaptınız!");
                    break;

            }
        }
    }
}
