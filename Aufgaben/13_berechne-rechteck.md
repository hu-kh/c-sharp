```c#
using System;

namespace ExceptionHandlen
{
    class BerechneRechteck
    {
        public static double berechneFlaschen(double zahl1, double zahl2)
        {

            if (zahl1 > 0 && zahl2 > 0)
            {
                return hoch(zahl1) * hoch(zahl2);
            }

            throw new Exception("Zahl darf nicht kleiner als null sein!");

           
        } 

        static double hoch(double z)
        {
            return z * z;
        }
    }
}

```

```c#
using System;
using System.Collections;

namespace ExceptionHandlen
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Erste Zahl: ");
            double eingabe = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Zweite Zahl: ");
            double eingabe2 = Convert.ToDouble(Console.ReadLine());
            try
            {
                Console.WriteLine($"Die Fläche:  {BerechneRechteck.berechneFlaschen(eingabe, eingabe2)} cm");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

            Console.ReadLine();


        }
    }
}
```
