using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter6_Command
{
    public class MacroCommand : Command
    {
        Command[] Commands;

        public MacroCommand(Command[] commands)
        {
            Commands = commands;
        }
        public void Execute()
        {
            foreach(var command in Commands)
            {
                command.Execute();
            }
        }

        public void Undo()
        {
            foreach (var command in Commands)
            {
                command.Undo();
            }
        }
    }
}
