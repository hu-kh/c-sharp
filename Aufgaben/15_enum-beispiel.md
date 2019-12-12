```c#
using System;

namespace EnumTesting
{
    class Program
    {
        enum Color
        {
            Red,
            Green = 10,
            Blue
        }

        static void Main(string[] args)
        {
            Console.WriteLine(StringFromColor(Color.Red));
            Console.WriteLine(StringFromColor(Color.Green));
            Console.WriteLine(StringFromColor(Color.Blue));
        }

        static string StringFromColor(Color c)
        {
            switch (c)
            {
                case Color.Red:
                    return String.Format("Red = {0}", (int)c);

                case Color.Green:
                    return String.Format("Green = {0}", (int)c);

                case Color.Blue:
                    return String.Format("Blue = {0}", (int)c);

                default:
                    return "Invalid color";
            }
        }

    }
}
```
