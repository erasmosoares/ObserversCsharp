using CoreEvents.Interfaces;

namespace Aggregator
{
    class Caisse
    {
        private readonly ICoreEvents _coreEvent;

        public Caisse(ICoreEvents coreEvents)
        {
            _coreEvent = coreEvents;

            _coreEvent.Subscribe<Aggregator.Models.Food>(c => { OnFoodOrdered(c); });
        }
        public void OnFoodOrdered(Aggregator.Models.Food args)
        {
            Console.WriteLine($"(Aggregator - Subscriber) La caisse vient de recevoir une commande: : {args.Name}");
        }
    }
}