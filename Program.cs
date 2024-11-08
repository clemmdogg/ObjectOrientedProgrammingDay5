// See https://aka.ms/new-console-template for more information
using ObjectOrientedProgrammingDay5.Utilities;
using System.Reflection.Metadata;

Console.WriteLine(AppDomain.CurrentDomain.BaseDirectory);

Console.ReadLine();

Console.WriteLine("Hello, World!");
PolymorfiExamble pe = new PolymorfiExamble();
Console.WriteLine(pe.GetName());

//Console.ReadLine();

Animal dog = AnimalFactory.CreateAnimal(enmAnimal.Dog, "Bob");

Console.WriteLine($"Hundens navn er {dog.Name}");
dog.MakeSound();

//Console.ReadLine();

Animal cat = AnimalFactory.CreateAnimal(enmAnimal.Cat);

Console.WriteLine($"Kattens navn er {cat.Name}");
cat.MakeSound();

//Console.ReadLine();

Animal sheep = AnimalFactory.CreateAnimal(enmAnimal.Sheep);

Console.WriteLine($"Fårets navn er {sheep.Name}");
sheep.MakeSound();