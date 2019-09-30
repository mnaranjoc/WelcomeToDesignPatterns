using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class GumballMachine
    {
        public static int SOLD_OUT = 0;
        public static int NO_QUARTER = 1;
        public static int HAS_QUARTER = 2;
        public static int SOLD = 3;

        int state = SOLD_OUT;
        int count = 0;

        public GumballMachine(int  count)
        {
            this.count = count;
            if (count > 0)
            {
                state = NO_QUARTER;
            }
        }

        public void insertQuarter()
        {
            if (state == HAS_QUARTER)
                Console.WriteLine("You can't insert another quarter!");
            else if (state == NO_QUARTER)
            {
                Console.WriteLine("You inserted a quarter");
                state = HAS_QUARTER;
            }
            else if (state == SOLD_OUT)
                Console.WriteLine("You can't insert a quarter, the machine is sold out");
            else if (state == SOLD)
                Console.WriteLine("Please wait, we're already giving you a gumball");
        }

        public void ejectQuarter()
        {
            if (state == HAS_QUARTER)
            {
                Console.WriteLine("Quarter returned");
                state = NO_QUARTER;
            }
            else if (state == NO_QUARTER)
                Console.WriteLine("You haven't inserted a quarter");
            else if (state == SOLD)
                Console.WriteLine("Sorry, you already turned the crank");
            else if (state == SOLD_OUT)
                Console.WriteLine("You can't eject, you haven't inserted a quarter yet");
        }

        public void turnCrank()
        {
            if (state == SOLD)
                Console.WriteLine("Turning twice doens't get you another gumball!!");
            else if (state == NO_QUARTER)
                Console.WriteLine("You turned but there's no quarter");
            else if (state == SOLD_OUT)
                Console.WriteLine("You turned but there are no gumballs");
            else if (state == HAS_QUARTER)
            {
                Console.WriteLine("You turned...");
                state = SOLD;
                dispense();
            }
        }

        public void dispense()
        {
            if (state == SOLD)
            {
                Console.WriteLine("A gumball comes out rolling on the slot");
                count--;
                if (count == 0)
                {
                    Console.WriteLine("Oops, out of gumballs");
                    state = SOLD_OUT;
                }
                else
                    state = NO_QUARTER;
            }
            else if (state == NO_QUARTER)
                Console.WriteLine("You need to pay first");
            else if (state == SOLD_OUT)
                Console.WriteLine("No gumball dispensed");
            else if (state == HAS_QUARTER)
                Console.WriteLine("No gumball dispensed");
        }

        public override string ToString()
        {
            string ret = string.Format("\nMighty Gumball, Inc\nModel 2004\nInventory: {0} gumballs\nMachine is waiting for quarter\n", count);

            return ret;
        }
    }
}
