using System;
using System.Collections.Generic;
namespace Hydac
{
    public class Besøg
    {
        public string Navn { get; set; }
        public string Firma { get; set; }
        public string Ansvarlig { get; set; }
        public DateTime ForventetAnkomst { get; set; }
        public DateTime ForventetAfgang { get; set; }
        public DateTime? IndTjekTid { get; set; }
        public DateTime? UdTjekTid { get; set; }
        public string Lokale { get; set; }
        public int IndtjekningsKode { get; set; }
        public string Status { get; set; }
        public bool Sikkerhedsfolder { get; set; }
        public DateTime? Date { get; set;  }
        
        public Besøg(string navn, string firma, string ansvarlig, DateTime forventetAnkomst, DateTime forventetAfgang,DateTime? date, DateTime? indtjektid,DateTime? udtjektid, string lokale, int indtjekningsKode, string status, bool sikkerhedsfolder)
        {
            Navn = navn;
            Firma = firma;
            Ansvarlig = ansvarlig;
            ForventetAnkomst = forventetAnkomst;
            ForventetAfgang = forventetAfgang;
            Date = date;
            IndTjekTid = indtjektid;
            UdTjekTid = udtjektid;
            Lokale = lokale;
            IndtjekningsKode = indtjekningsKode;
            Status = status;
            Sikkerhedsfolder = sikkerhedsfolder;
            
            
        }

        public static List<Besøg> BesøgListe = new List<Besøg>();

        public static void AddBesøg()
        {
            if (Menu.erLoggetind == true)
            {
                Console.WriteLine("Opret Besøg");
                Console.Write("Indtast Navn: ");
                string? navn = Console.ReadLine();
                Console.Write("Indtast Firma: ");
                string? firma = Console.ReadLine();
                Console.Write("Indtast Dato: ");
                DateTime date = Convert.ToDateTime(Console.ReadLine());
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

                DateTime indtjektid = Convert.ToDateTime(null);
                DateTime udtjektid = Convert.ToDateTime(null);
                string status = "Ikke Tjekket Ind";
                bool sikkerhedsfolder = false;
                BesøgListe.Add(new Besøg(navn, firma, ansvarlig, forventetankomst, forventetafgang, date, indtjektid, udtjektid, lokale, indtjekningskode, status, sikkerhedsfolder));
            }
            else {
                Console.WriteLine("Du skal være logget ind!");
                Console.ReadLine();
            }
                
        }

        public static void ListeBesøg()
        {
            if (Menu.erLoggetind)
            {
                Console.Clear();
                Console.WriteLine("Liste Besøg");
                Console.WriteLine($"{"Navn",-12}" +
                        $"{"Firma",-14}" +
                        $"{"Ankomst",-8}" +
                        $"{"Afgang",-8}" +
                        $"{"Lokale",-8}" +
                        $"{"Ansvarlig",-15}" +
                        $"{"Status",-18}" +
                        $"{"Dato",-10}"+
                        $"{"Indtjek",-12}" +
                        $"{"Udtjek",-12}" +
                        $"{"Kode",-10}" +
                        $"{"SF",-6}");
                        
                Console.WriteLine(new string('-', 133));

                foreach (Besøg b in BesøgListe)
                {
                    Console.WriteLine($"{b.Navn,-12}" +
                        $"{b.Firma,-14}" +
                        $"{b.ForventetAnkomst,-8:HH:mm}" +
                        $"{b.ForventetAfgang,-8:HH:mm}" +
                        $"{b.Lokale,-8}" +
                        $"{b.Ansvarlig,-15}" +
                        $"{b.Status,-18}" +
                        $"{b.Date,-10:dd:MM:yy}" +
                        $"{b.IndTjekTid,-12:HH:mm}" +
                        $"{b.UdTjekTid,-12:HH:mm}" +
                        $"{b.IndtjekningsKode,-10}" +
                        $"{b.Sikkerhedsfolder,-16}");
                }
            }
            else
                Console.WriteLine("Du skal være logget ind!");
            Console.ReadLine();
        }

        public static void TjekInd()
        {
            Console.Clear();
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
                    b.IndTjekTid = DateTime.Now;
                    Console.Write("Har du modtaget sikkerhedsfolder? ja/nej: ");
                    string? svar = Console.ReadLine().ToLower();
                    if (svar == "ja")
                        b.Sikkerhedsfolder = true;
                    else
                        b.Sikkerhedsfolder = false;

                }
            }
            Console.Write("Enter for at komme tilbage...");
            Console.ReadLine();
        }

        public static void TjekUd()
        {
            Console.Clear();
            Console.Write("Indsæt indtjekningskode: ");
            if (!int.TryParse(Console.ReadLine(), out int indtjekningskode))
            {
                Console.Clear();
                Console.WriteLine("Prøv igen");
                Console.Write("Indsæt indtjekningskode: ");
            }
            foreach (Besøg b in BesøgListe)
            {
                if (b.IndtjekningsKode == indtjekningskode && b.Status == "Tjekket Ind")
                {
                    Console.Clear();
                    b.Status = "Tjekket Ud";
                    b.UdTjekTid = DateTime.Now;

                }
            }
            Console.Write("Enter for at komme tilbage...");
            Console.ReadLine();
        }
    }
    }

