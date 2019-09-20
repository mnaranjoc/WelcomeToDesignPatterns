using System;

namespace AdapterAndFacadePattern.Facade
{
    internal class TheatherLights
    {
        internal void dim(int v)
        {
            Console.WriteLine(string.Format("Theater Ceiling lights dimming to {0}%", v));
        }

        internal void on()
        {
            Console.WriteLine("Theater Ceiling lights on");
        }
    }
}