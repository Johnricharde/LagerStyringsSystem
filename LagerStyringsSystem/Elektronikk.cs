using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagerStyringsSystem
{
    public class Elektronikk : IProdukt
    {
        public string Navn {  get; set; }
        public double Pris {  get; set; }
        public int GarantiTid {  get; set; }

        public Elektronikk(string navn, double pris, int garantiTid)
        {
            Navn = navn;
            Pris = pris;
            GarantiTid = garantiTid;
        }

        public void SkrivUtInfo()
        {

        }
    }
}
