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
        reviews.Remove(342.97);
       
        characterlist.Add("odin");
        foreach (string item in characters)
        {
            characterlist.Add(item);
        }
        foreach (string item in characters)
        {
            Console.WriteLine(item);
        }


        foreach (double item in reviews)
        {
            Console.WriteLine(item);
        }
        
    }


    List<double> reviews = new List<double>() { 9.99, 4.68, 342.97, 12.2 };

    List<double> reviews = new List<int>() { 9.99, 4.68, 342.97, 12.2 };
    internal void RemoveAt(int index)
    {
        reviews.RemoveAt(12.2);
    }
}
    
       
    

    
