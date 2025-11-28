using System.Data;

namespace _02_classes;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
internal class auto
{
    internal bool automaat;
    internal string merk;
    internal string kenteken;
    internal int Kilometerstand;
}

internal class RijLeraar
{
    internal string naam;
    internal string leeftijd;
    internal bool zzp;
}

internal class  Student
{
    internal string naam;
    internal int leeftijd;
    internal LesPakket lesPakket;
    internal RijLeraar rijLeraar;
    internal TheorieTest theorieTest;
    internal RijTest rijTest;
}

internal class LesPakket
{
    internal int UrenGekocht;
    internal int UrenVerbruikt;
    internal int examenPogingen;
    internal bool automaat;
}

internal class RijTest
{
    internal bool gehaald;
    internal DateTime afnameDatum;
}

internal class TheorieTest
{
    internal int aantelFouten;
    internal bool gehaald;
     internal DataTime afnameDatum;
}

internal class Dag
{
    internal DateTime datum;
     internal lesUur[] lesUren;
}

internal class lesUur
{
    internal int tijd;
    internal Student student;
    internal RijLeraar rijLeraar;
    internal auto auto;
}
