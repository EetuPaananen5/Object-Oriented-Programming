using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExcercise
{
    internal class Customer : ICustomer
    {
        private string name;
        private double purchases;
        private List<Customer> storeCustomers = new List<Customer>();

        public Customer(string name, double purchases)
        {
            this.name = name;
            this.purchases = purchases;
        }

        public double GetBonus()
        {
            if(this.purchases > 1000)
            {
                double bonus = this.purchases * 0.02;
                return bonus;
            }
            else if (this.purchases > 1000 && this.purchases <= 2000)
            {
                double bonus = this.purchases * 0.03;
                return bonus;
            }
            else
            {
                double bonus = this.purchases * 0.05;
                return bonus;
            }
        }

        public Customer GetCustomer(string Name)
        {

            if (Name.Equals(this.name))
            {
                return this;
            }
            else
            {
                return null;
            }
        }

        public override string? ToString()
        {
            return "Nimi: " + this.name + " \nOstokset: "+ this.purchases +" euroa" ;
        }
    }
}
