```c#
using System;
using System.Text;

namespace Note
{
    class Login
    {
        public void login()
        {
            string username = "";
            string password = "";

            try
            {
                Console.Write("Username: ");
                username = Console.ReadLine();

                Console.Write("Password: ");
                password = hidePassword();
                Console.WriteLine("\n");

                if (username == "user" && password == "pass")
                {
                    NotizApp.app();
                }
                else
                {
                    Console.WriteLine("Try again.");
                    Console.WriteLine("Hint: [ username => us** ] and [ password => pa**** ]");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }

        private string hidePassword()
        {
            StringBuilder passwordBuilder = new StringBuilder();
            bool continueReading = true;
            char newLineChar = '\r';

            while (continueReading)
            {
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey(true);
                char passwordChar = consoleKeyInfo.KeyChar;

                if (passwordChar == newLineChar)
                {
                    continueReading = false;
                }
                else
                {
                    passwordBuilder.Append(passwordChar.ToString());
                }
            }

            return passwordBuilder.ToString();
        }
    }
}


```
