using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.DuckModel.Fly
{
    class FlyWithRocket : IFlyable
    {
        public void fly()
        {
            Console.WriteLine("I'm rocket flying!");
        }
    }
}
