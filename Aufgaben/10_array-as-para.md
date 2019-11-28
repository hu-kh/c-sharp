```c#

using System;

namespace ArrayAsParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Array as Parameter ---");

            int[] liste = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            forSchleife(liste);

            quadariere(liste);

            forSchleife(liste);

            Console.ReadKey();
        }


        static void forSchleife(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("  {0}", arr[i]);
            }

            Console.WriteLine("..........");
        }


        static void quadariere(int[] quadArr)
        {
            for(int i = 0; i < quadArr.Length; i++)
            {
                quadArr[i] = quadArr[i] * quadArr[i];
            }
        }

    }
}

```
