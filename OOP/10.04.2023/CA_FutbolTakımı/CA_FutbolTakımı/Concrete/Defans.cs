using CA_FutbolTakımı.Abctract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_FutbolTakımı.Concrete
{
    internal class Defans:Futbolcu
    {
        private int _sutGucu;
        public override int SutGucu
        {
            get
            {
                return _sutGucu;
            }
            set
            {
                if (value > 50)
                {
                    _sutGucu = 30;

                }
            }
        }

        public override string CalimAt()
        {
            return Ad + " çalım attı";
        }

        public override string Kos()
        {
            return Ad + " koşuyor...";
        }

        public override string Kurtar()
        {
            return Ad + " topu kurtarmak için hamlede bulundu!";
        }

        public override string PressYap()
        {
            return Ad + " press yapıyor";
        }

        public override string SutCek()
        {
            return Ad + " oranında şut çekti";
        }
    }
}
