using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.Chapter6_Command
{
    public class RemoteControl
    {
        Command[] OnCommands;
        Command[] OffCommands;
        Command UndoCommand;
        public RemoteControl()
        {
            OnCommands = new Command[7];
            OffCommands = new Command[7];

            var noCommand = new NoCommand();
            for(var i=0; i<7; i++)
            {
                OnCommands[i] = noCommand;
                OffCommands[i] = noCommand;
            }
            UndoCommand = noCommand;
        }

        public void SetCommand(int slot, Command onCommand, Command offCommand)
        {
            OnCommands[slot] = onCommand;
            OffCommands[slot] = offCommand;
        }

        public void OnButtonPushed(int slot)
        {
            if (OnCommands[slot] != null)
            {
                OnCommands[slot].Execute();
                UndoCommand = OnCommands[slot];
            }            
        }

        public void OffButtonPushed(int slot)
        {
            if (OffCommands[slot] != null)
            {
                OffCommands[slot].Execute();
                UndoCommand = OffCommands[slot];
            }                
        }

        public void UndoButtonPushed()
        {
            UndoCommand.Undo();
        }
        public override string ToString()
        {
            var strBuilder = new StringBuilder();
            strBuilder.Append("\n-------Remote control-----\n");
            for(var i=0; i< OnCommands.Length; i++)
            {
                strBuilder.Append($"slot {i} {OnCommands[i].GetType().FullName} {OffCommands[i].GetType().FullName} \n");
            }
            return strBuilder.ToString();
        }

    }
}
