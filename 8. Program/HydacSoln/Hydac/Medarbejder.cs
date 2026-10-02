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

        public static List<Medarbejder> MedarbejderListe = new List<Medarbejder>
        {
            new Medarbejder("Admin", "Admin123")
        };

        public static void OpretMedarbejder()
        {
            Console.Clear();
            Console.WriteLine("Opret Medarbejder");
            if (Menu.erLoggetind == true)
            {
                Console.Write("Indsæt Brugernavn: ");
                string? brugernavn = Console.ReadLine();
                Console.Write("Indsæt Kode: ");
                string? kode = Console.ReadLine();

                MedarbejderListe.Add(new Medarbejder(brugernavn, kode));
                Console.WriteLine("---Bruger oprettet---");
                Menu.erLoggetind = false;
            }
            else
                Console.WriteLine("Du skal være logget ind!");
            
        }

        public static void ListeMedarbejder()
        {
            Console.Clear();
            Console.WriteLine("Liste Medarbejder");
            foreach (Medarbejder m in Medarbejder.MedarbejderListe)
            {
                Console.WriteLine($"{m.brugernavn}");
            }
        }

        public static void Login()
        {
            Console.Clear();
            Console.WriteLine("Log ind");
            if (Menu.erLoggetind == false)
            {
                Console.Write("Indtast Brugernavn: ");
                string? brugernavn = Console.ReadLine();
                Console.Write("Indtast Adgangskode: ");
                string? kode = Console.ReadLine();

                
                foreach (Medarbejder m in MedarbejderListe)
                {
                    if (m.brugernavn == brugernavn && m.kode == kode)
                    {
                        Menu.erLoggetind = true;
                    }
                    else
                        Menu.erLoggetind = false;
                }


                if (Menu.erLoggetind == true)
                {
                    Console.WriteLine("Login korrekt ");
                }
                else
                    Console.WriteLine("Forkert brugernavn eller kode");
            }
            else
                Console.WriteLine("Du er allerede logget ind");
        }
        



    }
}
