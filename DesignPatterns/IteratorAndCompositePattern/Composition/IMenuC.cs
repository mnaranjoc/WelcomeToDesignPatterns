namespace IteratorAndCompositePattern.Composition
{
    public interface IMenuC
    {
        void addItem(string name, string description, bool vegetarian, double price);
        IteratorC createIterator();
    }
}
