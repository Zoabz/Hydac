using Microsoft.VisualBasic.FileIO;
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
        public DateTime? StatusTid { get; set; }
        public string Lokale { get; set; }
        public int IndtjekningsKode { get; set; }
        public string Status { get; set; }
        public bool Sikkerhedsfolder { get; set; }
        
        public Besøg(string navn, string firma, string ansvarlig, DateTime forventetAnkomst, DateTime forventetAfgang, DateTime? statusTid, string lokale, int indtjekningsKode, string status, bool sikkerhedsfolder)
        {
            Navn = navn;
            Firma = firma;
            Ansvarlig = ansvarlig;
            ForventetAnkomst = forventetAnkomst;
            ForventetAfgang = forventetAfgang;
            StatusTid = statusTid;
            Lokale = lokale;
            IndtjekningsKode = indtjekningsKode;
            Status = status;
            Sikkerhedsfolder = sikkerhedsfolder;
        }

        public static List<Besøg> BesøgListe = new List<Besøg> {
            new Besøg("Mikkel", "Mikkels firma", "John ansvarlig", new DateTime(2026,10,08,12,00,00), new DateTime(2026,10,08,17,00,00), new DateTime(2026,10,08,14,02,00), "XC01", 29253699, "Ikke Tjekket Ind", false)
        };
        
        public static void AddBesøg()
        {
            Console.WriteLine("Opret Besøg");
            Console.Write("Indtast Navn: ");
            string? navn = Console.ReadLine();
            Console.Write("Indtast Firma: ");
            string? firma = Console.ReadLine();
            Console.Write("Indtast Forventet Ankomst: ");
            DateTime forventetankomst = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Indtast Forventet Afgang: ");
            DateTime forventetafgang = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Indtast Lokale: ");
            string? lokale = Console.ReadLine();
            Console.Write("Indtast Ansvarlig: ");
            string? ansvarlig = Console.ReadLine();

            Random rnd = new Random();
            int indtjekningskode = rnd.Next(10_000_000, 100_000_000);

            DateTime statusTid = Convert.ToDateTime(null);
            string status = "Ikke Tjekket Ind";
            bool sikkerhedsfolder = false;
            BesøgListe.Add(new Besøg(navn, firma, ansvarlig, forventetankomst, forventetafgang, statusTid, lokale, indtjekningskode, status, sikkerhedsfolder));
        }

        public static void ListeBesøg()
        {
            Console.Clear();
            Console.WriteLine("Liste Besøg");
            Console.WriteLine($"{"Navn",-12}{"Firma",-18}{"Ankomst",-8}{"Afgang",-8}{"Lokale",-8}{"Ansvarlig",-16}{"Status",-18}{"Indtjekningstid",-18}{"Udtjekningstid",-18}{"Kode",-10}{"Sikkerhedsfolder",-16}");
            Console.WriteLine(new string('-', 98+16));

            foreach (Besøg b in BesøgListe)
            {
                Console.WriteLine($"{b.Navn,-12}{b.Firma,-18}{b.ForventetAnkomst,-8:HH:mm}{b.ForventetAfgang,-8:HH:mm}{b.Lokale,-8}{b.Ansvarlig,-16}{b.Status,-18}{b.StatusTid,-18}{b.StatusTid,-18}{b.IndtjekningsKode,-10}{b.Sikkerhedsfolder,-16}");
            }
        }

        public static void TjekInd()
        {
  


            Console.Write("Indsæt indtjekningskode: ");
            if (!int.TryParse(Console.ReadLine(), out int indtjekningskode)) {
                Console.Clear();
                Console.WriteLine("Prøv igen");
                Console.Write("Indsæt indtjekningskode: ");
            }
            foreach (Besøg b in BesøgListe)
            {
                if(b.IndtjekningsKode == indtjekningskode && b.Status == "Ikke Tjekket Ind")
                {
                    Console.Clear();
                    b.Status = "Tjekket Ind";
                    b.TjekIndTid = DateTime.Now;

                }
            }
        }

        public static void TjekUd()
        {
            Console.Write("Indsæt indtjekningskode: ");
        }
    }
}
