```c#
using System;
using System.IO;

namespace NotizApp
{
    class Register
    {
        // Dateipfad
        private const string CONFIG_DATEI = @"config.txt";

        public static void benutzer()
        {
            try
            {
                Console.Clear();

                // Erstellt einen Writer und öffnet die Datei
                TextWriter textWriter = new StreamWriter(CONFIG_DATEI);

                // Nach Benutzername fragen
                string benutzername = "";
                Console.WriteLine("Geben Sie bitte Ihren Benutzernamen ein: ");
                benutzername = Console.ReadLine();
                textWriter.WriteLine(benutzername);

                bool istGleich = true;
                while (istGleich)
                {
                    // Nach Passwort fragen
                    string passwort = "";
                    Console.WriteLine("Geben Sie bitte Ihren passwort ein: ");
                    passwort = Services.passwortVerstecken();

                    // Nach Passwort Konfirmation fragen
                    string passwortNochmal = "";
                    Console.WriteLine("Geben Sie bitte Ihren passwort nochmal ein: ");
                    passwortNochmal = Services.passwortVerstecken();

                    // Prüfe, ob beiden Passwörter geleich sind
                    if (passwort != passwortNochmal)
                    {
                        Console.WriteLine("Passwort ist nicht gleich!\n");
                        Services.trenner();
                        istGleich = true;
                    }
                    else
                    {
                        // Speichere Passwort in Text-Datei
                        textWriter.WriteLine(passwortNochmal);

                        // Datum und Uhrzeit
                        textWriter.WriteLine("Der {0} hat einen Account am {1} erstellt:  ", benutzername, DateTime.Now);

                        istGleich = false;

                        Console.Clear();
                        Console.WriteLine("Sie haben sich erforgreich registert.");
                        Console.WriteLine("Starten Sie bitte das Programm erneut, damit Sie Notizen schreiben zu können.");
                        Services.trenner();
                    }
                }

                // Schließt den Stream
                textWriter.Close();
            }
            catch (Exception ex)
            {
                // Fehlermeldung
                Console.WriteLine("Fehler: " + ex.Message);
            }
        }
    }
}

```
