using AdapterAndFacadePattern.Adapter.DuckModel;
using AdapterAndFacadePattern.Adapter.TurkeyModel;
using System;

namespace AdapterAndFacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IDuck mallardDuck = new MallardDuck();
            mallardDuck.fly();
            mallardDuck.quack();

            Console.WriteLine("---------------");
            
            IDuck turkeyAdapter = new TurkeyAdapter(new WildTurkey());
            turkeyAdapter.fly();
            turkeyAdapter.quack();

            Console.WriteLine("---------------");

            ITurkey duckAdapter = new DuckAdapter(new MallardDuck());
            duckAdapter.fly();
            duckAdapter.gobble();

            Console.ReadLine();
        }
    }
}
