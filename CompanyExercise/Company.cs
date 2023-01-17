using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CompanyExercise
{
    internal class Company
    {
        string title;
        string address;
        string phone;
        int outcome;
        int expense;


        public Company()
        {
            title = string.Empty;
            address = string.Empty;
            phone = string.Empty;
            outcome = 0;
            expense = 0;

        }

        public Company(Company kopio) //tässä on kopio funktio
        {
            this.title = kopio.title;
            this.address = kopio.address;
            this.phone = kopio.phone;
            this.outcome = kopio.outcome;
            this.expense = kopio.expense;
        }


        public Company(string title, string address, string phone, int outcome, int expense)
        {
            this.title = title;
            this.address = address;
            this.phone = phone;
            this.outcome = outcome;
            this.expense = expense;
        }

        public void VoittoFunktio ()
        {
           

           int tulos = (this.outcome-this.expense)/ this.expense * 100;

            if (tulos < 100)
            {
                Console.WriteLine(" Kehnoa tulosta koska voitto on" + tulos);
            }
            else if (tulos >= 100 && tulos < 200)
            {
                Console.WriteLine(" Välttävä tulos , voitto on " + tulos);

            }
            else if (tulos >= 200 && tulos < 300)
            {
                Console.WriteLine(" tyydyttävä , voitto on " + tulos);

            }
            else
            {
                Console.WriteLine(" hyvä voitto on " + tulos);

            }


        }

        public void setTitle(string value)
        {
            this.title = value;
        }

        public void Info(string title, string phone, string address, int outcome, int expense)
        {
            this.title = title;
            this.phone = phone;
            this.address = address;
            this.outcome = outcome;
            this.expense = expense;
        }
      
        public void PrintInfo()
        {
            Console.WriteLine("Yrityksen nimi:" + this.title );
            
        }

        public override string? ToString()
        {
            return " nimi "+ this.title + " puhelin " + this.phone + " osoite " + this.address +" tulot "+ this.expense +" menot "+this.outcome;
        }
    }
}
