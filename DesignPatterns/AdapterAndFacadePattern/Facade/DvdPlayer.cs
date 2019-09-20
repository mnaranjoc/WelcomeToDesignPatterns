using System;

namespace AdapterAndFacadePattern.Facade
{
    internal class DvdPlayer
    {
        internal void on()
        {
            Console.WriteLine("DVD Player is on");
        }

        internal void play(object movie)
        {
            Console.WriteLine(string.Format("DVD Player playing {0}!", movie));
        }

        internal void stop()
        {
            Console.WriteLine("DVD Player stopped");
        }

        internal void eject()
        {
            Console.WriteLine("DVD Player ejecting dvd");
        }

        internal void off()
        {
            Console.WriteLine("DVD Player is off");
        }
    }
}