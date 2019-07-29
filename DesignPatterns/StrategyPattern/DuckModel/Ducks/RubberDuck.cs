using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.DuckModel
{
    class RubberDuck : Duck
    {
        public override void display()
        {
            Console.WriteLine("I'm a Rubber Duck");
        }
    }
}
