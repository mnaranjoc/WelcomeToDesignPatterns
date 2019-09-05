using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Singletonv2
    {
        private static Singletonv2 singleton;
        private string name;

        private Singletonv2() { }

        [MethodImpl(MethodImplOptions.Synchronized)] // Solves the multithreading problem, but makes it resource expensive
        public static Singletonv2 getInstance(string _name)
        {
            if (singleton == null)
            {
                singleton = new Singletonv2();
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
