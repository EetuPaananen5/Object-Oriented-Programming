using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeExercise
{
    abstract class Muoto
    {
        internal protected string Type;
        internal protected string Color;

        protected Muoto(string type, string color)
        {
            Type = type;
            Color = color;
        }

        public abstract double GetArea();
    
        public abstract string GetInfo();
        
        public string GetColor()
        {
            return Color;
        }
        
    }
}
