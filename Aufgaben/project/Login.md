```c#
using System;

namespace NotizApp
{
    class Anmeldung
    {
        public void anmeldung()
        {
            // Variable deklaration
            string benutzerName = "";
            string passwort = "";

            // Eingabe des Benutzers
            Console.Write("Benutzername: ");
            benutzerName = Console.ReadLine();

            // Eingabe des Passworts
            Console.Write("Passwort: ");
            passwort = passwortVerstecken();
            Console.WriteLine("\n");

            // Prüft den Benutzername und das Passwort
            if (benutzerName == "user" && passwort == "pass")
            {
                // Rufe die Hauptanwendung auf
                NotizApp.app();
            }
            else
            {
                // Fehlermeldung 
                Console.WriteLine("Bitte versuchen Sie es erneut.");
                Console.WriteLine("Hinweis: [ Benutzername => us** ] und [ Passwort => pa**** ]");
            }
        }

        private string passwortVerstecken()
        {
            // Variable deklaration
            string passwort = "";

            // Neues Objekt von Klasse erstellen
            ConsoleKeyInfo tasteInfo;

            // Zeige Sternchen statt Passwort 
            do
            {
                tasteInfo = Console.ReadKey(true);
                // Ignoriert Enter als auch Leerzeile
                if (tasteInfo.Key != ConsoleKey.Backspace && tasteInfo.Key != ConsoleKey.Enter)
                {
                    passwort += tasteInfo.KeyChar;
                    Console.Write("*");
                }
                else
                {
                    if (tasteInfo.Key == ConsoleKey.Backspace && passwort.Length > 0)
                    {
                        // Lösche den letzten Buchstaben, falls leerzeile gedrückt wird 
                        passwort = passwort.Substring(0, (passwort.Length - 1));
                        Console.Write("\b \b");
                    }
                }
            }

            // Passwortabfrage nach Enter beenden
            while (tasteInfo.Key != ConsoleKey.Enter);
            Console.WriteLine();

            // Rückgabe Wert
            return passwort;
        }
    }
}

```
