using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Class_methods
{
    internal class Playlist
    {
        private List<string> playlist = new List<string>();

        public void AddtoPlaylist(string song)
        {
            playlist.Add(song);
        }

        public void RemoveFromPlaylist(string song)
        {
            playlist.Remove(song);
        }

        public void PrintPlaylist()
        {
            foreach (var song in playlist)
            {
                Console.WriteLine(song);

            }
        }

    }
}
