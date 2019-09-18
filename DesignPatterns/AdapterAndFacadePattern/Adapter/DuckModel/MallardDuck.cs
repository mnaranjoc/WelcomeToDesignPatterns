using System;

namespace AdapterAndFacadePattern.Adapter.DuckModel
{
    class MallardDuck : IDuck
    {
        public void fly()
        {
            Console.WriteLine("I'm Flying");
        }

        public void quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
