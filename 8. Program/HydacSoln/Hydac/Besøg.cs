using System;
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

        public static List<Besøg> besøgsliste = new List<Besøg>
        {
            new Besøg("John", "Johns firma", "Frederik", DateTime.Now, DateTime.Today, DateTime.Now, null, null, "XC01", 94502354, "Ikke Tjekket Ind", false)
        };

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
                besøgsliste.Add(new Besøg(gæstNavn, firma, ansvarlig, forventetAnkomsttid, forventetAfgangstid, dato, indtjekningstid, udtjekningstid, lokale, indtjekningskode, status, sikkerhedsfolderModtaget));
            }
            else
            {
                Console.WriteLine("Du skal være logget ind!");
                Console.ReadLine();
            }
        }

        public static void VisBesøgsliste()
        {
            if (Menu.erLoggetInd)
            {
                Console.Clear();
                Console.WriteLine("Besøgsliste");
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

                foreach (Besøg b in besøgsliste)
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
            foreach (Besøg b in besøgsliste)
            {
                if (b.Indtjekningskode == indtjekningskode)
                    return b;
            }
            return null;
        }

        public static void TjekInd()
        {
            Console.Write("Indsæt indtjekningskode: ");
            if (!int.TryParse(Console.ReadLine(), out int indtjekningskode)) {
                Console.Write("Fandt ingen matchende kode...");
            }
            Besøg? b = FindBesøg(indtjekningskode);
            if (b != null && b.Status == "Ikke Tjekket Ind")
            {
                Console.Write("Har du modtaget sikkerhedsfolder? ja/nej: ");
                string? svar = Console.ReadLine().ToLower();
                b.TjekInd(svar == "ja");
                Console.Write("Enter for at komme tilbage...");
            }

            Console.ReadLine();
        }

        public static void TjekGæstUd()
        {
            Console.Write("Indsæt indtjekningskode: ");
            if (!int.TryParse(Console.ReadLine(), out int indtjekningskode))
            {
                Console.Write("Fandt ingen matchende kode...");
            }
            Besøg? b = FindBesøg(indtjekningskode);
            if (b != null && b.Status == "Tjekket Ind")
            {
                b.TjekUd();
                Console.WriteLine("Du er tjekket ud!");

            }
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

