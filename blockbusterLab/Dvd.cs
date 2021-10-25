using System;
using System.Collections.Generic;
using System.Text;

namespace blockbusterLab
{
    internal class Dvd : Movie

    {
        public Dvd(string title, Genre category, int runTime, List<string> scenes) : base(title, category, runTime, scenes)

        {
        }

        public override void Play()
        {
            PrintScenes();
            Console.WriteLine("Select a scene from below you would like to play:");
            int playScene = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Scenes[playScene]);
        }
    }
}