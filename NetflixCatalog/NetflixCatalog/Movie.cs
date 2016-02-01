using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog
{
    public class Movie : Title
    {
        public int Duration;
        
        public Movie(string name, int rating, int duration , ProgramGenres genres)
        {
            this.Name = name;
            this.Rating = rating;
            this.Duration = duration;
            ProgramGenres programGenres = genres;
         }
        public override string ToString()
        {
            return (Name + " has a rating of : " + Rating.ToString() + " and has a duration of : " + Duration.ToString() + " and the genre is : " + programGenres.ToString());
        }
    }
}
