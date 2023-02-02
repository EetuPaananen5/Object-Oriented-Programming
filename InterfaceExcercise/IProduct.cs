using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExcercise
{
    internal interface IProduct
    {
        Product GetProduct(string Name);
        double CalculateTotal();
       
    }
}
