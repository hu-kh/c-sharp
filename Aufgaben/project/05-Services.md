```c#
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NotizApp
{
    class Services
    {
        // Dateipfad
        private const string CONFIG_DATEI = @"config.txt";

        public static string configDatei(int index = 0)
        {
            // Erzeuge ein Array
            string[] lines;
            var list = new List<string>();

            // Öffent und liset config datei 
            var fileStream = new FileStream(CONFIG_DATEI, FileMode.Open, FileAccess.Read);

            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                // Prüfe ob Datei nicht leer ist
                while ((line = streamReader.ReadLine()) != null)
                {
                    // Füge alle Zeilen in Array
                    list.Add(line);
                }
            }

            // Alle Zeilen werden in lines gespeichert
            lines = list.ToArray();

            // Rückgabewert
            return lines[index];
        }

        public static string passwortVerstecken()
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
                    }
                }
            }

            // Passwortabfrage nach Enter beenden
            while (tasteInfo.Key != ConsoleKey.Enter);
            Console.WriteLine();

            // Rückgabe Wert
            return passwort;
        }

        public static void trenner(char symbol = '.', int länge = 70)
        {
            // Forschleife für Trenner
            for (int i = 0; i <= länge; i++)
            {
                Console.Write(symbol);
            }

            Console.WriteLine();
        }
    }
}
```
