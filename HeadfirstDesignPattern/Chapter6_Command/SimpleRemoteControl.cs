using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter6_Command
{
    public class SimpleRemoteControl
    {
        Command Slot;

        public SimpleRemoteControl()
        {

        }

        public void SetCommand(Command command)
        {
            Slot = command;
        }

        public void ButtonWasPressed()
        {
            Slot.Execute();
        }
    }
}
