using System;
using System.Collections.Generic;
using System.Text;

namespace blockbusterLab
{
    internal class Movie
    {
        public string Title { get; set; }
        public Genre Category { get; set; }
        public int RunTime { get; set; }
        public List<string> Scenes { get; set; }

        public enum Genre
        {
            Drama,
            Comedy,
            Horror,
            Romance,
            Action
        }

        public Movie(string title, Genre category, int runTime, List<string> scenes)
        {
            Title = title;
            Category = category;
            RunTime = runTime;
            Scenes = scenes;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{Title}");
            Console.WriteLine($"{Category}");
            Console.WriteLine($"{RunTime}");
        }

        public void PrintScenes()
        {
            for (int i = 0; i < Scenes.Count; i++)
            {
                string m = Scenes[i];
                Console.WriteLine($"Scene ID <{i}> {m}");
            }
        }

        public virtual void Play()
        {
        }
    }
}