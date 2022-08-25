//give the user a dog breed based on their profession

using FactoryPatternExercise;

Console.WriteLine($"Type in your profession in order to see what dog breed you should own!");

var userInput = Console.ReadLine();

IDog dog = DogFactory.GetDog(userInput);
dog.Adopt();
