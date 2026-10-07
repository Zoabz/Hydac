using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.SymbolStore;
using System.Text;

namespace Hydac
{
    public class Medarbejder
    {
        private string brugernavn;

        public string Brugernavn
        {
            get { return brugernavn; }
            set { brugernavn = value; }
        }

        private string kode;

        public string Kode
        {
            get { return kode; }
            set { kode = value; }
        }

        public Medarbejder(string brugernavn, string kode) {
            Brugernavn = brugernavn;
            Kode = kode;
        }

        

        public static List<Medarbejder> medarbejderliste = new List<Medarbejder>
        {
            new Medarbejder("Admin", "Admin123")
        };

        public static void OpretMedarbejder()
        {
            if (Menu.erLoggetInd == true)
            {
                Console.Clear();
                Console.WriteLine("Opret Medarbejder");
                Console.WriteLine("--------------------");
                Console.Write("Indsæt Brugernavn: ");
                string? brugernavn = Console.ReadLine();
                Console.Write("Indsæt Kode: ");
                string? kode = Console.ReadLine();

                medarbejderliste.Add(new Medarbejder(brugernavn, kode));
                Console.WriteLine("---Medarbejder oprettet---");
            }
            else
                Console.WriteLine("Du skal være logget ind!");
            Console.ReadLine();
        }

        public static void VisMedarbejderliste()
        {
            if (Menu.erLoggetInd) { 
                Console.Clear();
                Console.WriteLine("Medarbejderliste");
                Console.WriteLine($"{"Brugernavn",-10}");
                Console.WriteLine(new string('-', 10));

                foreach (Medarbejder m in medarbejderliste)
                {
                    Console.WriteLine($"{m.Brugernavn,-10}");
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Enter for at komme tilbage...");
            }
            else
                Console.WriteLine("Du skal være logget ind!");
                Console.ReadLine();
        }

        public static void LogInd()
        {
            Console.Clear();
            Console.WriteLine("Log ind");
            Console.WriteLine("--------------------");
            if (Menu.erLoggetInd == false)
            {
                Console.Write("Indtast Brugernavn: ");
                string? brugernavn = Console.ReadLine();
                Console.Write("Indtast Kode: ");
                string? kode = Console.ReadLine();

                
                foreach (Medarbejder m in medarbejderliste)
                {
                    if (m.Brugernavn == brugernavn && m.kode == kode)
                    {
                        Menu.erLoggetInd = true;
                        Menu.aktivMedarbejder = brugernavn;
                    }
                    else
                        Menu.erLoggetInd = false;
                }


                if (Menu.erLoggetInd == true)
                {
                    Console.WriteLine("Log ind korrekt ");
                }
                else
                    Console.WriteLine("Forkert brugernavn eller kode");
            }
            else
                Console.WriteLine("Du er allerede logget ind");
            Console.Write("Enter for at komme tilbage...");
            Console.ReadLine();
        }
        
        public static void LogUd()
        {
            Menu.erLoggetInd = false;
            Console.WriteLine("Du er logget ud!");
            Console.ReadLine();
            Menu.aktivMedarbejder = "";
        }



    }
}
