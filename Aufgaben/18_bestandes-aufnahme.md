```c#
using System;

namespace UMLClassen
{
    class Program
    {
        static void Main(string[] args)
        {
            BestandesAufnahme bestandesAufnahme = new BestandesAufnahme();
            bestandesAufnahme.zeigeErsatzteils();
        }
    }
}


---------------------------------------------


using System;
using System.Collections.Generic;
using System.Text;

namespace UMLClassen
{
    class BestandesAufnahme
    {
        private int _kennzahl;
        private int _number;
        private double _preis;

        public void setErsatzteils(int kennzahl, int number, double preis)
        {
            this._kennzahl = kennzahl;
            this._number = number;
            this._preis = preis;
        }

        public void zeigeErsatzteils()
        {
            Console.Write("kennzahl: ");
            _kennzahl = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number: ");
            _number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Preis: ");
            _preis = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Die Kennzahl {_kennzahl}, die Number {_number} und der Preis {_preis}");
        }
    }
}

```
