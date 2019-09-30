using System;

namespace StatePattern.Refactored
{
    class HasQuarterState : IState
    {
        Random randomWinner = new Random(DateTime.Now.Millisecond);
        GumballMachine gumballMachine;

        public HasQuarterState(GumballMachine gumballMachine)
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

            int winner = randomWinner.Next(10);
            if ((winner == 4) && (gumballMachine.getCount() > 1))
            {
                gumballMachine.setState(gumballMachine.getWinnerState());
            }
            else
                gumballMachine.setState(gumballMachine.getSoldState());
        }
    }
}
