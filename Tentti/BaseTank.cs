using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tentti
{
    public class BaseTank
    {
        protected string name;
        public BaseTank(string name)
        {
            this.name = name;
        }
        public override string ToString()
        {
            return name;
        }

    }
}
