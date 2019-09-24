
using System;

namespace IteratorAndCompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            DinerMenu dinerMenu = new DinerMenu();
            PancakeHouseMenu pancakeMenu = new PancakeHouseMenu();
            Waitress waitress = new Waitress(pancakeMenu, dinerMenu);

            waitress.printMenu();

            Console.ReadLine();
        }
    }
}
