using System;
namespace FactoryPatternExercise
{
    public class GermanSheperd : IDog
    {
        public GermanSheperd()
        {
        }

        public string Color { get; set; } = "tan";
        public string EnergyLevel { get; set; } = "high";
        public string Name { get; set; } = "Scout";
        public string LoveLevel { get ; set ; } = "forever";

        public void Adopt()
        {
            Console.WriteLine($"You should get a {Color} German Sheperd with {EnergyLevel} energy. It's name will be {Name} & it will love you {LoveLevel}.");
        }
    }
}

