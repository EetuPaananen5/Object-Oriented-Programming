// See https://aka.ms/new-console-template for more information
using Arvio;
using System.Runtime.CompilerServices;

Console.WriteLine("Employee Exercise!");
Employee Mika = new Employee("Mika", 24, "Manager", 520);
Employee Jari = new Employee("Jari", 45, "Marketing", 320);
Employee Hanna = new Employee("Hanna", 56, "Distribution", 242);


Mika.PrintEmployeeInfo();

Mika.CompareSalary(Jari);
Jari.CompareSalary(Hanna);
Hanna.CompareSalary(Mika);


Console.WriteLine("Mika's salary compared to Jari's: " + Mika.CompareSalary(Jari));
Console.WriteLine("Jari's salary compared to Hanna's: " + Jari.CompareSalary(Hanna));
Console.WriteLine("Hanna's salary compared to Mika's: " + Hanna.CompareSalary(Mika));

Console.WriteLine(Mika.ToString());
Console.WriteLine(Jari.ToString());

Employee[] employees = new Employee[3];
employees[0] = Mika;
employees[1] = Jari;
employees[2] = Hanna;

foreach (Employee i in employees)
{
    Console.WriteLine(i);
}

foreach (Employee salary in employees)
{
    Console.WriteLine(employees[0].CompareSalary(employees[1]));
    Console.WriteLine(employees[1].CompareSalary(employees[2]));
    Console.WriteLine(employees[2].CompareSalary(employees[0]));
}
