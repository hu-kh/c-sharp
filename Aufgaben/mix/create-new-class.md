```
// Start Programm
using System;

namespace MeinClass
{
    class Program
    {
        static void Main(string[] args)
        {
            ExternesClass externesClass = new ExternesClass();
            int test = externesClass.Multiply(7);

            Console.WriteLine("Hello World!{0}", test);

	//using Parse
            string text = "500";
            int num = int.Parse(text);
            Console.WriteLine(num);

           
        }


    }
}

// Neue Class
using System;
using System.Collections.Generic;
using System.Text;

namespace MeinClass
{
    class ExternesClass
    {
        public int Multiply(int num)
        {
            return num * 5;
        }
    }
}
```

#260919
