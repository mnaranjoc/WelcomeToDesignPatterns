using System;

namespace StatePattern.Refactored
{
    class GumballMachine
    {
        public static IState soldOutState;
        public static IState noQuarterState;
        public static IState hasQuarterState;
        public static IState soldState;

        IState state = soldOutState;
        int count = 0;

        public GumballMachine(int numberGumballs)
        {
            soldOutState = new SoldOutState(this);
            noQuarterState = new NoQuarterState(this);
            hasQuarterState = new HasQuarterState(this);
            soldState = new SoldState(this);

            this.count = numberGumballs;
            if (numberGumballs > 0)
            {
                state = noQuarterState;
            }
        }

        public void insertQuarter()
        {
            state.insertQuarter();
        }

        public void ejectQuarter()
        {
            state.ejectQuarter();
        }

        public void turnCrank()
        {
            state.turnCrank();
            state.dispense();
        }

        public void releaseBall()
        {
            Console.WriteLine("A gumball comes rolling out of the slot...");
            if (count != 0)
                count--;
        }

        public void setState(IState state)
        {
            this.state = state;
        }

        public IState getSoldOutState()
        {
            return soldOutState;
        }

        public IState getNoQuarterState()
        {
            return noQuarterState;
        }

        public IState getHasQuarterState()
        {
            return hasQuarterState;
        }

        public IState getSoldState()
        {
            return soldState;
        }

        public int getCount()
        {
            return count;
        }

        public override string ToString()
        {
            string ret = string.Format("\nMighty Gumball, Inc\nModel 2004\nInventory: {0} gumballs\nMachine is waiting for quarter\n", count);

            return ret;
        }
    }
}
