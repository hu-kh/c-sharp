```c#
using System;

namespace MeinClass
{
  class Program
  {
      static void Main(string[] args)
      {
        double p, q, x1, x2;

        Console.WriteLine("Bitte geben Sie [p] ein: ");
        p = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Bitte geben Sie [q] ein: ");
        q = Convert.ToInt32(Console.ReadLine());

        if(p != "" && q != "")
        {
          x1 = -p/2 + p (p*p) -q;
          Console.WriteLine("Das Ergibniss ist : {0}", x1);

          x2 = -p/2 + p (p*p) -q;
          Console.WriteLine("Das Ergibniss ist : {0}", x2);
        }else{
          Console.WriteLine("Weder p noch q dourfen nicht [0] sein!");
        }

          Console.ReadKey();
      }
  }
}

```

# 260919
