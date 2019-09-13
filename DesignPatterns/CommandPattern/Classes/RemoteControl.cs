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
        }

        public void setCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }

        public void onButtonWasPressed(int slot)
        {
            onCommands[slot].execute();
        }

        public void offButtonWasPressed(int slot)
        {
            offCommands[slot].execute();
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
