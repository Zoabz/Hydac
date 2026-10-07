<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 559636fa843e8fe17f11e68a6d600d99eb881844
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.SymbolStore;
using System.Text;
<<<<<<< HEAD

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

        public bool TjekKode(string kode)
        {
            return Kode == kode;
        }

        public static List<Medarbejder> MedarbejderListe = new List<Medarbejder>
        {
            new Medarbejder("Admin", "Admin123")
        };

        public static void OpretMedarbejder()
        {
            if (Menu.erLoggetind == true)
            {
                Console.Clear();
                Console.WriteLine("Opret Medarbejder");
                Console.WriteLine("--------------------");
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
            Console.ReadLine();
        }

        public static void ListeMedarbejder()
        {
            if (Menu.erLoggetind) { 
                Console.Clear();
                Console.WriteLine("Liste af Medarbejder");
                Console.WriteLine($"{"Brugernavn",-10}");
                Console.WriteLine(new string('-', 10));

                foreach (Medarbejder m in MedarbejderListe)
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

        public static void Login()
        {
            Console.Clear();
            Console.WriteLine("Log ind");
            Console.WriteLine("--------------------");
            if (Menu.erLoggetind == false)
            {
                Console.Write("Indtast Brugernavn: ");
                string? brugernavn = Console.ReadLine();
                Console.Write("Indtast Adgangskode: ");
                string? kode = Console.ReadLine();

                
                foreach (Medarbejder m in MedarbejderListe)
                {
                    if (m.Brugernavn == brugernavn && m.TjekKode(kode))
                    {
                        Menu.erLoggetind = true;
                        Menu.aktivMedarbejder = brugernavn;
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
            Console.Write("Enter for at komme tilbage...");
            Console.ReadLine();
        }
        
        public static void LogOut()
        {
            Menu.erLoggetind = false;
            Console.WriteLine("Du er logget ud!");
            Console.ReadLine();
            Menu.aktivMedarbejder = "";
        }



=======
using System;
=======
>>>>>>> 559636fa843e8fe17f11e68a6d600d99eb881844

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
<<<<<<< HEAD
>>>>>>> d0c158597ab168f24ce868f354b8876fd62e41d2
=======

        public static List<Medarbejder> MedarbejderListe = new List<Medarbejder>
        {
            new Medarbejder("Admin", "Admin123")
        };

        public static void OpretMedarbejder()
        {
            if (Menu.erLoggetind == true)
            {
                Console.Clear();
                Console.WriteLine("Opret Medarbejder");
                Console.WriteLine("--------------------");
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
            Console.ReadLine();
        }

        public static void ListeMedarbejder()
        {
            if (Menu.erLoggetind) { 
                Console.Clear();
                Console.WriteLine("Liste af Medarbejder");
                Console.WriteLine($"{"Brugernavn",-10}");
                Console.WriteLine(new string('-', 10));

                foreach (Medarbejder m in MedarbejderListe)
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

        public static void Login()
        {
            Console.Clear();
            Console.WriteLine("Log ind");
            Console.WriteLine("--------------------");
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
                        Menu.aktivMedarbejder = brugernavn;
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
            Console.Write("Enter for at komme tilbage...");
            Console.ReadLine();
        }
        
        public static void LogOut()
        {
            Menu.erLoggetind = false;
            Console.WriteLine("Du er logget ud!");
            Console.ReadLine();
            Menu.aktivMedarbejder = "";
        }



>>>>>>> 559636fa843e8fe17f11e68a6d600d99eb881844
    }
}
