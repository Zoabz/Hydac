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
                Console.Clear();
                Console.WriteLine("Hydac Komme-Gå-System");
                Console.WriteLine("--------------------");
                Console.WriteLine("1. Login");
                Console.WriteLine("2. Opret besøg");
                Console.WriteLine("3. Opret medarbejder");
                Console.WriteLine("4. Vis medarbejder");
                Console.WriteLine("5. Vis besøg");
                Console.WriteLine("--------------------");
                Console.Write(aktivMedarbejder + " > ");
                string? svar = Console.ReadLine();
                switch (svar) {
                    case "1":
                        Medarbejder.Login();
                        Console.Write("Enter for at komme tilbage...");
                        Console.ReadLine();
                        break;
                    case "2":
                        Besøg.AddBesøg();
                        break;
                    case "3":
                        Console.Clear();
                        Medarbejder.OpretMedarbejder();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Write("Enter for at komme tilbage...");
                        Console.ReadLine();
                        break;
                    case "4":
                        Console.Clear();
                        Medarbejder.ListeMedarbejder();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Write("Enter for at komme tilbage...");
                        Console.ReadLine();
                        break;
                    case "5":
                        Besøg.ListeBesøg();
                        Console.ReadLine();
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
