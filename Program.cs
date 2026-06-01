using System;

namespace project_pro_oop_2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Speler speler = new Speler();
            try
            {
                Console.WriteLine("INPUT");
                Console.WriteLine("************************");
                Console.WriteLine("Geef je naam in");
                speler.Naam = Console.ReadLine();
                Console.WriteLine("Geef een woord of zin in:");
                speler.Tekst = Console.ReadLine();
                Console.WriteLine("************************");
                Console.WriteLine("OUTPUT");

                ScrabbleWoord woord = new ScrabbleWoord();
                woord.Tekst = speler.Tekst;
                woord.Berekenen(speler.Naam);
            }
            catch
            {
                Console.WriteLine("Geef een geldige invoer op");
            }
        }
    }

    interface IWoord
    {
        public string Tekst { get; set; }
    }

    class Woord : IWoord
    {
        public string Tekst { get; set; }
    }

    class Speler : Woord
    {
        public string Naam { get; set; }
    }

    class ScrabbleWoord : Woord
    {
        private Random random;

        public ScrabbleWoord()
        {
            random = new Random();
        }

        public void Berekenen()
        {
            int totaalAantalKarakters = 0;
            int totaalWaardeKarakters = 0;

            foreach (char c in Tekst)
            {
                totaalAantalKarakters++;
                totaalWaardeKarakters += random.Next(0, 26);
            }

            Console.WriteLine("Aantal karakters: " + totaalAantalKarakters);
            Console.WriteLine("Totale waarde: " + totaalWaardeKarakters);
        }

        public void Berekenen(string naamGebruiker)
        {
            int totaalAantalKarakters = 0;
            int totaalWaardeKarakters = 0;

            foreach (char c in Tekst)
            {
                totaalAantalKarakters++;
                totaalWaardeKarakters += random.Next(0, 26);
            }

            Console.WriteLine(naamGebruiker + ", aantal karakters: " + totaalAantalKarakters);
            Console.WriteLine(naamGebruiker + ", totale waarde: " + totaalWaardeKarakters);
        }
    }
}