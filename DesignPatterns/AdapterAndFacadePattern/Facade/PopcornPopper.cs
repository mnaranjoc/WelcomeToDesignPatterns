using System;

namespace AdapterAndFacadePattern.Facade
{
    internal class PopcornPopper
    {
        internal void on()
        {
            Console.WriteLine("Popcorn Popper is on");
        }

        internal void pop()
        {
            Console.WriteLine("Popcorn Popper is popping");
        }

        internal void off()
        {
            Console.WriteLine("Popcorn Popper is off");
        }
    }
}