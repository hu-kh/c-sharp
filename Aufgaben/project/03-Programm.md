```c#
using System;

namespace NotizApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ändere Titel 
            Console.Title = "NotizApp v1.0.0";

            // Ändere die Farbe
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;

            Services.trenner();
            Console.WriteLine(".......................... NotizApp v1.0.0 ............................");
            Services.trenner();
            Console.WriteLine("\n");

            Console.WriteLine("Bitte melden Sie sich an, um die App zu benutzen.\n");

            Console.WriteLine("Bitte treffe eine Option ein:");
            Console.WriteLine(" <1> Anmelden");
            Console.WriteLine(" <2> Registieren");
            Services.trenner();

            try
            {
                int whal = Convert.ToInt32(Console.ReadLine());
                switch (whal)
                {
                    case 1:
                        // Zum anmelden
                        Anmeldung anmeldeinfo = new Anmeldung();
                        anmeldeinfo.anmeldung();
                        break;
                    case 2:
                        // Zum Registieren
                        Register.benutzer();
                        break;
                    default:
                        Console.WriteLine("Nur Zahl <1> oder <2>");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}

```
