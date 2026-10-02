using System;
using System.Collections.Generic;
using System.Text;

namespace Hydac
{
    public class Besøg
    {
        public string Navn { get; set; }
        public string Firma { get; set; }
        public string Ansvarlig { get; set; }
        public DateTime ForventetAnkomst { get; set; }
        public DateTime ForventetAfgang { get; set; }
        public string Lokale { get; set; }
        public int IndtjekningsKode { get; set; }
        public bool Status { get; set; }
        public bool Sikkerhedsfolder { get; set; }


        public Besøg(string navn, string firma, string ansvarlig, DateTime forventetAnkomst, DateTime forventetAfgang, string lokale, int indtjekningsKode, bool status, bool sikkerhedsfolder)
        {
            Navn = navn;
            Firma = firma;
            Ansvarlig = ansvarlig;
            ForventetAnkomst = forventetAnkomst;
            ForventetAfgang = forventetAfgang;
            Lokale = lokale;
            IndtjekningsKode = indtjekningsKode;
            Status = status;
            Sikkerhedsfolder = sikkerhedsfolder;
        }

        public static List<Besøg> BesøgListe = new List<Besøg>();
        
        public static void AddBesøg()
        {
            Console.WriteLine("Opret Besøg");
            Console.Write("Indtast Navn: ");
            string? navn = Console.ReadLine();
            Console.Write("Indtast Firma: ");
            string? firma = Console.ReadLine();
            Console.WriteLine("Indtast Forventet Ankomst: ");
            DateTime forventetankomst = Console.ReadLine();
            Console.WriteLine("Indtast Forventet Afgang: ");
            DateTime forventetafgang = Console.ReadLine();
            Console.WriteLine("Indtast Lokale: ");
            string? lokale = Console.ReadLine();
            Console.WriteLine("Indtast Ansvarlig: ");
            string? ansvarlig = Console.ReadLine();

            Random rnd = new Random();
            int indtjekningskode = rnd.Next(10_000_000, 100_000_000);

            string status = "Ikke Tjekke Ind";
            bool sikkerhedsfolder = false;
            return new Besøg(navn, firma, forventetankomst, forventetafgang, lokale, ansvarlig, indtjekningskode, status, sikkerhedsfolder);

        }
    }
}
