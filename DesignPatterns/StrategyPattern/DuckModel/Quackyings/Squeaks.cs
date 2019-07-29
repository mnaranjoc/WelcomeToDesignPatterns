using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.DuckModel.Quackyings
{
    class Squeak : IQuackable
    {
        public void quack()
        {
            Console.WriteLine("squeak!");
        }
    }
}
