using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleExercise
{
    public class Vehicle 
    {
        protected string Brand;
        protected string Model;
        protected string Modelyear;
        protected double Price;

        public Vehicle(string brand, string model, string modelyear, double price)
        {
            this.Brand = brand;
            this.Model = model;
            this.Modelyear = modelyear;
            this.Price = price;
        }

        public Vehicle()
        {

        }

        public virtual void PrintInfo()
        {
            Console.WriteLine(this.Brand + "\n " + this.Model + "\n " + this.Modelyear + "\n " + this.Price);
        }

        
    }
    
}
