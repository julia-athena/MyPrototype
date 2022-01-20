using System;

namespace MyPrototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var land = new Land();
            //создадим 3 куста крыжовника и 3 куста смородины
            var gooseberryPrototype = new Bush("Крыжовник", "Гладкий", "Серый", true);
            var currantPrototype = new Bush("Черная смородина", "Гладкий", "Коричневый", false);
            for (int i = 0; i < 3; i++)
            {
                var name = gooseberryPrototype.Name + $"-{i}";
                land.AddPlant(name, gooseberryPrototype);
                name = currantPrototype.Name + $"-{i}";
                land.AddPlant(name, currantPrototype);
            }
        }
    }
}
