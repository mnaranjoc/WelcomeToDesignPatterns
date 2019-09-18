using System;

namespace CommandPattern.Classes
{
    public class Stereo
    {
        string name;

        public Stereo(string name)
        {
            this.name = name;
        }

        internal void on()
        {
            Console.WriteLine(name + " stereo is on");
        }

        internal void setCD()
        {
            Console.WriteLine(name + " stereo set cd");
        }

        internal void off()
        {
            Console.WriteLine(name + " stereo is off");
        }

        internal void setVolume(int v)
        {
            Console.WriteLine(name + " stereo volume is " + v.ToString());
        }
    }
}