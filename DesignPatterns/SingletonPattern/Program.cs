using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var singleton = Singleton.getInstance("manuel");
            singleton.hello();

            var singleton2 = Singleton.getInstance("nelly");
            singleton2.hello();

            Console.ReadLine();
        }
    }
}
