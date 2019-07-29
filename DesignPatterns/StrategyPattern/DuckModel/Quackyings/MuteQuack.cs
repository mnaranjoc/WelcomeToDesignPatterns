using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.DuckModel.Quackyings
{
    class MuteQuack : IQuackable
    {
        public void quack()
        {
            Console.WriteLine("...");
        }
    }
}
