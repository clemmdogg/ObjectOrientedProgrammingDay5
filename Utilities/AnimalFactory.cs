using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ObjectOrientedProgrammingDay5.Utilities;

namespace ObjectOrientedProgrammingDay5.Utilities;

internal class AnimalFactory
{
    public static Animal CreateAnimal(enmAnimal animalType, string name)
    {
        switch (animalType)
        {
            case enmAnimal.Cat:
                return new Cat(name);
            case enmAnimal.Dog:
                return new Dog(name);
            case enmAnimal.Sheep:
                return new Sheep(name);
            default:
                return new Sheep(name);
        }
    }
    public static Animal CreateAnimal(enmAnimal animalType)
    {
        switch (animalType)
        {
            case enmAnimal.Cat:
                return new Cat("Tina");
            case enmAnimal.Dog:
                return new Dog("Anne");
            case enmAnimal.Sheep:
                return new Sheep("Susanne");
            default:
                return new Sheep("Susanne");
        }
    }
}
