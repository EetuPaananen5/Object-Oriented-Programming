using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceArviointi2
{
    public class Insurance
    {
        private string species;
        private string name;
        private bool neutered;
        private double fee;
        public Insurance(string animal, string name, bool isNeutered, double payment)
        {
            this.Species = animal;
            this.Name = name;
            this.neutered = isNeutered;
            this.Fee = payment;
        }

        public string Species { get => species; set => species = value; }
        public bool Neutered { get => neutered; set => neutered = value; }
        public double Fee { get => fee; set => fee = value; }
        public string Name { get => name; set => name = value; }

        public string GetNeuteredInfo()
        {
            if (neutered)
            {
                return "leikattu";
            }
            else
            {
                return "leikkaamaton";
            }
        }
        public override string ToString()
        {
            return this.Species + ": " + this.Name + ", " + this.GetNeuteredInfo();
        }
        
    }
    
}
