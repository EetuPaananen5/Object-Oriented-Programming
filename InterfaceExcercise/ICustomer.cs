using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExcercise
{
    internal interface ICustomer
    {
        Customer GetCustomer(string name);

        double GetBonus();
        
    }
}
