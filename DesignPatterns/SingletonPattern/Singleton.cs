using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    // Simple singleton
    class Singleton
    {
        private static Singleton singleton;
        private string name;

        private Singleton() { }

        public static Singleton getInstance(string _name)
        {
            if (singleton == null)
            {
                singleton = new Singleton();
                singleton.name = _name;
            }

            return singleton;
        }

        public void hello()
        {
            Console.WriteLine(string.Format("Hello: {0}", name));
        }
    }
}
