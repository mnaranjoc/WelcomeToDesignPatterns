using StatePattern.Old;
using System;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program.executeOldCode();
            Program.executeRefactoredCode();

            Console.ReadLine();
        }

        public static void executeRefactoredCode()
        {

        }

        public static void executeOldCode()
        {
            GumballMachine machine = new GumballMachine(5);

            Console.WriteLine(machine);

            machine.insertQuarter();
            machine.turnCrank();

            Console.WriteLine(machine);

            machine.insertQuarter();
            machine.ejectQuarter();
            machine.turnCrank();

            Console.WriteLine(machine);

            machine.insertQuarter();
            machine.turnCrank();
            machine.insertQuarter();
            machine.turnCrank();
            machine.ejectQuarter();

            Console.WriteLine(machine);

            machine.insertQuarter();
            machine.insertQuarter();
            machine.turnCrank();
            machine.insertQuarter();
            machine.turnCrank();
            machine.insertQuarter();
            machine.turnCrank();

            Console.WriteLine(machine);
        }
    }
}
