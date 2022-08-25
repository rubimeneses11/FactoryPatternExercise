using System;
namespace FactoryPatternExercise
{
    public class GoldenRetriever : IDog
    {
        public GoldenRetriever()
        {
        }
        public string Color { get; set; } = "yellow";
        public string EnergyLevel { get; set; } = "medium";
        public string Name { get; set; } = "Finn";
        public string LoveLevel { get; set; } = "forever";

        public void Adopt()
        {
            Console.WriteLine($"You should get a {Color} Golden Retriever with {EnergyLevel} energy. It's name will be {Name} & it will love you {LoveLevel}.");
        }
    }
}
