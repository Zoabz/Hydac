using System;
using System.Collections.Generic;
using System.Text;

namespace Hydac
{
    public static class Menu
    {
        public static bool erLoggetInd;
        public static string aktivMedarbejder = "";
        public static void MenuShow()
        {
            while (true)
            {
                // Vis menuen
                Console.Clear();
                Console.WriteLine("HYDAC Komme-gå-system");
                Console.WriteLine("--------------------");
                if (!Menu.erLoggetInd)
                    Console.WriteLine("1. Log ind");
                else
                    Console.WriteLine("1. Log ud");
                Console.WriteLine("2. Opret besøg");
                Console.WriteLine("3. Opret medarbejder");
                Console.WriteLine("4. Vis medarbejderliste");
                Console.WriteLine("5. Vis gæsteliste");
                Console.WriteLine("6. Tjek gæst ind");
                Console.WriteLine("7. Tjek gæst ud");
                Console.WriteLine("--------------------");

                // Input fra aktøren
                Console.Write(aktivMedarbejder + " > ");

                // Menu valg
                string? svar = Console.ReadLine();
                switch (svar) {
                    case "1":
                        if (!Menu.erLoggetInd)
                            Medarbejder.LogInd();
                        else
                            Medarbejder.LogUd();
                        break;
                    case "2":
                        Besøg.OpretBesøg();
                        break;
                    case "3":
                        Medarbejder.OpretMedarbejder();
                        break;
                    case "4":
                        Medarbejder.VisMedarbejderliste();
                        break;
                    case "5":
                        Besøg.VisGæsteliste();
                        break;
                    case "6":
                        Besøg.TjekInd();
                        break;
                    case "7":
                        Besøg.TjekGæstUd();
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
