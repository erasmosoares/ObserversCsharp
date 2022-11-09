using CoreEvents.Interfaces;

namespace Aggregator.Models
{
    public class Food : ICoreMessage
    {
        public string Name { get; set; }
    }

}