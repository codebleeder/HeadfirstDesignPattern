using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter6_Command
{
    public class LightOnCommand : Command
    {
        Light Light;

        public LightOnCommand(Light light)
        {
            Light = light;
        }
        public void Execute()
        {
            Light.On();
        }

        public void Undo()
        {
            Light.Off();
        }
    }
}
