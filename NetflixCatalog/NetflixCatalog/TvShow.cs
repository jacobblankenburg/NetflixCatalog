using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog
{
    public class TvShow : Title
    {
        //public Episode TvEpisode;
        List<Episode> episodes;

        public new int Rating;
        private int Ratings;
        Random rand = new Random();

        public TvShow(string name, ProgramGenres genres)
        {
            this.Name = name;
            EpisodeRatings();
            GetAverageRating();
        }

        public void EpisodeRatings()
        {
            this.episodes = new List<Episode>() { new Episode(1, 60, "Episode 1", 3), new Episode(2, 60, "Episode 2", 5), new Episode(3, 60, "Episode 3", 4) };
        }
        public void GetAverageRating()
        {
            foreach( Episode episode in episodes)
            {
                Ratings += episode.Rating;
            }
            this.Rating = Ratings / episodes.Count;
        }
        public override string ToString()
        {
            return (Name + " has a rating of : " + Rating.ToString() + " has a genre of : " + programGenres.ToString());
        }
    }


}
//public void Arrow() { episodes = new List<Episode>() { new Episode(90, "1", 4), new Episode(90, "2", 4), new Episode(90, "3", 4)}; }
//        public void Futurama() { episodes = new List<Episode>() { new Episode(30, "1", 3), new Episode(30, "2", 4), new Episode(30, "3", 3) }; }
//        public void GameOfThrones() { episodes = new List<Episode>() { new Episode(45, "1", 5), new Episode(45, "2", 4), new Episode(45, "3", 5) }; }