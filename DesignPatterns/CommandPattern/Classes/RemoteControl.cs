﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes
{
    class RemoteControl
    {
        ICommand[] onCommands;
        ICommand[] offCommands;
        ICommand undoCommand;

        public RemoteControl()
        {
            onCommands = new ICommand[7];
            offCommands = new ICommand[7];

            ICommand noCommand = new NoCommand();
            for(int i=0; i<7; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }

            undoCommand = noCommand;
        }

        public void setCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }

        public void onButtonWasPressed(int slot)
        {
            if (onCommands[slot] != null)
            {
                onCommands[slot].execute();
                undoCommand = onCommands[slot];
            }
        }

        public void offButtonWasPressed(int slot)
        {
            if (offCommands[slot] != null)
            {
                offCommands[slot].execute();
                undoCommand = offCommands[slot];
            }
        }

        public void undoButtonWasPressed()
        {
            undoCommand.undo();
        }

        public string toString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("\n------ Remote Control ------\n");
            for(int i=0; i< onCommands.Length; i++)
            {
                stringBuilder.Append("[slot " + i + "]" + "\t" + onCommands[i].ToString() + "\t" + offCommands[i].ToString() + "\n");
            }

            return stringBuilder.ToString();
        }
    }
}
