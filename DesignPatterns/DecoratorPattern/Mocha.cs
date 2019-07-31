using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Mocha : CondimentDecorator
    {
        Beverage beverage;

        public Mocha(Beverage _beverage)
        {
            beverage = _beverage;
        }

        public override double cost()
        {
            return beverage.cost() + .20;
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ", Mocha";
        }
    }
}
