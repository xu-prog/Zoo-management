using System;
namespace Task02
{
class Animal
{
    private string name;
    private string diet;
    private string location;
    private double weight;
    private int age;
    private string colour;

    public Animal(string name, string diet, string location, double weight, int age, string colour)
    {
        this.name = name;
        this.diet =  diet;
        this.location = location;
        this.weight = weight;
        this.age = age;
        this.colour = colour;
    }
    public virtual void Eat()
    {
        Console.WriteLine("the animal eats... yuumy");
    }
    public virtual void Sleep()
    {
        Console.WriteLine("the animal sleeps...zzz");
    }
    public virtual void MakeNoise()
    {
        Console.WriteLine("An animal makes a noise");
    }
    public virtual void GoToilet()//perosnal method
    {
        Console.WriteLine("An animal goes toilet");
    }
}
}

