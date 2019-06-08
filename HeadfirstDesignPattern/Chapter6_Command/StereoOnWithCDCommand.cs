using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter6_Command
{
    public class StereoOnWithCDCommand : Command
    {
        Stereo Stereo;

        public StereoOnWithCDCommand(Stereo stereo)
        {
            Stereo = stereo;
        }
        public void Execute()
        {
            Stereo.On();
            Stereo.SetCD();
            Stereo.SetVolume();
        }

        public void Undo()
        {
            Stereo.Off();
        }
    }
}
