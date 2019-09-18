using AdapterAndFacadePattern.Adapter.DuckModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterAndFacadePattern.Adapter.TurkeyModel
{
    class DuckAdapter : ITurkey
    {
        IDuck duck;

        public DuckAdapter(IDuck duck)
        {
            this.duck = duck;
        }

        public void fly()
        {
            duck.fly();
        }

        public void gobble()
        {
            duck.quack();
        }
    }
}
