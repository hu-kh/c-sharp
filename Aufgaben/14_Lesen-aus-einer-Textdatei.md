```c#
using System;
using System.IO;

namespace Something
{
    class ReadWriteFile
    {
        public void start()
        {
            Console.WriteLine("Lesen aus einer Textdatei.");

            try
            {
                Console.Write("Gib bitte den Path für deiner File: ");
                /*Get Path*/
                string path = Console.ReadLine();
                string fn = ReadWriteFile.pathToFile(path);

                /*Read File*/
                StreamReader sr = new StreamReader(fn);
                string inhalt = sr.ReadToEnd();
                Console.WriteLine(inhalt);
                sr.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /*Check Path File*/
        private static string pathToFile(string path)
        {
            if (path.Substring(path.Length - 3) != "txt")
            {
                throw new Exception($"Extension darf nur [.txt] sein! [{path.Substring(path.Length - 3)}] ist ungültig");
            }

            return path;
        }
    }
}

```

### in Main()
```c#
using System;
using System.IO;

namespace Something
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadWriteFile pro = new ReadWriteFile();
            pro.start();
        }
    }
}
```
