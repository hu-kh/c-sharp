using System;

namespace NotizApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("...........................................................");
            Console.WriteLine("...................... NotizApp ...........................");
            Console.WriteLine("...........................................................");
            Console.WriteLine("\n\n");

            Console.WriteLine("Please login to use this App.");
            Login credintial = new Login();
            credintial.login();
        }
    }
}
