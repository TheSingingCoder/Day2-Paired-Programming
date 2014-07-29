using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Day2PairedProgramming.Models
{
    public class IndexVM
    {
        public List<Pop> PopSongs = new List<Pop>();
        public List<RocknRoll> RockSongs = new List<RocknRoll>();
        public Jazz JazzSong1;
        public Classical ClassicalSong1;
        public Funk FunkSong1;
    }
}