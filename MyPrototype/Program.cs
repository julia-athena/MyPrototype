using MyPrototype.PlantModel;
using System;

namespace MyPrototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var land = new Land();
            //создадим 2 куста крыжовника, 2 куста смородины, 2 яблони
            var gooseberryPrototype = new Bush() {
                Name = "Крыжовник", 
                WoodType = "Гладкий", 
                WoodColour = "Серый",
                WithThorns = true,
                Fruit = new Fruit()
                {
                    FruitType = "Ягода",
                    PlusToHealth = 5,
                },
            };
            var currantPrototype = new Bush()
            {
                Name = "Cмородина",
                WoodType = "Гладкий",
                WoodColour = "Коричневый",
                WithThorns = false,
                Fruit = new Fruit()
                {
                    FruitType = "Ягода",
                    PlusToHealth = 5,
                },
            };
            var appleTree = new Tree()
            {
                Name = "Яблоня",
                WoodType = "Гладкий",
                WoodColour = "Коричневый",
                Fruit = new Fruit()
                {
                    FruitType = "Яблоко",
                    PlusToHealth = 10,
                },
            };

            for (int i = 0; i < 3; i++)
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
