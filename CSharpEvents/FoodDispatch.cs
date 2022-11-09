
using CSharpEvents.Models;

namespace CSharpEvents
{

    public class FoodDispatch
    {
        public event EventHandler<FoodEventArgs> FoodOrdered;

        public void OrderSomeFood(Food food)
        {
            Console.WriteLine($"(C# Events - Publisher) Envoi d'une commande de: {food.Name}");

            Thread.Sleep(10000);

            OnFoodOrdered(food);
        }

        protected virtual void OnFoodOrdered(Food food)
        {
            FoodOrdered.Invoke(this, new FoodEventArgs() { Food = food });
        }
    }
}


