using System;
using System.Collections.Generic;
using System.Text;

namespace Hydac
{
    public static class Menu
    {
        public static bool erLoggetind;
        public static string aktivMedarbejder = "";
        public static void MenuShow()
        {
            while (true)
            {
                // Vis menuen
                Console.Clear();
                Console.WriteLine("Hydac Komme-Gå-System");
                Console.WriteLine("--------------------");
                if (!Menu.erLoggetind)
                    Console.WriteLine("1. Login");
                else
                    Console.WriteLine("1. Log ud");
                Console.WriteLine("2. Opret besøg");
                Console.WriteLine("3. Opret medarbejder");
                Console.WriteLine("4. Vis medarbejder");
                Console.WriteLine("5. Vis besøg");
                Console.WriteLine("6. Tjek Ind");
                Console.WriteLine("7. Tjek Ud");
                Console.WriteLine("--------------------");

                // Input fra aktøren
                Console.Write(aktivMedarbejder + " > ");

                // Menu valg
                string? svar = Console.ReadLine();
                switch (svar) {
                    case "1":
                        if (!Menu.erLoggetind)
                            Medarbejder.Login();
                        else
                            Medarbejder.LogOut();
                        break;
                    case "2":
                        Besøg.AddBesøg();
                        break;
                    case "3":
                        Medarbejder.OpretMedarbejder();
                        break;
                    case "4":
                        Medarbejder.ListeMedarbejder();
                        break;
                    case "5":
                        Besøg.ListeBesøg();
                        break;
                    case "6":
                        Besøg.TjekInd();
                        break;
                    case "7":
                        Besøg.TjekUd();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Ukendt kommando");
                        Console.Write("Enter for at komme tilbage...");
                        Console.ReadLine();
                    break;
                }
            }
        }
    }
}
