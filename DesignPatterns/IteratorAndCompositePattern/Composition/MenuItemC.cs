namespace IteratorAndCompositePattern.Composition
{
    class MenuItemC
    {
        public string name { get; set; }
        public string description { get; set; }
        public bool vegetarian { get; set; }
        public double price { get; set; }

        public MenuItemC(string name, string description, bool vegetarian, double price)
        {
            this.name = name;
            this.description = description;
            this.vegetarian = vegetarian;
            this.price = price;
        }
    }
}
