using System.Collections;

namespace IteratorAndCompositePattern.Composition
{
    internal class PancakeHouseMenuIteratorC : IteratorC
    {
        private ArrayList menuItems;
        int position = 0;

        public PancakeHouseMenuIteratorC(ArrayList menuItems)
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
            MenuItemC menuItem = menuItems[position] as MenuItemC;
            position++;
            return menuItem;
        }
    }
}