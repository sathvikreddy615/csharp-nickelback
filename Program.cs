using System;
using System.Collections.Generic;

namespace nickelback
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string artist, string song)> goodSongs = new List<(string artist, string song)>();
            HashSet<(string artist, string song)> allSongs = new HashSet<(string artist, string song)>() {
                {("Red Hot Chili Peppers", "Dani California")},
                {("Nirvana", "Come As You Are")},
                {("Metallica", "Enter Sandman")},
                {("Nickleback", "Burn It To The Ground")},
                {("Nickleback", "Feelin' Way Too Damn Good")},
                {("Nickleback", "Rockstar")},
                {("Alt-J", "Every Other Freckle")}
            };

            foreach ((string artist, string song) song in allSongs)
            {
                if (song.artist != "Nickleback") {
                    goodSongs.Add((song.artist, song.song));
                }
            }

            foreach (var song in goodSongs)
            {
                Console.WriteLine($"A good artist such as {song.artist} sing good songs like {song.song}");
            }
        }
    }
}
