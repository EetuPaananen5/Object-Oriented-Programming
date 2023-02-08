using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeExercise
{
    internal class Ympyra : Muoto
    {
        private double radius;

        public Ympyra(string type, string color, double r) : base(type, color)
        {
          radius = r;
        }

        public override double GetArea()
        {
            return Math.Round( this.radius*this.radius*Math.PI, 2);
        }

        public override string GetInfo()
        {
            return "Muoto:" + this.Type +" Väri:" + this.Color+ " Säde:" + this.radius +" Pinta Ala:"+ this.GetArea();
        }
    }
}
