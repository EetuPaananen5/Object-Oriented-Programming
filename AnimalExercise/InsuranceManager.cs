using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalExercise
{
    internal class InsuranceManager 
    {

        List<Insurance> lista;

        public InsuranceManager()
        {
            this.lista = new List<Insurance>();
          
            
        }

        public void AddInsurance(string animal, string name, bool isNeutered)
        {
            lista.Add(new Insurance(animal, name, isNeutered, GetFee(animal, isNeutered)));
          // Console.WriteLine("Vakuutus tulee eläimelle "+ animal + " jonka nimi on " + name + " onko leikattu: " +isNeutered);
          // Console.WriteLine("hinta "  + GetFee(animal, isNeutered));
        }

        private static double GetFee(string species, bool isNeutererd)
        {
         /* • Leikattu koira maksaa 50 €
            • Leikkaamaton koira maksaa 80 €
            • Leikattu kissa maksaa 40 €
            • Leikkaamaton kissa maksaa 60 €
            • Lintu tai matelija ei maksa mitään*/



            if (species == "koira" && isNeutererd== true)
            {
                return 50;
            }
        
            else if (species == "koira" && isNeutererd == false)
            {
                return 80;
            }

            else if (species == "kissa" && isNeutererd == true)
            {
                return 40;
            }

            else if (species == "kissa" && isNeutererd == false)
            {
                return 60;
            }

            else if (species == "lintu")
            {
                return 0;
            }

            else 
            {
                return 0;
            }
        }
        internal void FindInsurances(string species, bool isNeutered)
        {
            foreach(Insurance i in this.lista) //käy listan läpi  // tulostaa ne tietyt vakuutusten tiedot jotka vastaa parametreja species ja isNeutered
            {
                if (i.Species == species && i.Neutered == isNeutered) 
                {
                    Console.WriteLine( " Laji: " + species  +", nimi: "+  i.Name + ", hinta: "  + i.Fee);
                }

              
            }
        }

        internal void PrintInsurances()
        {
            foreach (Insurance insurance in this.lista) //käy lista läpi
            {
                Console.WriteLine(insurance);
                
                //Tulostaa kaikkien vakuutusten tiedot
            }
        }
    }


}
