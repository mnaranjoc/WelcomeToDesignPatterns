using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.DuckModel
{
    class DecoyDuck : Duck
    {
        public override void display()
        {
            Console.WriteLine("I'm a Decoy Duck");
        }
    }
}
