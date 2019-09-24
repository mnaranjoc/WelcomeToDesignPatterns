using IteratorAndCompositePattern.Iterator;
using System;
using System.Collections;

namespace IteratorAndCompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.IteratorExcercise();
            Program.CompositionExcercise();

            Console.ReadLine();
        }

        public static void CompositionExcercise()
        {

        }

        public static void IteratorExcercise()
        {
            ArrayList menus = new ArrayList();
            menus.Add(new DinerMenu());
            menus.Add(new PancakeHouseMenu());

            Waitress waitress = new Waitress(menus);
            waitress.printMenu();
        }
    }
}
