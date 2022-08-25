using System;
namespace FactoryPatternExercise
{
    public class Poodle : IDog
    {
        public Poodle()
        {
        }
        public string Color { get; set; } = "white";
        public string EnergyLevel { get; set; } = "medium";
        public string Name { get; set; } = "Lenny";
        public string LoveLevel { get ; set ; } = "forever";

        public void Adopt()
        {
            Console.WriteLine($"You should get a {Color} Poodle with {EnergyLevel} energy. t's name will be {Name} & it will love you {LoveLevel}.");
        }
    }
}

