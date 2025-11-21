namespace _01_functions;

internal class Program
{
    string[] vragen = new string[]
    {
        "how long do you think you would survive in a zombie apocalypse?",
        "What secret conspiracy would you like to actually start letting other people know?",
        "If you can still remember, what are your funniest childhood memories?",
        "Why do round pizzas come in square boxes?",
        "Has someone caught you dancing in front of the mirror?"
    };


    internal void Run()
    {
        Console.WriteLine("Hoe laat is het");
        string antwoord = Console.ReadLine();

        Console.WriteLine(antwoord);
        string vraag0 = GetRandomVraag();
        Console.WriteLine(vraag0);
    }
    static void Main(string[] args)
    {
            Program program = new Program(); // het maken van een void variable. het return type van de functio is de void.
            program.Run();  // de variable is een void. het is een empty type variable
            string antwoord6 = program.Vraag6();
            Console.WriteLine(antwoord6);
        }
 internal string GetRandomVraag()
    {
        Random random = new Random();
        int Random = random.Next(vragen.Length);
        return vragen[Random];
    }
    internal void Vraag1()
    {
        Console.WriteLine("how long do you think you would survive in a zombie apocalypse?");
        string antwoord = Console.ReadLine();

        Console.WriteLine(antwoord);

    }
    internal void Vraag2()
    {
        Console.WriteLine("What secret conspiracy would you like to actually start letting other people know?");
        string antwoord = Console.ReadLine();

        Console.WriteLine(antwoord);

    }
    internal void Vraag3()
    {
        Console.WriteLine("If you can still remember, what are your funniest childhood memories?");
        string antwoord = Console.ReadLine();

        Console.WriteLine(antwoord);


    }
    internal void Vraag4()
    {
        Console.WriteLine("Why do round pizzas come in square boxes?");
        string antwoord = Console.ReadLine();

        Console.WriteLine(antwoord);

    }
    internal void Vraag5()
    {
        Console.WriteLine("Has someone caught you dancing in front of the mirror?");
        string antwoord = Console.ReadLine();
        Console.WriteLine(antwoord);
    }
    internal string Vraag6()
    {
        Console.WriteLine("");
        string antwoord = Console.ReadLine();


        return antwoord;

    }
}

