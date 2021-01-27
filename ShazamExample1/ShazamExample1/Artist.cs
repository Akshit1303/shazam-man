using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShazamExample1
{
    class Artist
    {
        private string _Name;

        public string Name { get => _Name; set => _Name = value; }

        public Artist()
        {
            Console.WriteLine("Artist Created.");
        }
    }
}
