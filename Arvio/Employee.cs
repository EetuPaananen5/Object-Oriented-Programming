using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Arvio
{
    internal class Employee
    {
        string name;
        int id;
        string position;
        double salary;

        public Employee()
        {
            this.name = string.Empty;
            this.id = 0;
            this.position = string.Empty;
            this.salary = 0;

        }

        public Employee(string name, int id, string position, double salary)
        {
            this.name = name;
            this.id = id;
            this.position = position;
            this.salary = salary;
        }

        public override string? ToString()
        {
            return "name: " + this.name + " " + "id: " + this.id + " " + "position: " + this.position + " " + "salary: " + this.salary;
        }

        public double CompareSalary(Employee employee)
        {
            return this.salary - employee.salary;
        }

        internal void PrintEmployeeInfo()
        {
            Console.WriteLine("name: " + (this.name) + " " + "id: " + (this.id) + " " + "position: " + (this.position) + " " + "salary: " + (this.salary));
        }
    }
}