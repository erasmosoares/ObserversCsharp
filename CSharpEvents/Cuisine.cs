using CSharpEvents.Models;

namespace CSharpEvents
{
    class Cuisine
    {
        public void OnFoodOrdered(object source, FoodEventArgs args)
        {
            Console.WriteLine($"(C# Events - Subscriber) La cuisine vient de recevoir une commande: {args.Food.Name}");
        }
    }
}