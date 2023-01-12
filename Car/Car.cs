using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarExercise
{

    public class Car
    {
        string brand;
        double speed;
        

        public Car()
        {
            this.brand = string.Empty;
            this.speed = 0;
        }

      

        internal void AskData()
        {
            
                Console.WriteLine("Mikä merkki?");
                 this.brand = Console.ReadLine();

                Console.WriteLine("mikä nopeus");
                double.TryParse(Console.ReadLine(),out this.speed);

           
        }

        public void ShowCarInfo()
        {
            Console.WriteLine( "Auton merkki on " + this.brand + " " + " auton nopeus on " + this.speed);
        }

        internal void Accelerate(int value)
        {
            
            if(value < 0)
            {
                Console.WriteLine("Negatiivinen nopeus ei mahollinen");
            }
            else
            {
                this.speed += value;
            }
            
        }

        internal void Brake(double minus)
        {
            this.speed *= minus;
        }
    }


}

  