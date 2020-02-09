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
            bool kannLogin = true;

            while (kannLogin == true)
            {
                // Eingabe des Benutzers
                Console.Write("Benutzername: ");
                benutzerName = Console.ReadLine();

                // Eingabe des Passworts
                Console.Write("Passwort: ");
                passwort = Services.passwortVerstecken();
                Console.WriteLine("\n");

                // Prüft den Benutzername und das Passwort
                if (benutzerName == Services.configDatei() && passwort == Services.configDatei(1))
                {
                    kannLogin = false;
                    // Rufe die Hauptanwendung auf
                    NotizApp.app();
                }
                else
                {
                    Console.Clear();
                    string getName = Services.configDatei();
                    string getPass = Services.configDatei(1);

                    // Die ersten Zwei Buchstaben vom Benutzernamen
                    string name = getName.Substring(0, 2);

                    // Die ersten Zwei Buchstaben vom Passwort
                    string pass = getPass.Substring(0, 2);

                    // Fehlermeldung 
                    Console.WriteLine("Bitte versuchen Sie es erneut.\n");
                    Services.trenner();
                    Console.WriteLine("Hinweis: Default [ Benutzername => {0}**** ] und [ Passwort => {1}**** ]", name, pass);
                    Services.trenner();

                    kannLogin = true;
                    Console.WriteLine();

                }
            }
        }
    }
}

```
