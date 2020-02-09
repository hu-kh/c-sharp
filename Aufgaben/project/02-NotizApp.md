```c#
using System;
using System.IO;

namespace NotizApp
{
    class NotizApp
    {
        // Dateipfad
        private const string DATEI_NAME = @"notes.txt";

        public static void app()
        {
            // Bildschirm löschen
            Console.Clear();

            // Funktionen aufrufen
            dateiErstellen();
            dateiLesen();

            // Infotext
            Console.WriteLine("Drücken Sie bitte eine beliebige Taste ein, um das Programm zu beenden.");
            Console.ReadKey();
        }

        private static void dateiErstellen()
        {
            try
            {
                // Erstellt einen Writer und öffnet die Datei
                TextWriter textWriter = new StreamWriter(DATEI_NAME, true);

                // Funktion aufrufen und Eintrag erstellen
                notizSchreiben(textWriter);

                // Schließt den Stream
                textWriter.Close();
            }
            catch (Exception ex)
            {
                // Fehlermeldung
                Console.WriteLine("Fehler: " + ex.Message);
            }
        }

        private static void dateiLesen()
        {
            // Bildschirm löschen
            Console.Clear();

            Console.WriteLine("\nAlle Notizen von Ihnen.");
            Services.trenner('*');

            try
            {
                // Erstellt einen Reader und öffnet die Datei
                TextReader textReader = new StreamReader(DATEI_NAME);

                // Liest eine Zeile
                Console.WriteLine(textReader.ReadToEnd());

                // Schließt den Stream
                textReader.Close();
            }
            catch (Exception ex)
            {
                // Fehlermeldung
                Console.WriteLine("Fehler: " + ex.Message);
            }

            Services.trenner();
        }

        private static async void notizSchreiben(TextWriter textWriter)
        {
            // Variable deklaration
            char leerzeile = ' ';
            bool istWar = true;
            string titel = "", beschreibung = "";

            try
            {
                // Infotext
                Console.WriteLine("\nSchreiben Sie Notiz/en");

                // Notiz schreiben sobald war ist
                while (istWar == true)
                {
                    // Titel
                    Console.Write("Titel: ");
                    titel = Console.ReadLine();
                    await textWriter.WriteLineAsync("[Titel] " + titel + Convert.ToString(leerzeile));

                    // Beschreibung
                    Console.Write("Beschreibung: ");
                    beschreibung = Console.ReadLine();
                    await textWriter.WriteLineAsync("[Beschreibung] " + beschreibung + Convert.ToString(leerzeile));

                    // Datum und Uhrzeit
                    await textWriter.WriteLineAsync("[Datum und Uhrzeit] " + DateTime.Now);

                    // Neue Zeile
                    string zeilenumbruch = "\n";
                    await textWriter.WriteLineAsync(zeilenumbruch);

                    // Eintrag wiederholen
                    Services.trenner();

                    // Infotext
                    Console.WriteLine("Möchten Sie noch eine Notiz schreiben? <Ja = 1> oder <Nein = 2>");
                    int bestätigen = Convert.ToInt32(Console.ReadLine());

                    // Menü auswählen
                    switch (bestätigen)
                    {
                        case 1: istWar = true; break;
                        case 2: istWar = false; break;
                        default: Console.WriteLine("Bitte nur <1> oder <2>."); break;
                    }

                    Services.trenner();
                }
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
