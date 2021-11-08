using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPJavista
{
    class Clovek
    {
        protected double unava = 0;
        protected string jmeno;
        protected int vek;

        public Clovek(string celeJmeno, int zadanyVek)
        {
            jmeno = celeJmeno;
            vek = zadanyVek;

        }
        public void Behej(int pocetKilometru)
        {
            if (unava >= 20)
            {
                Console.WriteLine("Jsem příliš unavený");
                return;
            }
            if ((unava > 0) || (unava < 20))
            {
                unava = unava + pocetKilometru;
            }
        }
        public void Odpocivej(int pocetHodin)
        {
            if (unava < 0)
            {
                unava = 0;
            }
            unava = unava - (pocetHodin * 10);
        }
        public override string ToString()
        {
            return String.Format("{0} ({1})", jmeno, vek);
        }
    }
}
