namespace DesignPattern
{
    class Cuisine : IFoodObserver
    {
        public void Update(string food)
        {
            Console.WriteLine($"La cuisine vient de recevoir une commande: {food}");
        }
    }
}