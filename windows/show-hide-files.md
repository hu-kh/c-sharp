```c#
using System;
using System.IO;

namespace TestApp
{
    class Program
    {
        // config
        private const string USERNAME = "user";
        private const string PASSWORD = "pass";

        static void Main(string[] args)
        {
            Console.Title = "H/S Files";
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            // login to provide actions
            login();
        }

        private static void login()
        {
            Console.WriteLine("You have to login!");
            Console.WriteLine("Username?");
            Console.Write("> ");
            string username = Console.ReadLine();
            string password = "";
            Console.WriteLine("Password?");
            Console.Write("> ");
            ConsoleKeyInfo keyInfo;

            do
            {
                keyInfo = Console.ReadKey(true);
                // Skip if Backspace or Enter is Pressed
                if (keyInfo.Key != ConsoleKey.Backspace && keyInfo.Key != ConsoleKey.Enter)
                {
                    password += keyInfo.KeyChar;
                    Console.Write("*");
                }
                else
                {
                    if (keyInfo.Key == ConsoleKey.Backspace && password.Length > 0)
                    {
                        // Remove last charcter if Backspace is Pressed
                        password = password.Substring(0, (password.Length - 1));
                        Console.Write("\b \b");
                    }
                }
            }
            // Stops Getting Password Once Enter is Pressed
            while (keyInfo.Key != ConsoleKey.Enter);
            Console.WriteLine();

            if (username == USERNAME && password == PASSWORD)
            {
                // show menu
                menu();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("This action will be reported. ");
            }
        }

        private static void menu()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Choose type!");
            Console.WriteLine("< 1 > show file");
            Console.WriteLine("< 2 > hide file");
            Console.WriteLine("< 3 > exit");

            Console.Write("> ");

            int chooose = Convert.ToInt32(Console.ReadLine());

            switch (chooose)
            {
                case 1: Console.Clear(); show(); break;
                case 2: Console.Clear(); hide(); break;
                case 3: Environment.Exit(1); break;
                default:
                    Console.Clear();
                    Console.WriteLine("only <1> <2> <3>."); break;
            }
        }

        private static void show()
        {
            Console.Clear();
            string path = "";
            Console.WriteLine("type path: ");
            path = Console.ReadLine();
            try
            {
                FileAttributes attributes = File.GetAttributes(path);

                if ((attributes & FileAttributes.Hidden) == FileAttributes.Hidden && (attributes & FileAttributes.System) == FileAttributes.System)
                {
                    // Show the file.
                    attributes = RemoveAttribute(attributes, FileAttributes.Hidden | FileAttributes.System | FileAttributes.Encrypted);
                    File.SetAttributes(path, attributes);
                    Console.WriteLine("The file is no longer hidden.");
                }
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine("error: " + ex.Message);
            }
        }

        private static FileAttributes RemoveAttribute(FileAttributes attributes, FileAttributes attributesToRemove)
        {
            return attributes & ~attributesToRemove;
        }

        private static void hide()
        {
            string path = "";
            Console.WriteLine("type path: ");
            path = Console.ReadLine();

            try
            {
                File.SetAttributes(path, File.GetAttributes(path) | FileAttributes.Hidden | FileAttributes.System | FileAttributes.Encrypted);
                Console.WriteLine("The file is now hidden.");
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine("error: " + ex.Message);
            }
        }
    }
}

```
