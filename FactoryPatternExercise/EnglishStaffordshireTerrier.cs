using System;
namespace FactoryPatternExercise
{
    public class EnglishStaffordshireTerrier : IDog
    {
        public EnglishStaffordshireTerrier()
        {
        }

        public string EnergyLevel { get; set; } = "low";
        public string Color { get; set; } = "black";
        public string Name { get; set; } = "Harley";
        public string LoveLevel { get; set; } = "forever";

        public void Adopt()
        {
            Console.WriteLine($"You should get a {Color} English Staffordshire Terrier with {EnergyLevel} energy. It's name will be {Name} & it will love you {LoveLevel}.");
        }
    }
}

