using System;
using System.Collections.Generic;
using System.Text;

namespace blockbusterLab
{
    internal class Vhs : Movie
    {
        public int CurrentTime { get; set; } = 0;

        public Vhs(string title, Genre category, int runTime, List<string> scenes) : base(title, category, runTime, scenes)

        {
        }

        public override void Play()
        {
            if (CurrentTime < Scenes.Count)
            {
                string scene = Scenes[CurrentTime];
                CurrentTime++;
                Console.WriteLine(scene);
            }
            else
            {
                Rewind();
            }
        }

        public int Rewind()
        {
            int CurrentTime = 0;
            return CurrentTime;
        }
    }
}