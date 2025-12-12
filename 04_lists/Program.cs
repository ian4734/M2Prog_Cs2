using System.Reflection.PortableExecutable;

namespace _04_lists;

class Program
{
    string[] characters = new string[]
     {
         "pac - man",

          "samus",

          "Crash Bandicoot",

         "Spyro the Dragon",

          "DonkeyKong",

          "Mario",

          "Luigi",

          "Astro",

          "Solid Snake",

         "Kratos",

          "Sonic the Hedgehog",

          "Link",

     };


    List<string> characterlist = new List<string>();
    

    static void Main(string[] args)
    {
        Program program = new Program();
        program.run();

    }
    internal void run()
    {
        characterlist.Add("odin");
        foreach (string item in characters)
        {
            characterlist.Add(item);
        }
       foreach (string item in characters)
       {
           Console.WriteLine(item);
       }
    }
}