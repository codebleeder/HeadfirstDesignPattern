using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter6_Command
{
    public class Chapter6Tests
    {
        public static void Test1()
        {
            var remote = new SimpleRemoteControl();
            var light = new Light("");
            var lightOn = new LightOnCommand(light);
            remote.SetCommand(lightOn);
            remote.ButtonWasPressed();

            var garageDoor = new GarageDoor();
            var garageDoorOpen = new GarageDoorOpenCommand(garageDoor);
            remote.SetCommand(garageDoorOpen);
            remote.ButtonWasPressed();
        }

        public static void Test2()
        {
            var remote = new RemoteControl();
            var livingRoomLight = new Light("Living room");
            var kitchenLight = new Light("Kitchen");
            var stereo = new Stereo("Living room");

            var livingRoomLightOnCommand = new LightOnCommand(livingRoomLight);
            var livingRoomLightOffCommand = new LightOffCommand(livingRoomLight);
            var kitchenLightOnCommand = new LightOnCommand(kitchenLight);
            var kitchenLightOffCommand = new LightOffCommand(kitchenLight);

            var stereoOnWithCDCommand = new StereoOnWithCDCommand(stereo);
            var stereoOffCommand = new StereoOffCommand(stereo);

            remote.SetCommand(0, livingRoomLightOnCommand, livingRoomLightOffCommand);
            remote.SetCommand(1, kitchenLightOnCommand, kitchenLightOffCommand);
            remote.SetCommand(2, stereoOnWithCDCommand, stereoOffCommand);

            Console.WriteLine(remote.ToString());

            remote.OnButtonPushed(0);
            remote.OffButtonPushed(0);
            remote.OnButtonPushed(1);
            remote.OffButtonPushed(1);
            remote.OnButtonPushed(2);
            remote.OffButtonPushed(2);
            remote.OffButtonPushed(3);
        }

        public static void Test3Undo()
        {
            var remote = new RemoteControl();
            var livingRoomLight = new Light("Living room");
            var livingRoomLightOnCmd = new LightOnCommand(livingRoomLight);
            var livingRoomLightOffCmd = new LightOffCommand(livingRoomLight);
            remote.SetCommand(0, livingRoomLightOnCmd, livingRoomLightOffCmd);

            remote.OnButtonPushed(0);
            remote.OffButtonPushed(0);
            Console.WriteLine(remote.ToString());
            remote.UndoButtonPushed();

            remote.OffButtonPushed(0);
            remote.OnButtonPushed(0);
            Console.WriteLine(remote.ToString());
            remote.UndoButtonPushed();
        }

        public static void Test4CeilingFan()
        {
            var remote = new RemoteControl();
            var ceilingFan = new CeilingFan("Living room");
            var ceilingFanHighCmd = new CeilingFanHighCommand(ceilingFan);
            var ceilingFanMediumCmd = new CeilingFanMediumCommand(ceilingFan);
            var ceilingFanOffCmd = new CeilingFanOffCommand(ceilingFan);
            remote.SetCommand(0, ceilingFanMediumCmd, ceilingFanOffCmd);
            remote.SetCommand(1, ceilingFanHighCmd, ceilingFanOffCmd);

            Console.WriteLine(remote.ToString());
            remote.OnButtonPushed(0);
            remote.OffButtonPushed(0);
            remote.UndoButtonPushed();

            remote.OnButtonPushed(1);
            remote.UndoButtonPushed();
        }

        public static void Test5MacroCommand()
        {
            var livingRoomLight = new Light("living room");
            var stereo = new Stereo("living room");
            var fan = new CeilingFan("living room");

            var lightOnCmd = new LightOnCommand(livingRoomLight);
            var steroOnCmd = new StereoOnWithCDCommand(stereo);
            var fanHighCmd = new CeilingFanHighCommand(fan);

            var lightOffCmd = new LightOffCommand(livingRoomLight);
            var stereoOffCmd = new StereoOffCommand(stereo);
            var fanOffCmd = new CeilingFanOffCommand(fan);

            var partyOnCmd = new MacroCommand(new Command[] { lightOnCmd, steroOnCmd, fanHighCmd });
            var partyOffCmd = new MacroCommand(new Command[] { lightOffCmd, stereoOffCmd, fanOffCmd });

            var remote = new RemoteControl();
            remote.SetCommand(0, partyOnCmd, partyOffCmd);

            Console.WriteLine(remote.ToString());
            remote.OnButtonPushed(0);
            remote.OffButtonPushed(0);
        }
    }
}
