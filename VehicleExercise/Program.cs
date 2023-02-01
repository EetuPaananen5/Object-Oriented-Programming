// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using VehicleExercise;


Vehicle traktori = new Vehicle("Valmet", "Super3000", "1990", 150000);

Car avoauto = new Car("Audi","TT", "2019", 90000, "3.0 V6 Turbo ", "Diesel Motor ", 2);

Car maasturi = new Car("Nissan", "Primera", "2007", 5000, "2.0 ", "Petrol Motor ", 2);

Truck sisu = new Truck("Sisu ", 200 , 10);

Console.WriteLine("Vehicle tulostus:");
traktori.PrintInfo();
Console.WriteLine();

avoauto.PrintInfo();
Console.WriteLine();
Console.WriteLine(avoauto.ToString());

Console.WriteLine();
sisu.PrintInfo();

Console.WriteLine("Rekan kulutus:");
Console.WriteLine(sisu.CalculateConsumpion());
sisu.CalculateConsumpion();


Console.WriteLine();
Console.WriteLine("Equals funktio vertaa avoauton tietoja maasturiin: ");
Console.WriteLine( avoauto.Equals(maasturi)); //Vertaa avoauton tietoja maasturiin
Console.WriteLine("Autojen tiedot ei täsmää");




