// See https://aka.ms/new-console-template for more information
using ShapeExercise;
using System.Drawing;
using System.Runtime.CompilerServices;
using static System.Reflection.Metadata.BlobBuilder;

Console.WriteLine("Shapes and polymorphism!");

Console.WriteLine("");


Ympyra ekaympyrä = new Ympyra(" ympyrä ", " dpunainen ", 1.1);
ekaympyrä.GetInfo();
Console.WriteLine(ekaympyrä.GetInfo());
Console.WriteLine("");

Ympyra tokaympyrä = new Ympyra(" ympyrä ", " cvihreä ", 3.5);
tokaympyrä.GetInfo();
Console.WriteLine(tokaympyrä.GetInfo());
Console.WriteLine("");

Kolmio ekakolmio = new Kolmio(" kolmio ", " bsininen ", 10, 10);
ekakolmio.GetInfo();
Console.WriteLine(ekakolmio.GetInfo());
Console.WriteLine("");

Nelio ekaneliö = new Nelio(" neliö ", " apinkki ", 14, 11);
ekaneliö.GetInfo();
Console.WriteLine(ekaneliö.GetInfo());
Console.WriteLine("");


List<Muoto> shapes = new List<Muoto>
{
    new Ympyra("ympyrä"," punainen", 1.1),
    new Kolmio(" kolmio ", " sininen ", 10, 10),
    new Nelio(" neliö ", " pinkki ", 14, 11)
};

foreach (Muoto shape in shapes)
{
    Console.WriteLine(shape.GetInfo());
}

Console.WriteLine("");

foreach (Muoto shape in shapes)
{
    if(shape is Kolmio)
    Console.WriteLine(shape.GetInfo());
}



Console.WriteLine("\n\n --------sort----------\n\n");


Console.WriteLine("sorttaus pinta-alan mukaan ja isoin eka: ");
shapes.Sort();

// Tulostaa sorttauksen jälkeen oikeassa järjestyksessä

foreach (Muoto shape in shapes)
{
    Console.WriteLine(shape.GetInfo());
}
    
