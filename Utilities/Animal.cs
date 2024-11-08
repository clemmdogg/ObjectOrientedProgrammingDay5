using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingDay5.Utilities;

internal abstract class Animal
{
    public string Name { get; set; }
    public Animal(string name)
    {
        Name = name;
    }
    public abstract void MakeSound();
}
