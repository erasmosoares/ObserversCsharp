using DesignPattern.Interfaces;
using DesignPattern.Models;
namespace DesignPattern
{

    public class FoodDispatch : IFoodDispatch
    {

        private List<IFoodObserver> _observers = new List<IFoodObserver>();

        public void Attach(IFoodObserver observer)
        {
            this._observers.Add(observer);
        }

        public void Detach(IFoodObserver observer)
        {
            this._observers.Remove(observer);
        }

        public void Notify(Food food)
        {
            foreach (var observer in _observers)
            {
                observer.Update(food);
            }
        }

        public void OrderSomeFood(Food food)
        {
            Console.WriteLine($"(DesignPattern - Publisher) Envoi d'une commande de: {food.Name}");

            Thread.Sleep(5000);

            this.Notify(food);
        }
    }
}


