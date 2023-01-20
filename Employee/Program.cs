// See https://aka.ms/new-console-template for more information


using EmployeeExercise;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Moikka, tervetuloa konsoliin, alla näkyy palkkavertailu looppi");
        Console.WriteLine(" ");



        Employee[] employees = new Employee[4];
        employees[0] = new Employee(" Eetu ", "001", "Johtaja", 100);
        employees[1] = new Employee(" Sami ", "002", "Myyjä", 200);
        employees[2] = new Employee(" Juho ", "003", "Siivooja", 300);
        employees[3] = new Employee(" Dennis ", "004", "Korjaaja", 400);

        for (int i = 0; i < employees.Length; i++) // Tässä looppi joka vertaa aina seuraavaan
        {
            if (i == employees.Length - 1) // jos loopi on lopussa niin vertaa ekaan.
            {
                employees[i].CompareSalary(employees[0]);
            }
            else
            {
                employees[i].CompareSalary(employees[i + 1]); //Looppi vertaa seuraavaan
            }

        }

        Console.WriteLine(" ");
        Console.WriteLine("Ja tässä alla tulostettuna työntekijöiden tiedot PrintEmployeeInfo funktiona sekä ToString funktiona");
        Console.WriteLine(" ");

        for (int i = 0; i < employees.Length; i++) // Tämä looppi tulostaa konsoliin työntekijöiden tiedot
        {

            employees[i].PrintEmployeeInfo();

            Console.WriteLine(employees[i].ToString());
        }




    }
}