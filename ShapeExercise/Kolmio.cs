using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ShapeExercise
{
    internal class Kolmio : Muoto
    {
        private double Leveys;
        private double Korkeus;
        public Kolmio(string type, string color, double l, double k) : base(type, color)
        {
         Leveys = l;
         Korkeus = k;
        }

        public override double GetArea()
        {
            return Math.Round(this.Korkeus * this.Leveys/2, 2);
        }

        public override string GetInfo()
        {
            return "Muoto:" + this.Type + " Väri:" + this.Color + " Leveys:" + this.Leveys + " Korkeus:"+ this.Korkeus+ " Pinta Ala:" + this.GetArea();
        }
    }
}
