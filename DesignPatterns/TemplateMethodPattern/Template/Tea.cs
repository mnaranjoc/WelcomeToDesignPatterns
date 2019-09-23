using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.Template
{
    class Tea : CaffeineBeverage
    {
        public override void addCondiments()
        {
            Console.WriteLine("Adding lemon");
        }

        public override void brew()
        {
            Console.WriteLine("Steeping the tea");
        }
    }
}
