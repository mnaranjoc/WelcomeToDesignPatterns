
using System;
using System.Collections;

namespace IteratorAndCompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList menus = new ArrayList();
            menus.Add(new DinerMenu());
            menus.Add(new PancakeHouseMenu());

            Waitress waitress = new Waitress(menus);
            waitress.printMenu();

            Console.ReadLine();
        }
    }
}
