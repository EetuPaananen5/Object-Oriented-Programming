using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleExercise
{
    internal class Truck : Car
    {
        int Load { get; set; }
        int Consumption { get; set; }

        public Truck()
        {
        }

        public Truck(string brand, int Load, int Consumption)
        {
            this.Brand = brand;
            this.Load = Load;
            this.Consumption = Consumption;
        }


        public void PrintInfo()
        {
            Console.WriteLine("Merkki: " +this.Brand + ", Kuorman paino: "+this.Load +"kg, "+" kulutus: "+ this.Consumption+ " kuorman paino x kulutus,");
        }


        //public Truck(string brand, string model, string modelyear, double price, string engine, string type, byte doors) : base(brand, model, modelyear, price, engine, type, doors)
       // {
          //  Console.WriteLine(this.Brand, this.Load, this.Consumption);
       // }

        public int CalculateConsumpion()
        {
            return Load * Consumption;
        }
    }
}
