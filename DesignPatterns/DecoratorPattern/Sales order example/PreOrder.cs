using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Sales_Order_example
{
    class PreOrder : BaseOrder
    {
        public override double CalculateTotalOrderPrice()
        {
            Console.WriteLine("Calculating the total price of a preorder.");
            return products.Sum(x => x.Price) * 0.9;
        }
    }
}
