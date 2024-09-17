using System;
namespace Task02{
    class Bird : Animal
    {
    private string species;
    private double wingspan;

    public Bird(string name, string diet, string location, double weight, int age, string colour, string species, double wingspan)
    : base(name, diet, location, weight, age, colour)
    {
        this.species = species;
        this.wingspan = wingspan;
    }

    public virtual void Fly()
    {
        Console.WriteLine("the bird can fly");
    }
    public override void MakeNoise()
    {
        Console.WriteLine("The animal makes noise");
    }
    }
}