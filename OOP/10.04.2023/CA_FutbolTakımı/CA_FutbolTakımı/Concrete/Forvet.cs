using CA_FutbolTakımı.Abctract;
using CA_FutbolTakımı.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_FutbolTakımı.Concrete
{
    internal class Forvet:Futbolcu,IYetenek
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

        public string Defans()
        {
            throw new NotImplementedException();
        }

        public string Dribling()
        {
            throw new NotImplementedException();
        }

        public int FizikselGuc()
        {
            throw new NotImplementedException();
        }

        public string Frikik()
        {
            throw new NotImplementedException();
        }

        public int Hız()
        {
            throw new NotImplementedException();
        }

        public override string Kos()
        {
            return Ad + " koşuyor...";
        }

        public override string Kurtar()
        {
            return Ad + " topu kurtarmak için hamlede bulundu!";
        }

        public bool Lider()
        {
            throw new NotImplementedException();
        }

        public string Pas()
        {
            throw new NotImplementedException();
        }

        public override string PressYap()
        {
            return Ad + " press yapıyor";
        }

        public bool Sagayak()
        {
            throw new NotImplementedException();
        }

        public override string SutCek()
        {
            return Ad + " oranında şut çekti";
        }

        public int Zeka()
        {
            throw new NotImplementedException();
        }
    }
}
