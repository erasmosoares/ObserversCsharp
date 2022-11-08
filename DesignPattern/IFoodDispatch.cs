namespace DesignPattern
{
    public interface IFoodDispatch
    {
        void Attach(IFoodObserver observer);

        void Detach(IFoodObserver observer);

        void Notify(string food);
    }
}
