using System;

namespace StatePattern.Refactored
{
    class SoldState : IState
    {
        GumballMachine gumballMachine;

        public SoldState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void dispense()
        {
            gumballMachine.releaseBall();
            if (gumballMachine.getCount() > 0)
                gumballMachine.setState(gumballMachine.getNoQuarterState());
            else
            {
                Console.WriteLine("Oops, out of gumballs!");
                gumballMachine.setState(gumballMachine.getSoldOutState());
            }
        }

        public void ejectQuarter()
        {
            Console.WriteLine("Sorry you've already turned the crank");
        }

        public void insertQuarter()
        {
            Console.WriteLine("Please wait we've already giving you a gumball");
        }

        public void turnCrank()
        {
            Console.WriteLine("Turning the crank twice, doesn't give you another gumball!!");
        }
    }
}
