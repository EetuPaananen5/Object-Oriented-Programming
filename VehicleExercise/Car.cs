using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleExercise
{
    internal class Car : Vehicle
    {

        private string Engine { get; set; }
        private string Type { get; set; }
        private byte Doors { get; set; }
        

        public Car()
        {
            
        }

        public Car(string brand, string model, string modelyear, double price, string engine, string type, byte doors)
        {
            Brand = brand;
            Model = model;
            Modelyear = modelyear;
            Price = price;
            Engine = engine;
            Type = type;
            Doors = doors;
        }
        public override void PrintInfo()
        {
           
            Console.WriteLine(this.Brand + "\n " + this.Model + "\n " + this.Modelyear + "\n " + this.Price + "\n " + this.Engine + "\n " + this.Type + "\n " + this.Doors);
        }

     
     
        public override string? ToString()
        {
            return " ToString tulostus " + "\n " + " Merkki: " + this.Brand + "\n " + " Malli: " + this.Model + "\n " + " Vuosimalli: " + this.Modelyear + "\n " + " Hinta: " + this.Price + "\n " + " Moottori " + this.Engine + "\n " + " Moottorin tyyppi " + this.Type + "\n " + " Ovien lukumäärä " + this.Doors;
        }

        public override bool Equals(object? obj)
        {
            return obj is Car car &&
                   Brand == car.Brand &&
                   Model == car.Model &&
                   Modelyear == car.Modelyear &&
                   Price == car.Price &&
                   Engine == car.Engine &&
                   Type == car.Type &&
                   Doors == car.Doors;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Brand, Model, Modelyear, Price, Engine, Type, Doors);
        }
    }


}
