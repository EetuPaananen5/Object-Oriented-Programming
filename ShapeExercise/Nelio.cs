using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeExercise
{
    internal class Nelio : Muoto
    {
        private double Leveys;
        private double Korkeus;
        public Nelio(string type, string color, double le, double ko) : base(type, color)
        {
            Leveys = le;
            Korkeus = ko;
        }

        public override double GetArea()
        {
            return Math.Round(this.Korkeus * this.Leveys , 2);
        }

        public override string GetInfo()
        {
            return "Muoto:" + this.Type + " Väri:" + this.Color + " Leveys:" + this.Leveys + " Korkeus:" + this.Korkeus + " Pinta Ala:" + this.GetArea();
        }
    }
}
