using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagerStyringsSystem
{
    public class Matvare : IProdukt
    {
        public string Navn { get; set; }
        public double Pris { get; set; }
        public string UtløpsDato { get; set; }

        public Matvare(string navn, int pris, string utløpsDato)
        {
            Navn = navn;
            Pris = pris;
            UtløpsDato = utløpsDato;
        }

        public void SkrivUtInfo()
        {

        }
    }
}
