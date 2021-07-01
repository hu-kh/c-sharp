```c#
using System;

namespace EnumTest
{
    enum Tage
    {
        Montag = 1,
        Dienstag,
        Mittwoch,
        Donnerstag,
        Freitag,
        Samstag,
        Suntag
    }

    class Program
    {
        

        static void Main(string[] args)
        {
            // Change Montag to another Tag
            Console.WriteLine(WochenTag(Tage.Montag));
         

            Console.ReadKey();
        }

        static string WochenTag(Tage tag)
        {
            switch (tag)
            {
                case Tage.Montag:
                    return String.Format("{0}", tag);
                case Tage.Dienstag:
                    return String.Format("{0}", tag);
                case Tage.Mittwoch:
                    return String.Format("{0}", tag);
                case Tage.Donnerstag:
                    return String.Format("{0}", tag);
                case Tage.Freitag:
                    return String.Format("{0}", tag);
                case Tage.Samstag:
                    return String.Format("{0}", tag);
                case Tage.Suntag:
                    return String.Format("{0}", tag);

                default:
                    return "Invalid Tag";
            }

        }

    }
}
```

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
