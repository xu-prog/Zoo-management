using System;
namespace Task02
{
    class Penguin : Bird
    {
    public Penguin(string name, string diet, string location, double weight, int age, string colour, string species, double wingSpan)
    : base(name, diet, location, weight, age, colour, species, wingSpan)
    {
    }
    public override void Fly()
    {
        Console.WriteLine("A penguin cannot fly");
    }
    }
}