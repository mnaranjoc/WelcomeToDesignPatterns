using StrategyPattern.DuckModel.Fly;
using StrategyPattern.DuckModel.Quackyings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.DuckModel
{
    public abstract class Duck
    {
        IFlyable flyBehavior;

        IQuackable quackBehavior;

        public Duck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new Quack();
        }

        public void fly()
        {
            if (flyBehavior != null)
                flyBehavior.fly();
        }

        public void quack()
        {
            if (quackBehavior != null)
                quackBehavior.quack();
        }

        public void setFlyBehavior(IFlyable _flyBehavior)
        {
            Console.WriteLine("Changing fly behavior...");
            flyBehavior = _flyBehavior;
        }

        public void setQuackBehavior(IQuackable _quackBehavior)
        {
            Console.WriteLine("Changing quack behavior...");
            quackBehavior = _quackBehavior;
        }

        public abstract void display();
    }
}