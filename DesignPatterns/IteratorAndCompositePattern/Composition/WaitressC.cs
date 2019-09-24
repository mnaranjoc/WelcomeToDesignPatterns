using System;
using System.Collections;

namespace IteratorAndCompositePattern.Composition
{
    class WaitressC
    {
        ArrayList menus;

        public WaitressC(ArrayList menus)
        {
            this.menus = menus;
        }

        public void printMenu()
        {
            Console.WriteLine("*MENU*");

            IEnumerator menuIterator = menus.GetEnumerator();

            while (menuIterator.MoveNext())
            {
                IMenuC menuItem = menuIterator.Current as IMenuC;
                printMenu(menuItem.createIterator());
                Console.WriteLine("\n");
            }
        }

        private void printMenu(IteratorC iterator)
        {
            while (iterator.hasNext())
            {
                MenuItemC menuItem = iterator.next() as MenuItemC;

                Console.WriteLine(string.Format("{0}\t{1} - {2}", menuItem.price, menuItem.name, menuItem.description));
            }
        }
    }
}
