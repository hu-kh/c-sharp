```
using System;

namespace MeinClass
{
  class Program
  {
      static void Main(string[] args)
      {
        double spannung, strom, wiederstand;

        Console.WriteLine("Bitte geben Sie die Elektrische Spannung ein: ");
        spannung = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Bitte geben Sie die Elektrische Strom ein: ");
        strom = Convert.ToInt32(Console.ReadLine());

        if(spannung != "" && strom != "")
        {
          wiederstand = spannung / strom;
          Console.WriteLine("Der Widerstand ist : {0}", wiederstand);
        }else{
          Console.WriteLine("Weder Spannung noch Strom dourfen nicht [0] sein!");
        }

          Console.ReadKey();
      }
  }
}

```

#260919
