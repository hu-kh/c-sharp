```c#
using System;

namespace MeinClass
{
    class Program
    {
        

        static void Main(string[] args)
        {
            const double mehrWertSteuerSatz = 1.19;

            int eingabe;  

            Console.WriteLine("Bitte geben Sie den Nettopreis ein: ");

            eingabe = Convert.ToInt32(Console.ReadLine());

            double ausgabe = eingabe * mehrWertSteuerSatz;
        
            Console.WriteLine("Ihr Netto ist: {0}", eingabe);
            Console.WriteLine("Ihr Brutto ist: {0}", ausgabe);
            Console.WriteLine("................................");

            Console.ReadKey();

        }
    }
}

```

# 260919
