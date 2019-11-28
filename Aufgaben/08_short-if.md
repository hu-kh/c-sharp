```c#
using System;
using System.Linq;

namespace Kekse
{
    class Program
    {
        static void Main(string[] args)
        {
            int z1, z2;
            Console.WriteLine("gib ein zahl ein: ");
            z1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("gib ein zweites zahl ein: ");
            z2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Kleinste Zahl ist: {Min(z1, z2)}");

            Console.ReadKey();
        }

        static int Min(int z1, int z2)
        {
            return ((z1 < z2) ? z1 : z2);
        }
    }
}
```
