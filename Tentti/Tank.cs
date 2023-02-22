using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tentti
{
    public class Tank : BaseTank ,ITank
    {
        private int capacity;
        private int amount;

        public Tank(string name, int capacity) : base(name)
        {
            this.capacity = capacity;
           
        }

        public string AddToTank(int amount)
        {
            if (amount < 0) //Jos määrä on negatiivinen, säiliön tila ei muutu.
            {
                return $"säiliön {name} tilaa ei muutettu"; // Palauttaa nimen
            }
            int TilaaJäljellä = capacity - this.amount; // funktio TilaaJäljellä on matikka funktio mikä miinustaa kapasiteetistä käytetyn määrän
            if (amount <= TilaaJäljellä)
            {
                this.amount += amount;
                return $"säiliöön {name} lisättiin {amount} yksikköä"; // lisää nesteetä kaikki ok säiliössä vielä tilaa
            }
            else
            {
                this.amount = capacity;
                return $"säiliöön {name} lisättiin {TilaaJäljellä} yksikköä, säiliö on täynnä"; // Nesteen määrä = tilan määrä eli täynnä
            }

        }

        public int ClearTank() // tyhjentää ja palauttaa amountin 0 eli tyhjä
        {
           return this.amount = 0;
        }

        public int GetAmount()  // Palauttaa amountin eli nestemäärän
        {
            return amount;
        }

        public string RemoveFromTank(int amount)  // tämä on poisto funktio if else rakenne
        {
            if (amount < 0)  // aluksi katsotaan onko poistettava määrä 0, sitten katsotaan poistetaanko kaikki neste, muuten eli else poistetaan mutta sinne jää nestettä säiliöön
            {
                return $"säiliön {name} tilaa ei muutettu";
            }
            if (amount > this.amount)
            {
                amount = this.amount;
            }
            this.amount -= amount;
            if (this.amount == 0)
            {
                return $"säiliöstä {name} poistettiin {amount} yksikköä, säiliö on tyhjä"; // amount = 0
            }
            else
            {
                return $"säiliöstä {name} poistettiin {amount} yksikköä";
            }
        }

        public override string ToString() //Lisää Tank-luokkaan myös metodi ToString(), joka palauttaa säiliön tilanteen merkkijonona,
        {
            return $"säiliö {name}: kapasiteetti: {capacity}, nestettä: {amount},";
        }
    }
}
