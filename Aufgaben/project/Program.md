```c#
using System;

namespace NotizApp

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(".......................................................................");
            Console.WriteLine(".......................... NotizApp v1.0.0 ............................");
            Console.WriteLine(".......................................................................\n");

            Console.WriteLine("Bitte melden Sie sich an, um die App zu benutzen.");

            // Zum anmelden
            Anmeldung anmeldeinfo = new Anmeldung();
            anmeldeinfo.anmeldung();
        }
    }
}


```
