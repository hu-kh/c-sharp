using System;
using System.IO;

namespace MainProgramm
{

  class Program
  {

   static public void Main (string[] args)
   {
    FileStream ostrm;
    StreamWriter writer;
    TextWriter oldOut = Console.Out;
    try
    {
        ostrm = new FileStream ("info.txt", FileMode.OpenOrCreate, FileAccess.Write);
        writer = new StreamWriter (ostrm);
    }
    catch (Exception e)
    {
        Console.WriteLine ("Cannot open info.txt for writing");
        Console.WriteLine (e.Message);
        return;
    }
    Console.SetOut (writer);
    Console.WriteLine ("This is a line of text");
    Console.WriteLine ("Everything written to Console.Write() or");
    Console.WriteLine ("Console.WriteLine() will be written to a file");
    Console.SetOut (oldOut);
    writer.Close();
    ostrm.Close();
    Console.WriteLine ("Done");
   }

  }
}
