### Suche die größe Zahl in der Liste

```c#

using System;

namespace MainProgramm
{
   class Program
   {
        static void Main(string[] args)
        {
            int[] liste = {1, 2, 4, 45, 66, 8, 3, 90, 100};
            Console.WriteLine($"Max Zahl: {sucheMaximum(liste)}");
            Console.ReadKey();
        }

        static int sucheMaximum(int[] arr)
        {
            int max = arr[0];
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] > max)
                {
                    max = arr[i];
                }
            }

            return max;
        }
    }
  
}

```


### Suche den Index der größten Zahl in der Liste


```c#

using System;

namespace MainProgramm
{
   class Program
   {
        static void Main(string[] args)
        {
            int[] liste = {1, 2, 4, 45, 66, 8, 3, 90, 100};
            Console.WriteLine($"Max Index: {sucheMaximumIndex(liste)}");
            Console.ReadKey();
        }

        static int sucheMaximumIndex(int[] arr)
        {
            int maxIndex = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] > arr[maxIndex])
                {
                    maxIndex = i;
                }
            }

            return maxIndex;
        }
    }
  
}

```





###  Berechne die Summe aller Werte der Liste


```c#

using System;

namespace MainProgramm
{
   class Program
   {
        static void Main(string[] args)
        {
            int[] liste = {1, 2, 3, 4, 5};
            Console.WriteLine(berechneSume(liste));
            Console.ReadKey();
        }

        static int berechneSume(int[] arr)
        {
           int summe = 0;
           for(int i = 0; i < arr.Length; i++)
           {
                summe += arr[i];
           }

           return summe;
        }
    }
  
}

```


### Berechne den Durchschnitt aller Werte der Liste

```c#

using System;

namespace MainProgramm
{
   class Program
   {
        static void Main(string[] args)
        {
            int[] liste = {1, 2, 3, 4, 5};
            Console.WriteLine(berechneDurchschnitt(liste));
            Console.ReadKey();
        }

        static double berechneDurchschnitt(int[] arr)
        {
           int summe = 0;
           for(int i = 0; i < arr.Length; i++)
           {
                summe += arr[i];
           }

           return (double)summe / arr.Length;
        }
    }
  
}

```


### Vergleiche zwei sortierte Listen miteinander

```c#

using System;

namespace MainProgramm
{
   class Program
   {
        static void Main(string[] args)
        {
            int[] liste = {1, 2, 3, 4, 5};
            int[] vergleichListe = {1, 23, 3, 4, 15};
            Console.WriteLine(vergleichListenSort(liste, vergleichListe));
            Console.ReadKey();
        }

        static int vergleichListenSort(int[] liste, int[] vergleichListe)
        {
           int gleichZahl = 0;
           int anzahl = liste.Length;

           for(int i = 0; i < liste.Length-1; i++)
           {
                if(liste[i] == vergleichListe[i])
                {
                    gleichZahl = gleichZahl + 1;
                }
           }

           return gleichZahl;
        }
    }
  
}

```


### Vergleiche zwei unsortierte Listen miteinander

```c#

using System;

namespace MainProgramm
{
   class Program
   {
        static void Main(string[] args)
        {
            int[] liste = {1, 2, 3, 4, 5};
            int[] vergleichListe = {1, 23, 3, 4, 15};
            Console.WriteLine(vergleichListenUnSort(liste, vergleichListe));
            Console.ReadKey();
        }

        static int vergleichListenUnSort(int[] liste, int[] vergleichListe)
        {
           int gleichAnzahl = 0;
           int anzahl = liste.Length;
           int suchWert;

           for(int i = 0; i < liste.Length-1; i++)
           {
                suchWert = vergleichListe[i];
                if(indexWert(liste, suchWert) <> -1)
                {
                    gleichZahl = gleichZahl + 1;
                }
           }

           return gleichZahl;
        }
    }
  
}

```


### Suche den Index eines Wertes


``` c#

using System;

namespace MainProgramm
{
   class Program
   {
        static void Main(string[] args)
        {
            int[] liste = {1, 2, 4, 45, 66, 8, 3, 90, 100};
            Console.WriteLine(indexWert(liste, 2));
            Console.ReadKey();
        }

        static int indexWert(int[] arr, int wert)
        {
            int anzahl = arr.Length;
            bool gefunden = false;
            int index = 0;

            while(index < anzahl && gefunden == false){
                if(arr[index] == wert)
                {
                    gefunden = true;
                }else
                {
                    index = index +1;
                }

                if(gefunden == true)
                {
                    return index;
                }else
                {
                    return -1;
                }
            };
        }
    }
  
}

´´´
