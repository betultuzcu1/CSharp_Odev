using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_FutbolTakımı.Abctract
{
    internal abstract class Futbolcu
    {
        public string Ad { get; set; }

        public string Soyad { get; set; }

        public string FormaNo { get; set; }

        //Abstract Property

        public abstract int SutGucu { get; set; }

        //Abstract Metots

        public abstract string Kos();

        public abstract string CalimAt();

        public abstract string PressYap();

        public abstract string Kurtar();

        public abstract string SutCek();
    }
}
