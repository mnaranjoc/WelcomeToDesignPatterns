using System;

namespace AdapterAndFacadePattern.Facade
{
    internal class Screen
    {
        internal void down()
        {
            Console.WriteLine("Screen is down");
        }

        internal void up()
        {
            Console.WriteLine("Screen is up");
        }
    }
}