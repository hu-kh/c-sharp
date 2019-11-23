using System;
using System.Linq;

namespace CheckChars {
    class MainClass {
        public static void Main (string[] args) {
	    string name;
            Console.WriteLine ("Enter your Name: ");
	    name = Console.ReadLine();

	    if (! name.Any(char.IsDigit)) {
		Console.WriteLine ("Hi, {0} Pingo You've enterd only Letters.", name); 
	     }else{
		Console.WriteLine ("Only Letters are acceptable!");
	     }

	       

            Console.ReadKey ();
        }
    }
}
