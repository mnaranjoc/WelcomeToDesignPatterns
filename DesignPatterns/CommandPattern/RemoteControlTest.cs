using CommandPattern.Classes;
using System;

namespace CommandPattern
{
    class RemoteControlTest
    {
        static void Main(string[] args)
        {
            SimpleRemoteControl control = new SimpleRemoteControl();
            Light light = new Light();

            LightOnCommand lightOnCommand = new LightOnCommand(light);
            control.setCommand(lightOnCommand);
            control.buttonWasPressed();

            LightOffCommand lightOffCommand = new LightOffCommand(light);
            control.setCommand(lightOffCommand);
            control.buttonWasPressed();

            Console.ReadLine();
        }
    }
}
