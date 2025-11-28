using System.Data;

namespace _02_classes;

class Program
{
    internal void Run()
    {
               Auto auto1 = new Auto()
    {
        automaat = true,
        kenteken = "AB-123-CD",
        Kilometerstand = 15000,
        merk = "volkswagen",
    };

    Auto auto2 = new Auto()
    {
        automaat = false,

        kenteken = "EF-456-GH",
        Kilometerstand = 30000,
        merk = "toyota",
    };


    RijLeraar rijLeraar1 = new RijLeraar()
    {
        naam = "Jan Jansen",
        leeftijd = 45,
        zzp = false,
    };
    RijLeraar rijLeraar2 = new RijLeraar()
    {
        naam = "Piet Pietersen",
        leeftijd = 38,
        zzp = true,
    };

    lesUur lesUur1 = new lesUur()
    {
        tijd = 9,
        rijLeraar = rijLeraar1,
        auto = auto1,
    };
    lesUur lesUur2 = new lesUur()
    {
        tijd = 10,
        rijLeraar = rijLeraar2,
        auto = auto2,
    };


    Student student1 = new Student()
    {
        lesPakket = 01 - 12 - 2025,
        theorieTest = 06 - 15 - 2025,
        rijTest = 10 - 20 - 2025,

    };
    Student student2 = new Student()
    {
        lesPakket = 02 - 14 - 2025,
        theorieTest = 07 - 18 - 2025,
        rijTest = 11 - 22 - 2025,

    };


    Dag dag1 = new Dag()
    {
        Student = student1,
        lesUren = lesUur1,
        dag = DateTime.Now,

    };
    Dag dag2 = new Dag()
    {
        Student = student2,
        lesUren = lesUur2,
        dag = DateTime.Now,


    };
    }
    static void Main(string[] args)
    {
        Program Program = new Program();
        Program.Run();
    }
}












