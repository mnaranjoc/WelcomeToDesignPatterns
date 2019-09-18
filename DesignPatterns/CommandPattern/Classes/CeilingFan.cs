using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes
{
    class CeilingFan
    {
        public static readonly int HIGH = 3;
        public static readonly int MEDIUM = 2;
        public static readonly int LOW = 1;
        public static readonly int OFF = 0;
        string location;
        int speed;

        public CeilingFan(string location)
        {
            this.location = location;
            speed = OFF;
        }

        public void high()
        {
            speed = HIGH;
            Console.WriteLine("Speed is set to HIGH");
        }

        public void medium()
        {
            speed = MEDIUM;
            Console.WriteLine("Speed is set to MEDIUM");
        }

        public void low()
        {
            speed = LOW;
            Console.WriteLine("Speed is set to LOW");
        }

        public void off()
        {
            speed = OFF;
            Console.WriteLine("Speed is set to OFF");
        }

        public int getSpeed()
        {
            return speed;
        }

    }
}
