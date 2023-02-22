// See https://aka.ms/new-console-template for more information
using Tentti;

Tank vesi = new Tank("VESI", 100);
Tank rypsioljy = new Tank("RYPSIÖLJY", 100);
Tank oliivioljy = new Tank("OLIIVIÖLJY", 150);
Console.WriteLine("--Säiliöiden luominen");


Console.WriteLine("\n--Tulostetaan säiliöiden lähtötilanne: ");
Console.WriteLine(vesi.ToString());
Console.WriteLine(rypsioljy.ToString());
Console.WriteLine(oliivioljy.ToString());

Console.WriteLine("\n--Lisätään nestettä säiliöihin:");
Console.WriteLine(vesi.AddToTank(110));
Console.WriteLine(rypsioljy.AddToTank(70));
Console.WriteLine(oliivioljy.AddToTank(-50));

Console.WriteLine("\n--Säiöiöistä poistaminen");
Console.WriteLine(vesi.RemoveFromTank(80));
Console.WriteLine(rypsioljy.RemoveFromTank(80));
Console.WriteLine(oliivioljy.RemoveFromTank(80));

Console.WriteLine("\n--Säiliöiden tyhjennys");
vesi.ClearTank();
rypsioljy.ClearTank();
oliivioljy.ClearTank();

Console.WriteLine("\n--Tulostetaan säiliöiden lopputilanne");
Console.WriteLine(vesi.ToString());
Console.WriteLine(rypsioljy.ToString());
Console.WriteLine(oliivioljy.ToString());

