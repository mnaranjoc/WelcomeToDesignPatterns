using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethodPattern.Template;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CaffeineBeverage cofee = new Coffee();
            cofee.prepareReceipe();

            Console.WriteLine("------------");

            CaffeineBeverage tea = new Tea();
            tea.prepareReceipe();

            Console.ReadLine();
        }
    }
}
