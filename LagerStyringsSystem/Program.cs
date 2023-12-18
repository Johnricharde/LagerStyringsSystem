namespace LagerStyringsSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lager lager = new();

            var telefon = new Elektronikk("Telefon", 199.99, 12);
            var mikrobølgeovn = new Elektronikk("Mikrobølgeovn", 19.60, 24);

            var banan = new Matvare("Banan", 15, "25/12/23");
            var fiskeboller = new Matvare("Fiskeboller", 25, "20/12/24");

            var bukse = new Klær("Bukse", 199.60, "Large");
            var jakke = new Klær("Jakke", 269.60, "small");

            lager.LeggTil(telefon);
            lager.LeggTil(mikrobølgeovn);
            lager.LeggTil(banan);
            lager.LeggTil(fiskeboller);
            lager.LeggTil(bukse);
            lager.LeggTil(jakke);

            lager.Fjern(fiskeboller);
            lager.Fjern(mikrobølgeovn);

            lager.SkrivUtAlleProdukter(lager.produktListe);
        }
    }
}
