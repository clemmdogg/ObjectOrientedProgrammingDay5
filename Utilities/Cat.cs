using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace ObjectOrientedProgrammingDay5.Utilities;

internal class Cat : Animal
{
    public Cat(string name) : base(name) { }
    public override void MakeSound()
    {
        Console.WriteLine("Meauw");

        string binDirectory = AppDomain.CurrentDomain.BaseDirectory;

        string projectRootDirectory = Path.GetFullPath(Path.Combine(binDirectory, @"..\..\..\"));

        string wavFilePath = Path.Combine(projectRootDirectory, "Sounds", "cat.wav");

        SoundPlayer player = new SoundPlayer(wavFilePath);
        player.PlaySync();
    }
}
