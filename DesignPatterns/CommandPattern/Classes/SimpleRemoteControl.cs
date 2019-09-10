using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes
{
    class SimpleRemoteControl
    {
        ICommand slot;

        public SimpleRemoteControl() { }

        public void setCommand(ICommand _command)
        {
            slot = _command;
        }

        public void buttonWasPressed()
        {
            slot.execute();
        }
    }
}
