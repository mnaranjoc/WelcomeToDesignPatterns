namespace IteratorAndCompositePattern
{
    class DinerMenuIterator : Iterator
    {
        MenuItem[] items;
        int position = 0;

        public DinerMenuIterator(MenuItem[] items)
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
            MenuItem menuItem = items[position];
            position++;
            return menuItem;
        }
    }
}
