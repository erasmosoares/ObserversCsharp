using CoreEvents.Interfaces;

namespace Aggregator
{
    class Cuisine
    {
        private readonly ICoreEvents _coreEvent;

        public Cuisine(ICoreEvents coreEvents)
        {
            _coreEvent = coreEvents;

            _coreEvent.Subscribe<Aggregator.Models.Food>(c => { OnFoodOrdered(c); });
        }
        public void OnFoodOrdered(Aggregator.Models.Food args)
        {
            Console.WriteLine($"(Aggregator - Subscriber) La cuisine vient de recevoir une commande: : {args.Name}");
        }
    }
}