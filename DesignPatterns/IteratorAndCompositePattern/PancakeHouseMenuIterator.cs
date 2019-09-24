using System.Collections;

namespace IteratorAndCompositePattern
{
    internal class PancakeHouseMenuIterator : Iterator
    {
        private ArrayList menuItems;
        int position = 0;

        public PancakeHouseMenuIterator(ArrayList menuItems)
        {
            this.menuItems = menuItems;
        }

        public bool hasNext()
        {
            if (position >= menuItems.Count || menuItems[position] == null)
                return false;
            else
                return true;
        }

        public object next()
        {
            MenuItem menuItem = menuItems[position] as MenuItem;
            position++;
            return menuItem;
        }
    }
}