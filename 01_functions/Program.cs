namespace _01_functions;

internal class Program
{
    static void Main(string[] args)
    {
        Program program = new Program(); // het maken van een void variable. het return type van de functio is de void.
        program.Run();  // de variable is een void. het is een empty type variable
    }
    internal void Run()
    {
        Console.WriteLine("Hoe laat is het");
        string antwoord = Console.ReadLine();

        Console.WriteLine(antwoord);
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

    
    } internal void Vraag4()
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
}
