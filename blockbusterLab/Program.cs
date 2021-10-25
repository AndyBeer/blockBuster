using System;
using System.Collections.Generic;
using System.Text;

namespace blockbusterLab
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            BlockbusterLog data = new BlockbusterLog();
            Console.WriteLine("Welcome to BlockBuster!\n");
            Console.WriteLine("Which movie would you like to watch?\n");

            data.MovieList();
            data.movieSelection();
            data.Loop();
        }
    }
}