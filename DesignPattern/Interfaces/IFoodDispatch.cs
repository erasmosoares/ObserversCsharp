using DesignPattern.Models;

namespace DesignPattern.Interfaces
{
    public interface IFoodDispatch
    {
        void Attach(IFoodObserver observer);

        void Detach(IFoodObserver observer);

        void Notify(Food food);
    }
}
