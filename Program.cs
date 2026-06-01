using System;

namespace project_pro_oop_2026
{
    internal class Program
    {
        static void Main(string[] args)
        {

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
    }
}