```
using System;

namespace MeinClass
{
  class Program
  {
      static void Main(string[] args)
      {
          double Kapital, zinsen, jahr, ergibniss;

          Console.WriteLine("Bitte geben Sie das Kapital ein: ");
          Kapital = Convert.ToInt32(Console.ReadLine());

          // if (Kapital === "")
          // {
          //   Console.WriteLine("Bitte geben Sie ein Zahl ein!");
          //   return;
          // }

          Console.WriteLine("Bitte geben Sie das Zinsen ein: [z.B 0.5%]");
          zinsen = Convert.ToInt32(Console.ReadLine());

          // if (zinsen === "")
          // {
          //   Console.WriteLine("Bitte geben Sie ein Zahl ein!");
          //   return;
          // }

          Console.WriteLine("In wie viel Jahren wollen Sie? [1,2, ..n] ");
          jahr = Convert.ToInt32(Console.ReadLine());

          // if (jahr === "")
          // {
          //   Console.WriteLine("Bitte geben Sie ein Zahl ein!");
          //   return;
          // }

          while(jahr > 0)
          {
            ergibniss += zinsen * Kapital;
          }

          Console.WriteLine("Ihre Zinsen {0} wird in {1} Jahren so gross sein.", ergibniss, jahr);

          Console.ReadKey();

      }
  }
}

```

#260919
