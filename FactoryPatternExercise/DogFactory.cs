using System;
namespace FactoryPatternExercise
{
    public static class DogFactory
    {
        //build method 
        public static IDog GetDog(string profession)
        {
            switch (profession)
            {
                case "construction worker":
                    return new GermanSheperd();
                case "programmer":
                    return new EnglishStaffordshireTerrier();
                case "nurse":
                    return new GoldenRetriever();
                case "doctor":
                    return new LabradorRetriever();
                case "engineer":
                    return new Poodle();
                default:
                    return new GoldenRetriever();
            }
        }
    }
}

