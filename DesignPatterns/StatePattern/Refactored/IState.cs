namespace StatePattern.Refactored
{
    public interface IState
    {
        void insertQuarter();
        void ejectQuarter();
        void turnCrank();
        void dispense();
    }
}
