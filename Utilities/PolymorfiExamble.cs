using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingDay5.Utilities;

internal class PolymorfiExamble
{
    public string FirstName { get; set; }
    public int Age { get; set; }
    public string GetName()
    {
        return "Niels Olesen";
    }
    public string GetName(string lastName)
    {
        return $"Niels {lastName}";
    }
    public void GetName(string firstName, int age)
    {
        FirstName = firstName;
        Age = age;
    }
}
