using AdapterAndFacadePattern.Adapter.DuckModel;
using AdapterAndFacadePattern.Adapter.TurkeyModel;
using AdapterAndFacadePattern.Facade;
using System;

namespace AdapterAndFacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program.testAdapter();
            Program.testFacade();

            Console.ReadLine();
        }

        public static void testFacade()
        {
            Amplifier amp = new Amplifier();
            Tuner tuner = new Tuner();
            DvdPlayer dvd = new DvdPlayer();
            CDPlayer cd = new CDPlayer();
            Projector projector = new Projector();
            TheatherLights lights = new TheatherLights();
            Screen screen = new Screen();
            PopcornPopper popper = new PopcornPopper();

            HomeTheaterFacade facade = new HomeTheaterFacade(amp, tuner, dvd, cd, projector, lights, screen, popper);
            facade.watchMovie("The Matrix");
            facade.endMovie();
        }

        public static void testAdapter()
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
        }
    }
}
