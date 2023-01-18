using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeExercise
{
    internal class Employee
    {

        string name;
        string id;
        string position;
        double salary;

        public Employee(string name, string id, string position, double salary)
        {
            this.name = name;
            this.id = id;
            this.position = position;
            this.salary = salary;
        }

        public void CompareSalary(Employee employee)
        {
            if (this.salary > employee.salary)
            {
                Console.WriteLine( "henkilön "+ this.name + " palkka on suurempi kuin henkilön" + employee.name);
            }
            else if (this.salary < employee.salary)
            {
                Console.WriteLine("henkilön " + this.name + "palkka on pienempi kuin henkilön" + employee.name);
            }
            //else if (this.salary == employee.salary)
            //{
              //  Console.WriteLine("henkilön " + this.name + "palkka on yhtä suuri kuin henkilön" + employee.name);
            //}

        }

        public void PrintEmployeeInfo()
        {
            Console.WriteLine("PrintInfo Nimi: " + this.name +" ID: "+ this.id + " palkka: " + this.salary + " positio: " + this.position);

        }

        public override string? ToString()
        {
            return "ToString Nimi:" + this.name + " id: " + this.id + " palkka: " + this.salary + " positio: " + this.position;
        }
    }
}
