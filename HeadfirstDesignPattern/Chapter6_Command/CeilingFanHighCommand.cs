using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter6_Command
{
    public class CeilingFanHighCommand : Command
    {
        CeilingFan CeilingFan;
        Speed PrevSpeed;

        public CeilingFanHighCommand(CeilingFan ceilingFan)
        {
            CeilingFan = ceilingFan;
        }

        public void Execute()
        {
            PrevSpeed = CeilingFan.GetSpeed();
            CeilingFan.High();
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
