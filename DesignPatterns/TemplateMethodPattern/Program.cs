using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethodPattern.CompareTo;
using TemplateMethodPattern.Template;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program.templateTesting();
            Program.compareToTesting();

            Console.ReadLine();
        }

        private static void compareToTesting()
        {
            Duck[] ducks = {
                new Duck(8, "Daffy"),
                new Duck(2, "Dewey"),
                new Duck(7, "Howard"),
                new Duck(2, "Louie"),
                new Duck(10, "Donald"),
                new Duck(2, "Huey")
            };

            Console.WriteLine("Before sorting\n--------------");

            foreach (var duck in ducks)
                Console.WriteLine(duck.ToString());

            Array.Sort(ducks);

            Console.WriteLine("\nAfter sorting\n--------------");

            foreach (var duck in ducks)
                Console.WriteLine(duck.ToString());
        }

        public static void templateTesting()
        {
            CaffeineBeverage cofee = new Coffee();
            cofee.prepareReceipe();

            Console.WriteLine("------------");

            CaffeineBeverage tea = new Tea();
            tea.prepareReceipe();
        }
    }
}
