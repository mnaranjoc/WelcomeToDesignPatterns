using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Singletonv3
    {
        private static Singletonv3 singleton = new Singletonv3(); // Solves the resource expensive and multithreading problems
        private string name;

        private Singletonv3() { }
        
        public static Singletonv3 getInstance(string _name)
        {
            // Now it instantiates the class on the first load of any thread.
            /*if (singleton == null)
            {
                singleton = new Singletonv3();
                singleton.name = _name;
            }*/
            return singleton;
        }

        public void hello()
        {
            Console.WriteLine(string.Format("Hello: {0}", name));
        }
    }
}
