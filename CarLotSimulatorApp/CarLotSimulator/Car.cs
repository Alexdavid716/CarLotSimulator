using System;

namespace CollectionsMasterConsoleUI
{
    public class Car
    {
        // Properties
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        // Methods
        public void MakeEngineNoise(string engineNoise)
        {
            Console.WriteLine($"The {Make} {Model} makes the engine noise: {engineNoise}");
        }

        public void MakeHonkNoise(string honkNoise)
        {
            Console.WriteLine($"The {Make} {Model} makes the honk noise: {honkNoise}");
        }
    }
}