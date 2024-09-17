using System;
namespace Task02{

class ZooPark{
static void Main(string[] args)
{
    Tiger tonyTiger = new Tiger("Tony the Tiger", "Meat", "Cat Land", 110, 6, "Orange and White", "Siberian", "White");
    Wolf williamWolf = new Wolf("William the Wolf", "Meat", "Dog Village", 50.6, 9, "Grey");
    Eagle edgarEagle = new Eagle("Edgar the Eagle", "Fish", "Bird Mania", 20, 15, "Black", "Harpy", 98.5);
    Lion leoLion = new Lion("Leo the Lion", "Meat", "Cat Land", 111, 7, "Brown", "Panthera");
    Penguin peterPenguin = new Penguin("Peter the Penguin", "Fish", "Bird Mania", 20, 4, "Black and White", "Emperor penguin", 80);

    edgarEagle.LayEgg();
    edgarEagle.Fly();
    edgarEagle.MakeNoise();
    edgarEagle.Eat();
    edgarEagle.GoToilet();
    edgarEagle.Sleep();

    leoLion.MakeNoise();
    leoLion.Eat();
    leoLion.GoToilet();
    leoLion.Sleep();

    peterPenguin.Fly();
    peterPenguin.MakeNoise();
    peterPenguin.Eat();
    peterPenguin.GoToilet();
    peterPenguin.Sleep();

    tonyTiger.MakeNoise();
    tonyTiger.Eat();
    tonyTiger.GoToilet();
    tonyTiger.Sleep();

    williamWolf.MakeNoise();
    williamWolf.Eat();
    williamWolf.Sleep();
}
}
}
