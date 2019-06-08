using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter6_Command
{
    public class GarageDoorOpenCommand : Command
    {
        GarageDoor GarageDoor;

        public GarageDoorOpenCommand(GarageDoor garageDoor)
        {
            GarageDoor = garageDoor;
        }
        public void Execute()
        {
            GarageDoor.Open();
        }

        public void Undo()
        {

        }
    }
}
