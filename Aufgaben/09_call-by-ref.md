```c#

using System;

namespace CallByValueByRef
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Call by reference ---");

            int z = 3;
            doSth(z);
            Console.WriteLine("Zahl: " + z);

            //int z2 = 7;
            //doSth(ref z2);
            //Console.WriteLine("Zahl2: " + z2);

            int z3;
            doSthOut(out z3);
            Console.WriteLine("Zahl2: " + z3);
        }

        //z1
        static void doSth(int para)
        {
            para = 5;
        }
        //z2
        static void doSth(ref int para)
        {
            para = 550;
        }

        //z3 -- geht nicht, doSth
        static void doSthOut(out int para)
        {
            para = 550;
        }
    }
}

```
