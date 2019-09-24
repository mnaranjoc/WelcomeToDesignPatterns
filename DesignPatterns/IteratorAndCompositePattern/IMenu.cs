namespace IteratorAndCompositePattern
{
    public interface IMenu
    {
        void addItem(string name, string description, bool vegetarian, double price);
        Iterator createIterator();
    }
}
