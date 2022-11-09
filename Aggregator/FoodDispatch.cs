using Aggregator.Models;
using CoreEvents.Interfaces;

namespace Aggregator
{
    class FoodDispatch
    {
        private readonly ICoreEvents _coreEvent;

        public FoodDispatch(ICoreEvents coreEvents)
        {
            _coreEvent = coreEvents;
        }

        public void OrderSomeFood(Food food)
        {
            Console.WriteLine($"(Aggregator - Publisher) Envoi d'une commande de: {food.Name}");

            Thread.Sleep(15000);

            _coreEvent.Publish(food);

        }

    }
}