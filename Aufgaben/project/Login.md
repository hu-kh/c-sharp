using System;

namespace NotizApp
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
                password = Console.ReadLine();

                if (username == "user" && password == "pass")
                {
                    Note.app();
                }
                else
                {
                    Console.WriteLine("Try again.");
                    Console.WriteLine("Hint: [ username => u ] and [ password => p ]");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
