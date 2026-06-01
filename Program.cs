using System;

namespace project_pro_oop_2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Speler speler = new Speler();
            // Try catch
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
                // Object aanmaken voor klasse ScrabbleWoord
                ScrabbleWoord woord = new ScrabbleWoord();
                woord.Tekst = speler.Tekst;
                // Polymorfisme parameters
                woord.Berekenen(speler.Naam);
            }
            catch
            {
                Console.WriteLine("Geef een geldige invoer op");
            }
        }
    }
    //abstractie: interface tekst
    interface IWoord
    {
        public string Tekst { get; set; }
    }
    //basisklasse encapsulatie via autoproperties
    class Woord : IWoord
    {
        public string Tekst { get; set; }
    }
    //overerving: speler erft Tekst van Woord
    class Speler : Woord
    {
        //autopropertie voor naam
        public string Naam { get; set; }
    }
    //overerving: ScrabbleWoord erft Tekst van Woord
    class ScrabbleWoord : Woord
    {
        private Random random;

        public ScrabbleWoord()
        {
            //CONSTRUCTOR: automatisch uitvoeren bij "new ScrabbleWoord()"
            random = new Random();
        }
        //Polymorfisme 0 parameters
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
        //Polymorfisme 1 parameter (naam)
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