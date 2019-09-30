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
            Refactored.GumballMachine machine = new Refactored.GumballMachine(5);

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

        public static void executeOldCode()
        {
            Old.GumballMachine machine = new Old.GumballMachine(5);

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
