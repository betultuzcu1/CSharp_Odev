using CA_FutbolTakımı.Abctract;
using CA_FutbolTakımı.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_FutbolTakımı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //İlk 11

            Kaleci kaleci = new Kaleci();

            kaleci.Ad = "Altay";
            kaleci.FormaNo = "1";
            kaleci.SutGucu = 90;

            //Defans
            Defans defans1 = new Defans();
            defans1.Ad = "Talha";
            defans1.FormaNo = "3";
           

            Defans defans2 = new Defans();
            defans2.Ad = "Arif";
            defans2.FormaNo = "5";

            Defans defans3 = new Defans();
            defans3.Ad = "Ata";
            defans3.FormaNo = "6";

            Defans defans4 = new Defans();
            defans4.Ad = "Berke";
            defans4.FormaNo = "2";

            //Orta Saha

            OrtaSaha ortaSaha1 = new OrtaSaha();
            ortaSaha1.Ad = "Murat";
            ortaSaha1.FormaNo = "8";

            OrtaSaha ortaSaha2 = new OrtaSaha();
            ortaSaha2.Ad = "Barış";
            ortaSaha2.FormaNo = "14";

            OrtaSaha ortaSaha3 = new OrtaSaha();
            ortaSaha3.Ad = "Yağız";
            ortaSaha3.FormaNo = "7";


            //Forvet
            Forvet forvet1 = new Forvet();
            forvet1.Ad = "Tuğçe";
            forvet1.FormaNo = "10";


            Forvet forvet2 = new Forvet();
            forvet2.Ad = "Betül";
            forvet2.FormaNo = "11";

            Forvet forvet3 = new Forvet();
            forvet3.Ad = "Yasemin";
            forvet3.FormaNo = "17";

            List<Futbolcu> fcBilge = new List<Futbolcu>();

            fcBilge.Add(kaleci);
            fcBilge.Add(defans1);
            fcBilge.Add(defans2);
            fcBilge.Add(defans3);
            fcBilge.Add(defans4);
            fcBilge.Add(ortaSaha1);
            fcBilge.Add(ortaSaha2);
            fcBilge.Add(ortaSaha3);
            fcBilge.Add(forvet1);
            fcBilge.Add(forvet2);
            fcBilge.Add(forvet3);


            foreach (Futbolcu futbolcu in fcBilge)
            {
                Console.WriteLine(futbolcu.Ad + " " + futbolcu.FormaNo);
            }


            Console.Read();
        }
    }
}
