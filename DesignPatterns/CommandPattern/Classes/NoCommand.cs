using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes
{
    class NoCommand : ICommand
    {
        public void execute()
        {
            Console.WriteLine("");
        }
    }
}
