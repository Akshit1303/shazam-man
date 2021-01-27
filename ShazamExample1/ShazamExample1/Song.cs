using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShazamExample1
{
    class Song
    {
        private string _SongTitle;
        private DateTime _ReleaseDate;
        private Artist _Artist;
        private float _Duration;

        public string SongTitle { get => _SongTitle; set => _SongTitle = value; }
        
        public float Duration { get => _Duration; set => _Duration = value; }
        internal Artist Artist { get => _Artist; set => _Artist = value; }

        public Song()
        {
            Console.WriteLine("Song Created.");
        }
    }
}
