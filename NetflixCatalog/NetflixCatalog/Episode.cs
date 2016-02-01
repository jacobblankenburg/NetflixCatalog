namespace NetflixCatalog
{
    public class Episode
    {
        public int EpisodeNumber;
        public int Duration;
        public string Name;
        public int Rating;

        public Episode(int episodenumber, int duration, string name, int rating)
        {
            this.EpisodeNumber = episodenumber;
            this.Duration = duration;
            this.Name = name;
            this.Rating = rating;
        }
    }
}