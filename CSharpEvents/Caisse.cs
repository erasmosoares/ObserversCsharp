using CSharpEvents.Models;

namespace CSharpEvents
{
    class Caisse
    {
        public void OnFoodOrdered(object source, FoodEventArgs args)
        {
            Console.WriteLine($"(C# Events - Subscriber) La caisse vient de recevoir une commande: : {args.Food.Name}");
        }
    }
}