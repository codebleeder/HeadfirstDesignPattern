using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter6_Command
{
    public class LightOffCommand: Command
    {
        Light Light;
        public LightOffCommand(Light light)
        {
            Light = light;
        }

        public void Execute()
        {
            Light.Off();
        }

        public void Undo()
        {
            Light.On();
        }
    }
}
