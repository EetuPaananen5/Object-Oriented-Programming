// See https://aka.ms/new-console-template for more information
using CompanyExercise;

Console.WriteLine("This is company exercise");

Company finnair = new Company("Finnair Oyj", "Isoroba 1 Helsinki", "045100100", 800000, 200000);
finnair.setTitle("Finnair Oyj");
finnair.PrintInfo();
Console.WriteLine (finnair.ToString());
finnair.VoittoFunktio();

Console.WriteLine (" ");

Company kamux = new Company("Kamux oy", "Mannerheimintie 5 Helsinki", "045100100", 100000, 50000);
Company saka = new Company(kamux);


Console.WriteLine(kamux.ToString());
Console.WriteLine(saka.ToString());
kamux.VoittoFunktio();