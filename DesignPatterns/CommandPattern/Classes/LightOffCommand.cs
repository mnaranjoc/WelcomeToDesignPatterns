using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes
{
    class LightOffCommand : ICommand
    {
        Light light;

        public LightOffCommand(Light _light)
        {
            light = _light;
        }

        public void execute()
        {
            light.off();
        }

        public void undo()
        {
            light.on();
        }
    }
}
