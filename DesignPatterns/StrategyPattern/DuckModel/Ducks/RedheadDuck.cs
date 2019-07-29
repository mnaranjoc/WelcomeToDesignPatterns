using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.DuckModel
{
    class RedheadDuck : Duck
    {
        public override void display()
        {
            Console.WriteLine("I'm a RedheadDuck Duck");
        }
    }
}
