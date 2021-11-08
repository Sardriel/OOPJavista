using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPJavista
{
    class Javista:Clovek
    {
        public string ide;
        public Javista(string celeJmeno, int vek, string ide): base (celeJmeno, vek)
        {
            this.ide = ide;
        }

        public void Programuj(double pocetRadku)
        {
            if ((pocetRadku == 10) && (unava < 20))
            {
                unava++;
                Console.WriteLine("{0}", unava);
            }
            else if (unava >= 20)
            {
                Console.WriteLine("Jsem příliš unavený, abych programoval");
            } 
            else
            {
                unava = unava + (pocetRadku / 10);
            }
           
        }
    }
}
