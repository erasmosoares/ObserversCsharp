namespace DesignPattern
{
    class Caisse : IFoodObserver
    {
        public void Update(string food)
        {
            Console.WriteLine($"La caisse vient de recevoir une commande: : {food}");
        }
    }
}