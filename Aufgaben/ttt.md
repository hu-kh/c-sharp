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
