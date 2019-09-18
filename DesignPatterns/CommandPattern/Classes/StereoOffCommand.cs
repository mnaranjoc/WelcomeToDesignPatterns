using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes
{
    class StereoOffCommand : ICommand
    {
        Stereo stereo;

        public StereoOffCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void execute()
        {
            this.off();
        }

        public void off()
        {
            Console.WriteLine("Stereo off");
        }
    }
}
