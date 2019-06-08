using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter6_Command
{
    public interface Command
    {
        void Execute();
        void Undo();
    }
}
