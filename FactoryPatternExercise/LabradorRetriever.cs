using System;
namespace FactoryPatternExercise
{
    public class LabradorRetriever : IDog
    {
        public LabradorRetriever()
        {
        }
        public string Color { get; set; } = "yellow";
        public string EnergyLevel { get ; set ; } = "high";
        public string Name { get; set; } = "Buddy";
        public string LoveLevel { get ; set ; } = "forever";

        public void Adopt()
        {
            Console.WriteLine($"You should get a {Color} Labrador Retriever with {EnergyLevel} energy. It's name will be {Name} & it will love you {LoveLevel}.");
        }
    }
}

