using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExcercise
{
    internal class Product : IProduct
    {
        public string Name;
        public double Price;
        public int Count;


        public Product(string name, double price, int count)
        {
            this.Name = name;
            this.Price = price;
            this.Count = count;
        }

        public double CalculateTotal()
        {
            return  this.Price  * this.Count;
        }

        public Product GetProduct(string Name)
        {
            if(Name.Equals(this.Name))
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
            return $"Tuote: {this.Name}, {this.Price} €/kpl, määrä {this.Count} kpl";
        }
    }
}
