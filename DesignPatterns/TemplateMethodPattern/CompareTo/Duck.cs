using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.CompareTo
{
    class Duck : IComparable
    {
        int weight;
        string name;

        public Duck(int weight, string name)
        {
            this.weight = weight;
            this.name = name;
        }

        public override string ToString()
        {
            string ret = this.name + "weighs " + weight.ToString();
            return ret;
        }

        public int CompareTo(Object obj)
        {
            Duck objDuck = obj as Duck;
            if (objDuck != null)
            {
                if (this.weight < objDuck.weight)
                    return -1;
                else if (this.weight == objDuck.weight)
                    return 0;
                else
                    return 1;
            }
            else
                return 1;
        }
    }
}
