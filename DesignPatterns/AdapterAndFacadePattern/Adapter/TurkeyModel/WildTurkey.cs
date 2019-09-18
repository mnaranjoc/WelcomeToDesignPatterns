using System;

namespace AdapterAndFacadePattern.Adapter.TurkeyModel
{
    class WildTurkey : ITurkey
    {
        public void fly()
        {
            Console.WriteLine("I'm flying a short distance");
        }

        public void gobble()
        {
            Console.WriteLine("Gobble gobble");
        }
    }
}
