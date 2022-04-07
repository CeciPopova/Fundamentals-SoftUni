using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Songs
{
    
    internal class Program
    {
        internal class Songs
        {
            public string TypeList { get; set; }
            public string Name { get; set; }
            public string Time { get; set; }

        }
        static void Main(string[] args)
        {
           int numberOfSongs= int.Parse(Console.ReadLine());

            List<Songs> songs = new List<Songs>();
            for (int i = 1; i <= numberOfSongs; i++)
            {
                List<string> dataSongs = Console.ReadLine().Split("_").ToList();

                string type=dataSongs[0];
                string name=dataSongs[1];   
                string time=dataSongs[2];   

                Songs song = new Songs();
                song.Name = name;   
                song.Time = time;   
                song.TypeList = type;

                songs.Add(song);    
            }
            string command=Console.ReadLine();
            if (command=="all")
            {
                foreach (Songs song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Songs song in songs)
                {
                    if (song.TypeList==command)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }
}
