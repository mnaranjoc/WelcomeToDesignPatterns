namespace CommandPattern.Classes
{
    class LightOnCommand : ICommand
    {
        Light light;

        public LightOnCommand(Light _light)
        {
            light = _light;
        }

        public void execute()
        {
            light.on();
        }
    }
}
