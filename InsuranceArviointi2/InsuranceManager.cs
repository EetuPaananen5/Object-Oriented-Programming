using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceArviointi2
{
    internal class InsuranceManager
    {

        List<Insurance> insurances;

        public InsuranceManager()
        {
            this.insurances = new List<Insurance>();
        }
        internal void AddInsurance(string animal, string name, bool IsNeutered)
        {
            this.insurances.Add(new Insurance(animal, name, IsNeutered, GetFee(animal, IsNeutered)));
        }

        public double GetFee(string species, bool IsNeutered)
        {
            
                if (species == "koira" && IsNeutered == true)
                {
                    return 50;
                }
                if (species == "koira" && IsNeutered == false)
                {
                    return 80;
                }
                if (species == "kissa" && IsNeutered == true)
                {
                    return 40;
                }
                if (species == "kissa" && IsNeutered == false)
                {
                    return 60;
                }
                else
                {
                    return 0;
                }
        }

        internal void FindInsurances(string species, bool IsNeutered)
        {
            Console.WriteLine("Löytyi:");
            //Käydään lista läpi
            foreach(Insurance i in this.insurances)
            if(i.Species == species && i.Neutered == IsNeutered)
                {
                    Console.WriteLine(i.Species + ": " + i.Name + ", vakuutusmaksu " + GetFee(species, IsNeutered) + "e");
                    //Tulostetaan niiden vakuutusten tiedot, jotka vastaavat parametreja "species" ja "IsNeutered"
                }




        }

        internal void PrintInsurances()
        {
            Console.WriteLine("Vakuutuksia yhteensä: " + insurances.Count);
            Console.WriteLine("Vakuutukset:");
            //Käydään lista läpi
            foreach (Insurance i in this.insurances)
            {
                Console.WriteLine(i);
                //Tulostetaan kaikkien vakuutusten tiedot
            }
        }
    }
}
