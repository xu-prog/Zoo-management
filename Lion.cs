using System;
namespace Task02
{
class Lion : Feline
{
    public Lion(string name, string diet, string location, double weight, int age, string colour, string species)
    : base(name, diet, location, weight, age, colour, species)
    {
    }

public override void MakeNoise()
{
    Console.WriteLine("the lion roarrrrs");
}
public override void Eat()
{
    Console.WriteLine("The lion eats meat everyday");
}
public override void Sleep()
{
    Console.WriteLine("the lion sleeps 8 hours everyday");
}
}
}
