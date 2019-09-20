using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterAndFacadePattern.Facade
{
    class HomeTheaterFacade
    {
        Amplifier amp;
        Tuner tuner;
        DvdPlayer dvd;
        CDPlayer cd;
        Projector projector;
        TheatherLights lights;
        Screen screen;
        PopcornPopper popper;

        public HomeTheaterFacade(
               Amplifier amp,
               Tuner tuner,
               DvdPlayer dvd,
               CDPlayer cd,
               Projector projector,
               TheatherLights lights,
               Screen screen,
               PopcornPopper popper)
        {
            this.amp = amp;
            this.tuner = tuner;
            this.dvd = dvd;
            this.cd = cd;
            this.projector = projector;
            this.lights = lights;
            this.screen = screen;
            this.popper = popper;
        }

        public void watchMovie(string movie)
        {
            Console.WriteLine("Get ready to watch a movie!");
            popper.on();
            popper.pop();
            lights.dim(10);
            screen.down();
            projector.on();
            projector.wideScreenMode();
            amp.on();
            amp.setDvd();
            amp.setSurround();
            amp.setVolume(5);
            dvd.on();
            dvd.play(movie);
            Console.WriteLine("");
        }

        public void endMovie()
        {
            Console.WriteLine("Shutting movie theater down...!");
            popper.off();
            lights.on();
            screen.up();
            projector.off();
            amp.off();
            dvd.stop();
            dvd.eject();
            dvd.off();
            Console.WriteLine("");
        }
    }
}
