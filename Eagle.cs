using System;
namespace Task02
{
class Eagle : Bird
{
    public Eagle(string name, string diet, string location, double weight, int age, string colour, string species, double wingSpan)
        : base(name, diet, location, weight, age, colour, species, wingSpan)
{}
public void LayEgg()
{
    Console.WriteLine("eagle lays an egg");
}
public override void Fly()
{
    Console.WriteLine("the eagle spreads his wings and spars through sky, flying high!");
}
public override void MakeNoise()
{
    Console.WriteLine("howlllllllllll");
}
public override void Eat()
{
    Console.WriteLine("I can eat 1lb of fish");
}
 public override void GoToilet()
{
    Console.WriteLine("Eagle goes toilet many times a day");
}
    }
}
