using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class HouseBlend : Beverage
    {
        public override string getDescription()
        {
            return "House blend cofee";
        }

        public override double cost()
        {
            return .89;
        }
    }
}
