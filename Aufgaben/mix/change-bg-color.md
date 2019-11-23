```
using System;
using System.Collections.Generic;
using System.Text;

namespace MainProject
{
    class BGColor
    {
        public void GetBGColor()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
-------

using System;

namespace MainProject
{
    class Program
    {
        static void Main(string[] args)
        {

            BGColor color = new BGColor();      
            color.GetBGColor();

            Console.WriteLine("Colors has been changed!");
            
        }
    }
}
```
