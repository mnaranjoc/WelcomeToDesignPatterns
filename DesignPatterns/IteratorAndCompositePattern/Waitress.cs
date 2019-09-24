using System;

namespace IteratorAndCompositePattern
{
    class Waitress
    {
        IMenu pancakeHouseMenu;
        IMenu dinerMenu;

        public Waitress(IMenu pancakeHouseMenu, IMenu dinerMenu)
        {
            this.pancakeHouseMenu = pancakeHouseMenu;
            this.dinerMenu = dinerMenu;
        }

        public void printMenu()
        {
            Console.WriteLine("*MENU*");

            Iterator pancakeIterator = pancakeHouseMenu.createIterator();
            Console.WriteLine("\nBREAKFAST");
            printMenu(pancakeIterator);

            Iterator dinerIterator = dinerMenu.createIterator();
            Console.WriteLine("\nLUNCH");
            printMenu(dinerIterator);
        }

        private void printMenu(Iterator iterator)
        {
            while(iterator.hasNext())
            {
                MenuItem menuItem = iterator.next() as MenuItem;

                Console.WriteLine(string.Format("{0}\t{1} - {2}", menuItem.price, menuItem.name, menuItem.description));
            }
        }
    }
}
