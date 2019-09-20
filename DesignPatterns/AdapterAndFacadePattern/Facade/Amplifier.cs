using System;

namespace AdapterAndFacadePattern.Facade
{
    internal class Amplifier
    {
        internal void on()
        {
            Console.WriteLine("Amplifier is on");
        }

        internal void setDvd()
        {
            Console.WriteLine("Amplifier setting to dvd player");
        }

        internal void setSurround()
        {
            Console.WriteLine("Amplifier setting to sorround sound");
        }

        internal void setVolume(int v)
        {
            Console.WriteLine(string.Format("Amplifier volume is {0}", v));
        }

        internal void off()
        {
            Console.WriteLine("Amplifier is off");
        }
    }
}