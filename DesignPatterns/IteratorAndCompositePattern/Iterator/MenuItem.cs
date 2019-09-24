namespace IteratorAndCompositePattern.Iterator
{
    class MenuItem
    {
        public string name { get; set; }
        public string description { get; set; }
        public bool vegetarian { get; set; }
        public double price { get; set; }

        public MenuItem(string name, string description, bool vegetarian, double price)
        {
            this.name = name;
            this.description = description;
            this.vegetarian = vegetarian;
            this.price = price;
        }
    }
}
