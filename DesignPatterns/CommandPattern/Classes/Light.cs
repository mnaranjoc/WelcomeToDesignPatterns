using System;

namespace CommandPattern.Classes
{
    class Light
    {
        string name;

        public Light(string name)
        {
            this.name = name;
        }

        public void on()
        {
            Console.WriteLine(name + " is on");
        }

        public void off()
        {
            Console.WriteLine(name + " is off");
        }
    }
}
