﻿namespace CommandPattern.Classes
{
    public interface ICommand
    {
        void execute();
        void undo();
    }
}
