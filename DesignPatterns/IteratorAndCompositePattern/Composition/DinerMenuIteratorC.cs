namespace IteratorAndCompositePattern.Composition
{
    class DinerMenuIteratorC : IteratorC
    {
        MenuItemC[] items;
        int position = 0;

        public DinerMenuIteratorC(MenuItemC[] items)
        {
            this.items = items;
        }

        public bool hasNext()
        {
            if (position >= items.Length || items[position] == null)
                return false;
            else
                return true;
        }

        public object next()
        {
            MenuItemC menuItem = items[position];
            position++;
            return menuItem;
        }
    }
}
