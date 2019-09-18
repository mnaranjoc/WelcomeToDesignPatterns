using CommandPattern.Classes;
using System;

namespace CommandPattern
{
    class RemoteControlTest
    {
        static void Main(string[] args)
        {
            //RemoteControlTest.SimpleRemoteController();
            RemoteControlTest.RemoteController();
        }

        public static void RemoteController()
        {
            RemoteControl control = new RemoteControl();

            Light livingRoomLight = new Light("Living Room");
            Light kitchenLight = new Light("Kitchen Light");
            Stereo livingRoomStereo = new Stereo("Living Room");
            CeilingFan livingRoomCeilingFan = new CeilingFan("Living Room");

            LightOnCommand livingRoomLightOnCommand = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOffCommand = new LightOffCommand(livingRoomLight);
            LightOnCommand kitchenLightLightOnCommand = new LightOnCommand(kitchenLight);
            LightOffCommand kitchenLightLightOffCommand = new LightOffCommand(kitchenLight);
            StereoOnWithCDCommand livingRoomStereoOnWithCDCommand = new StereoOnWithCDCommand(livingRoomStereo);
            StereoOffCommand livingRoomStereoOffCommand = new StereoOffCommand(livingRoomStereo);
            CeilingFanHighCommand livingRoomCeilingFanHighCommand = new CeilingFanHighCommand(livingRoomCeilingFan);
            CeilingFanMediumCommand livingRoomCeilingFanMediumCommand = new CeilingFanMediumCommand(livingRoomCeilingFan);
            CeilingFanOffCommand livingRoomCeilingFanOffCommand = new CeilingFanOffCommand(livingRoomCeilingFan);

            /*control.setCommand(0, livingRoomLightOnCommand, livingRoomLightOffCommand);
            control.setCommand(1, kitchenLightLightOnCommand, kitchenLightLightOffCommand);
            control.setCommand(2, livingRoomStereoOnWithCDCommand, livingRoomStereoOffCommand);*/
            control.setCommand(0, livingRoomCeilingFanHighCommand, livingRoomCeilingFanOffCommand);
            control.setCommand(1, livingRoomCeilingFanMediumCommand, livingRoomCeilingFanOffCommand);

            Console.WriteLine(control.toString());

            /*control.onButtonWasPressed(0);
            control.offButtonWasPressed(0);
            control.undoButtonWasPressed();
            control.onButtonWasPressed(1);
            control.offButtonWasPressed(1);
            control.undoButtonWasPressed();
            control.onButtonWasPressed(2);
            control.offButtonWasPressed(2);
            control.undoButtonWasPressed();*/
            control.onButtonWasPressed(0);
            control.offButtonWasPressed(0);
            control.undoButtonWasPressed();
            control.onButtonWasPressed(1);
            control.undoButtonWasPressed();

            Console.ReadLine();
        }

        public static void SimpleRemoteController()
        {
            SimpleRemoteControl control = new SimpleRemoteControl();
            Light light = new Light("Simple light");

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
