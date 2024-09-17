using System;
namespace Task02{
    class Feline : Animal
    {
    private string species;

    public Feline(string name, string diet, string location, double weight, int age, string colour, string species)
    : base(name, diet, location, weight, age, colour)
    {
        this.species = species;
    }

    public override void Sleep()
    {
        Console.WriteLine("the animal sleeps everyday");
    }
    }
}
