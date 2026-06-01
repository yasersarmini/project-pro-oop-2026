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

    }
}