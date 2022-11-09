using DesignPattern.Interfaces;
using DesignPattern.Models;
namespace DesignPattern
{
    class Cuisine : IFoodObserver
    {
        public void Update(Food food)
        {
            Console.WriteLine($"(DesignPattern - Subscriber) La cuisine vient de recevoir une commande: {food.Name}");
        }
    }
}