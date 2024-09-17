using System;
namespace Task02
{
class Wolf : Animal
{
    public Wolf(string name, string diet, string location, double weight, int age, string colour)
    : base(name, diet, location, weight, age, colour)
    {
    }
public override void MakeNoise()
{
    Console.WriteLine("the wolf howllls");
}
public override void Eat()
{
    Console.WriteLine("The wolf eats meat everyday");
}
}
}
