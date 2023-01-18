// See https://aka.ms/new-console-template for more information


using EmployeeExercise;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("MOikka, tervetuloa konsoliin, alla näkyy palkkavertailu looppi");
        Console.WriteLine(" ");

        //Employee Eetu = new Employee ("Eetu", "001", "Johtaja", 100000);
        //Console.WriteLine(Eetu.ToString());
        //Eetu.PrintEmployeeInfo();


        Employee[] employees = new Employee[4];
        employees[0] = new Employee(" Eetu ", "001", "Johtaja", 100);
        employees[1] = new Employee(" Sami ", "002", "Myyjä", 200);
        employees[2] = new Employee(" Juho ", "003", "Siivooja", 300);
        employees[3] = new Employee(" Dennis ", "004", "Korjaaja", 400);

        for (int i = 0; i < employees.Length; i++)
        {
            if(i == employees.Length -1) // jos loopi on lopussa niin vertaa ekaan.
            {
                employees[i].CompareSalary(employees[0]);
            }
            else
            {
                employees[i].CompareSalary(employees[i+1]); //Looppi vertaa seuraavaan
            }
           
        }

        Console.WriteLine(" ");

        for (int i = 0; i < employees.Length; i++)
        {

            employees[i].PrintEmployeeInfo();
         
            Console.WriteLine(employees[i].ToString());
        }




    }
}