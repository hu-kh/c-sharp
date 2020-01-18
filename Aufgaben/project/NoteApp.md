using System;
using System.IO;

namespace NotizApp
{
    class Note
    {
        private const string FILE_NAME = @"Note.txt";

        public static void app()
        {
            Console.Clear();

            createFile();
            readFile();

            Console.WriteLine("Press any key to close App.");
            Console.ReadKey();
        }

        private static void createFile()
        {
            // create a writer and open the file
            TextWriter tw = new StreamWriter(FILE_NAME);

            writeNote(tw);

            // close the stream
            tw.Close();
        }

        private static void readFile()
        {
            // create reader & open file
            TextReader tr = new StreamReader(FILE_NAME);

            // read a line of text
            Console.WriteLine(tr.ReadToEnd());

            // close the stream
            tr.Close();
        }

        private static void writeNote(TextWriter tw)
        {
            string title = "", description = "";
            bool isTrue = true;

            Console.WriteLine("\nWrite Your Note/s");

            while (isTrue == true)
            { 
                // title
                Console.Write("Title: ");
                title = Console.ReadLine();
                tw.WriteAsync(title);

                // decription
                Console.Write("Description: ");
                description = Console.ReadLine();
                tw.WriteAsync(description);

                // datatime
                tw.WriteLine(DateTime.Now);

                // repeat
                line('.', 70);
                Console.WriteLine("Write more Notes! <yes = 1> or <no = 2>");
                int confirm = Convert.ToInt32(Console.ReadLine());

                switch (confirm)
                {
                    case 1: isTrue = true; break;
                    case 2: isTrue = false; break;
                    default: Console.WriteLine("please only <1> or <2>."); break;
                }

                line('.', 70);
            }
        }

        protected static void line(char s, int sLong)
        {
            for (int i = 0; i <= sLong; i++)
            {
                Console.Write(s);
            }

            Console.WriteLine();
        }
    }
}
