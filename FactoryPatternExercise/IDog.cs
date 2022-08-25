using System;
namespace FactoryPatternExercise
{
    public interface IDog
    {
        public string EnergyLevel { get; set; }

        public string Color { get; set; }

        public string Name { get; set; }

        public string LoveLevel { get; set; } 

        public void Adopt();
    }
}

