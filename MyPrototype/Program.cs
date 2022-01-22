using MyPrototype.PlantModel;
using System;

namespace MyPrototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var land = new Land();
            var gooseberryPrototype = new Bush() {
                Name = "Крыжовник",
                Wood = new Wood()
                {
                    WithThorns = true,
                    WoodColour = "Cерый",
                    WoodTexture = "Гладкий",      
                },
                Fruit = new Fruit()
                {
                    FruitType = "Ягода",
                    PlusToHealth = 5,
                },
            };
            var currantPrototype = new Bush()
            {
                Name = "Cмородина",
                Wood = new Wood()
                {
                    WithThorns = false,
                    WoodColour = "Коричневый",
                    WoodTexture = "Гладкий",
                },
                Fruit = new Fruit()
                {
                    FruitType = "Ягода",
                    PlusToHealth = 5,
                },
            };
            var appleTree = new Tree()
            {
                Name = "Яблоня",
                Wood = new Wood()
                {
                    WithThorns = false,
                    WoodColour = "Коричневый",
                    WoodTexture = "Гладкий",
                },
                Fruit = new Fruit()
                {
                    FruitType = "Яблоко",
                    PlusToHealth = 10,
                },
            };

            for (int i = 0; i < 2; i++)
            {
                var name = gooseberryPrototype.Name + $"-{i}";
                land.AddPlantByPrototype(name, gooseberryPrototype);
                name = currantPrototype.Name + $"-{i}";
                land.AddPlantByPrototype(name, currantPrototype);
                name = appleTree.Name + $"-{i}";
                land.AddPlantByPrototype(name, appleTree);
            }
        }
    }
}
