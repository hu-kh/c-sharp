```c#
using System;
using System.IO;


namespace DateiLesen
{
    class ReadWriteFile
    {
        public void start()
        {
            string path = @"\\path\to\datei";
            try
            {
                Console.Write("Filename  : ");
                string f = Console.ReadLine();

                Console.WriteLine("Type :");
                string content = Console.ReadLine();
                writeToFile(path + f, content);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void writeToFile(string p, string c)
        {
            using (StreamWriter writer = new StreamWriter(p))
            {
                writer.WriteLine(c);
            }
        }

        private static void readFile(string p)
        {
            using (StreamReader r = new StreamReader(p))
            {
                string inhalte = r.ReadToEnd();
                r.Close();
                Console.WriteLine(inhalte);
            }
        }
    }
}

```

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
