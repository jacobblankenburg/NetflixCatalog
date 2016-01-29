using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog
{
    public class TvShow : Title
    {
        public Episode TvEpisode;
        List<Episode> episodes;

        public void Arrow() { episodes = new List<Episode>() { new Episode(90, "1", 4), new Episode(90, "2", 4), new Episode(90, "3", 4)}; }
        public void Futurama() { episodes = new List<Episode>() { new Episode(30, "1", 3), new Episode(30, "2", 4), new Episode(30, "3", 3) }; }
        public void GameOfThrones() { episodes = new List<Episode>() { new Episode(45, "1", 5), new Episode(45, "2", 4), new Episode(45, "3", 5) }; }
    }


}
