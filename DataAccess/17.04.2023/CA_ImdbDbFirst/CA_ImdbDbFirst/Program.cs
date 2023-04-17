using CA_ImdbDbFirst.ConsoleSpec;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_ImdbDbFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleMenu.Kullanıcı();
            while (true)
            {

                ConsoleMenu.MovieSelectMenu();

                int secim = int.Parse(Console.ReadLine());

                ConsoleMenu.SelectedMenu(secim);
            }

            //var gun = DateTime.Now.DayOfWeek.ToString();

            //Console.WriteLine(gun);

        }
    }
}
