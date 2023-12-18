using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagerStyringsSystem
{
    public class Lager
    {
        public List<IProdukt> produktListe = new();

        public void LeggTil(IProdukt produkt)
        {
            produktListe.Add(produkt);
        }
        public void Fjern(IProdukt produkt)
        {
            produktListe.Remove(produkt);
        }
        public void SkrivUtAlleProdukter(List<IProdukt> produktListe)
        {
            for (int i = 0; i < produktListe.Count; i++)
            {
                Console.WriteLine($"[{i+1}] Produkt: {produktListe[i].Navn}\n    Pris: {produktListe[i].Pris}");
            }
        }
    }
}
