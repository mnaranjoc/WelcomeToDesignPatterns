using System;
using System.Collections;

namespace IteratorAndCompositePattern.Iterator
{
    class Waitress
    {
        ArrayList menus;

        public Waitress(ArrayList menus)
        {
            this.menus = menus;
        }

        public void printMenu()
        {
            Console.WriteLine("*MENU*");

            IEnumerator menuIterator = menus.GetEnumerator();

            while (menuIterator.MoveNext())
            {
                IMenu menuItem = menuIterator.Current as IMenu;
                printMenu(menuItem.createIterator());
                Console.WriteLine("\n");
            }
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
