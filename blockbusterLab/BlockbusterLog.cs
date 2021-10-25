using System;
using System.Collections.Generic;
using System.Text;

namespace blockbusterLab
{
    internal class BlockbusterLog
    {
        public List<Movie> MovieTime = new List<Movie>();

        public BlockbusterLog()
        {
            {
                MovieTime.Add(new Dvd("300", Movie.Genre.Action, 70, new List<string> { "attack on all", "save the day", "move the city", "end of time" }));
                MovieTime.Add(new Dvd("We Did it Again", Movie.Genre.Comedy, 90, new List<string> { "no we didn't", "how will we stop", "no where to go" }));
                MovieTime.Add(new Dvd("Stop me if you can", Movie.Genre.Comedy, 150, new List<string> { "running still", "no one is safe", "not going", "we stopped" }));
                MovieTime.Add(new Vhs("All day party", Movie.Genre.Horror, 75, new List<string> { "we started", "we never finished" }));
                MovieTime.Add(new Vhs("Actions now", Movie.Genre.Romance, 90, new List<string> { "love all now", "stilling loving", "where is the love" }));
                MovieTime.Add(new Vhs("Fast and fast", Movie.Genre.Drama, 110, new List<string> { "to fast to stop" }));
            }
        }

        public void Loop()
        {
            Console.WriteLine("\nDo you want to watch another movie? (Enter y/n)");
            while (true)
            {
                string again = Console.ReadLine();
                if (again == "y")
                {
                    Console.WriteLine();
                    MovieList();
                    movieSelection();
                    Loop();
                    break;
                }
                else if (again == "n")
                {
                    Console.WriteLine("Goodbye");
                    break;
                }
                else
                {
                    Console.WriteLine("Please only enter y/n:");
                }
            }
        }

        public void MovieList()
        {
            for (int i = 0; i < MovieTime.Count; i++)
            {
                Movie m = MovieTime[i];
                Console.WriteLine($"Movie ID <{i}> {m.Title}");
            }
        }

        public void movieSelection()
        {
            while (true)
            {
                try
                {
                    Console.Write("\nEnter a moive ID: ");
                    int movie = Convert.ToInt32(Console.ReadLine());
                    if (movie <= MovieTime.Count)
                    {
                        Movie m1 = MovieTime[movie];
                        Console.WriteLine($"\nWhich scene you do want to watch in \"{m1.Title}\"?\n");
                        m1.PrintScenes();
                        while (true)
                        {
                            try
                            {
                                Console.Write("\nEnter a Scene ID: ");
                                int selection = Convert.ToInt32(Console.ReadLine());
                                if (selection <= m1.Scenes.Count)
                                {
                                    Console.WriteLine($"\nEnjoy watching: {m1.Scenes[selection]}");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("\nOnly enter a ID listed above.");
                                    continue;
                                }
                            }
                            catch (FormatException e)
                            {
                                Console.WriteLine("Please only enter a number from the scene list");
                                continue;
                            }
                        }

                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nOnly enter a ID listed above.");
                        continue;
                    }
                }
                catch (FormatException e)

                {
                    Console.WriteLine("\nOnly enter a ID listed above.");
                    continue;
                }
            }
        }
    }
}