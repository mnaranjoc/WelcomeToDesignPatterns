using System;

namespace AdapterAndFacadePattern.Facade
{
    internal class Projector
    {
        internal void on()
        {
            Console.WriteLine("Projector on");
        }

        internal void wideScreenMode()
        {
            Console.WriteLine("Projector in widescreen mode (16x9 aspect ratio)");
        }

        internal void off()
        {
            Console.WriteLine("Projector off");
        }
    }
}