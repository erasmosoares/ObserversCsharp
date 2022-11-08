
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

        public void Notify(string food)
        {
            foreach (var observer in _observers)
            {
                observer.Update(food);
            }
        }

        public void OrderSomeFood(string food)
        {
            Console.WriteLine($"Envoi d'une commande de: {food}");

            Thread.Sleep(5000);

            this.Notify(food);
        }
    }
}


