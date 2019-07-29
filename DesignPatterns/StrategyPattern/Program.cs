using StrategyPattern.DuckModel;
using StrategyPattern.DuckModel.Fly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck duck = new RubberDuck();
            duck.display();
            duck.fly();
            duck.quack();
            Console.WriteLine("POWER UP!");
            duck.setFlyBehavior(new FlyWithRocket());
            duck.fly();

            Console.ReadLine();
        }
    }
}
