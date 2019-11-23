```
using System;

namespace Acdc
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdukSumme sObj = new ProdukSumme();
            int eingabeZahl1;

            Console.WriteLine("Gib erste Zahl ein: ");
            eingabeZahl1 = Convert.ToInt32(Console.ReadLine());
           

            int summe = sObj.ZahlSumme(eingabeZahl1);
            Console.WriteLine(summe);

            int erg = sObj.ZahlenProduct(eingabeZahl1);
            Console.WriteLine(erg);
        }      
    }
}
```


```
using System;
using System.Collections.Generic;
using System.Text;

namespace Acdc
{
    class ProdukSumme
    {
        public int ZahlSumme(int zahl)
        {
            int summe = 0;

            if(zahl == 0)
            {
                throw new Exception("Zahl darf nicht negativ sein.");
            }

            for(int i = 1; i <= zahl; i++)
            {
                summe += i;
            }

            return summe;
        }


        public int ZahlenProduct(int zahl)
        {
            int summe = 0;

            for (int i = 1; i <= zahl; i++)
            {
                summe *= i;
            }
            return summe;
        }
    }
}

```

#161019
