<<<<<<< HEAD
<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
namespace Hydac
{
    public class Besøg
    {
        public string GæstNavn { get; set; }
        public string Firma { get; set; }
        public string Ansvarlig { get; set; }
        public DateTime ForventetAnkomsttid { get; set; }
        public DateTime ForventetAfgangstid { get; set; }
        public DateTime? Indtjekningstid { get; set; }
        public DateTime? Udtjekningstid { get; set; }
        public string Lokale { get; set; }
        public int Indtjekningskode { get; set; }
        public string Status { get; set; }
        public bool SikkerhedsfolderModtaget { get; set; }
        public DateTime? Dato { get; set;  }
        
        public Besøg(string gæstNavn, string firma, string ansvarlig, DateTime forventetAnkomsttid, DateTime forventetAfgangstid,DateTime? dato, DateTime? indtjekningstid,DateTime? udtjekningstid, string lokale, int indtjekningskode, string status, bool sikkerhedsfolderModtaget)
        {
            GæstNavn = gæstNavn;
            Firma = firma;
            Ansvarlig = ansvarlig;
            ForventetAnkomsttid = forventetAnkomsttid;
            ForventetAfgangstid = forventetAfgangstid;
            Dato = dato;
            Indtjekningstid = indtjekningstid;
            Udtjekningstid = udtjekningstid;
            Lokale = lokale;
            Indtjekningskode = indtjekningskode;
            Status = status;
            SikkerhedsfolderModtaget = sikkerhedsfolderModtaget;
            
            
        }

        public static List<Besøg> gæsteliste = new List<Besøg>();

        private static DateTime LæsDato(string i)
        {
            while (true)
            {
                try
                {
                    Console.Write(i);
                    return Convert.ToDateTime(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ugyldigt format (DD-MM-YYYY eller HH:mm) Prøv igen.");
                }
            }
        }

        public static void OpretBesøg()
        {
            if (Menu.erLoggetInd == true)
            {
                Console.Clear();
                Console.WriteLine("Opret Besøg");
                Console.Write("Indtast Navn: ");
                string? gæstNavn = Console.ReadLine();
                Console.Write("Indtast Firma: ");
                string? firma = Console.ReadLine();

                DateTime dato = LæsDato("Indtast Dato: ");
                DateTime forventetAnkomsttid = LæsDato("Indtast Forventet Ankomsttid: ");
                DateTime forventetAfgangstid = LæsDato("Indtast Forventet Afgangstid: ");

                Console.Write("Indtast Lokale: ");
                string? lokale = Console.ReadLine();
                Console.Write("Indtast Ansvarlig: ");
                string? ansvarlig = Console.ReadLine();

                Random rnd = new Random();
                int indtjekningskode = rnd.Next(10_000_000, 100_000_000);

                DateTime indtjekningstid = DateTime.MinValue;
                DateTime udtjekningstid = DateTime.MinValue;
                string status = "Ikke Tjekket Ind";
                bool sikkerhedsfolderModtaget = false;
                gæsteliste.Add(new Besøg(gæstNavn, firma, ansvarlig, forventetAnkomsttid, forventetAfgangstid, dato, indtjekningstid, udtjekningstid, lokale, indtjekningskode, status, sikkerhedsfolderModtaget));
            }
            else
            {
                Console.WriteLine("Du skal være logget ind!");
                Console.ReadLine();
            }
        }

        public static void VisGæsteliste()
        {
            if (Menu.erLoggetInd)
            {
                Console.Clear();
                Console.WriteLine("Gæsteliste");
                Console.WriteLine($"{"Navn",-12}" +
                        $"{"Firma",-15}" +
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

                foreach (Besøg b in gæsteliste)
                {
                    Console.WriteLine($"{b.GæstNavn,-12}" +
                        $"{b.Firma,-15}" +
                        $"{b.ForventetAnkomsttid,-8:HH:mm}" +
                        $"{b.ForventetAfgangstid,-8:HH:mm}" +
                        $"{b.Lokale,-8}" +
                        $"{b.Ansvarlig,-15}" +
                        $"{b.Status,-18}" +
                        $"{b.Dato,-10:dd:MM:yy}" +
                        $"{b.Indtjekningstid,-12:HH:mm}" +
                        $"{b.Udtjekningstid,-12:HH:mm}" +
                        $"{b.Indtjekningskode,-10}" +
                        $"{b.SikkerhedsfolderModtaget,-16}");
                }
            }
            else
                Console.WriteLine("Du skal være logget ind!");
            Console.ReadLine();
        }

        public static Besøg? FindBesøg(int indtjekningskode)
        {
            foreach (Besøg b in gæsteliste)
            {
                if (b.Indtjekningskode == indtjekningskode)
                    return b;
            }
            return null;
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
            Besøg? b = FindBesøg(indtjekningskode);
            if (b != null && b.Status == "Ikke Tjekket Ind")
            {
                Console.Clear();
                Console.Write("Har du modtaget sikkerhedsfolder? ja/nej: ");
                string? svar = Console.ReadLine().ToLower();
                b.TjekInd(svar == "ja");
            }
            Console.Write("Enter for at komme tilbage...");
            Console.ReadLine();
        }

        public static void TjekGæstUd()
        {
            Console.Clear();
            Console.Write("Indsæt indtjekningskode: ");
            if (!int.TryParse(Console.ReadLine(), out int indtjekningskode))
            {
                Console.Clear();
                Console.WriteLine("Prøv igen");
                Console.Write("Indsæt indtjekningskode: ");
            }
            Besøg? b = FindBesøg(indtjekningskode);
            if (b != null && b.Status == "Tjekket Ind")
            {
                Console.Clear();
                b.TjekUd();
            }
            Console.Write("Enter for at komme tilbage...");
            Console.ReadLine();
        }

        public void TjekInd(bool sikkerhedsfolderModtaget)
        {
            Status = "Tjekket Ind";
            Indtjekningstid = DateTime.Now;
            SikkerhedsfolderModtaget = sikkerhedsfolderModtaget;
        }

        public void TjekUd()
        {
            Status = "Tjekket Ud";
            Udtjekningstid = DateTime.Now;
        }
    }
}

=======
using System;

=======
﻿using System;
using System.Collections.Generic;
>>>>>>> 559636fa843e8fe17f11e68a6d600d99eb881844
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
                Console.Clear();
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
                        $"{"Firma",-15}" +
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
                        $"{b.Firma,-15}" +
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
<<<<<<< HEAD
}
>>>>>>> d0c158597ab168f24ce868f354b8876fd62e41d2
=======
    }

>>>>>>> 559636fa843e8fe17f11e68a6d600d99eb881844
