using System;

namespace StatePattern.Refactored
{
    class SoldOutState : IState
    {
        GumballMachine gumballMachine;

        public SoldOutState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void dispense()
        {
            Console.WriteLine("No gumball dispensed.");
        }

        public void ejectQuarter()
        {
            Console.WriteLine("Quarter returned");
            gumballMachine.setState(gumballMachine.getNoQuarterState());
        }

        public void insertQuarter()
        {
            Console.WriteLine("You can't insert another quarter");
        }

        public void turnCrank()
        {
            Console.WriteLine("You turned...");
            gumballMachine.setState(gumballMachine.getSoldState());
        }
    }
}
