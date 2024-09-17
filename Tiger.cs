using System;
namespace Task02
{
class Tiger : Feline
{
    private string colourStripes;

    public Tiger(string name, string diet, string location, double weight, int age, string colour, string species, string colourStripes)
    : base(name, diet, location, weight, age, colour, species)
    {
    this.colourStripes = colourStripes; 
    }

public override void MakeNoise()
{
    Console.WriteLine("the tiger roarrr");
}

public override void Eat()
{
    Console.WriteLine("The tiger eats meat everyday");
}

public override void Sleep()
{
    Console.WriteLine("the tiger sleep 7 hours everyday");
}
}
}
