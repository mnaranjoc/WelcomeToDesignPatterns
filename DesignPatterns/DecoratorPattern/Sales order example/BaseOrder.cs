﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Sales_Order_example
{
    public abstract class BaseOrder
    {
        protected List<Product> products = new List<Product>
        {
            new Product {Name = "Phone", Price = 587},
            new Product {Name = "Tablet", Price = 800},
            new Product {Name = "PC", Price = 1200}
        };

        public abstract double CalculateTotalOrderPrice();
    }
}
