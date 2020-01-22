```c#
using System;
using System.IO;

namespace Note
{
    class NotizApp
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
            try
            {
                // create a writer and open the file
                TextWriter tw = new StreamWriter(FILE_NAME);

                writeNote(tw);

                // close the stream
                tw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private static void readFile()
        {
            try
            {
                // create reader & open file
                TextReader tr = new StreamReader(FILE_NAME);

                // read a line of text
                Console.WriteLine(tr.ReadToEnd());

                // close the stream
                tr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private static void writeNote(TextWriter tw)
        {
            int id = 0;
            char space = ' ';
            bool isTrue = true;
            string title = "", description = "";

            try
            {
                Console.WriteLine("\nWrite Your Note/s");

                while (isTrue == true)
                {
                    // id
                    id++;
                    tw.WriteLineAsync("[id] " + id + Convert.ToString(space));

                    // title
                    Console.Write("Title: ");
                    title = Console.ReadLine();
                    tw.WriteLineAsync("[title] " + title + Convert.ToString(space));

                    // decription
                    Console.Write("Description: ");
                    description = Console.ReadLine();
                    tw.WriteLineAsync("[description] " + description + Convert.ToString(space));

                    // datatime
                    tw.WriteLineAsync("[datetime] " + DateTime.Now);

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
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
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

```
