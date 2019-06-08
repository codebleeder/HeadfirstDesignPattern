using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter6_Command
{
    public class CeilingFanMediumCommand : Command
    {
        CeilingFan CeilingFan;
        Speed PrevSpeed;

        public CeilingFanMediumCommand(CeilingFan ceilingFan)
        {
            CeilingFan = ceilingFan;
        }

        public void Execute()
        {
            PrevSpeed = CeilingFan.GetSpeed();
            CeilingFan.Medium();
        }

        public void Undo()
        {
            if (PrevSpeed == Speed.HIGH)
            {
                CeilingFan.High();
            }
            else if (PrevSpeed == Speed.MEDIUM)
            {
                CeilingFan.Medium();
            }
            else if (PrevSpeed == Speed.LOW)
            {
                CeilingFan.Low();
            }
            else if (PrevSpeed == Speed.OFF)
            {
                CeilingFan.Off();
            }
        }
    }
}
