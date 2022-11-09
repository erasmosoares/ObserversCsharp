using DesignPattern.Interfaces;
using DesignPattern.Models;
namespace DesignPattern
{
    class Caisse : IFoodObserver
    {
        public void Update(Food food)
        {
            Console.WriteLine($"(DesignPattern - Subscriber) La caisse vient de recevoir une commande: : {food.Name}");
        }
    }
}