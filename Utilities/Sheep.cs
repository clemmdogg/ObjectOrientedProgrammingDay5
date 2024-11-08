using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingDay5.Utilities;

internal class Sheep : Animal
{
    public Sheep(string name) : base(name) { }
    public override void MakeSound()
    {
        Console.WriteLine("Baaaah");

        string binDirectory = AppDomain.CurrentDomain.BaseDirectory;

        string projectRootDirectory = Path.GetFullPath(Path.Combine(binDirectory, @"..\..\..\"));

        string wavFilePath = Path.Combine(projectRootDirectory, "Sounds", "sheep.wav");

        SoundPlayer player = new SoundPlayer(wavFilePath);
        player.PlaySync();
    }
}
