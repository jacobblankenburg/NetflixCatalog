using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog
{
    public class Movie : Title
    {
        public Movie(string Name, int Rating, Genres Genre)
        {
            name = Name;
            rating = Rating;
            genre = Genre;

        }

          public void MoviesToWatch()
        {
            this.name = "Joe Dirt";
            this.name = "Cars";
            this.name = "StepBrothers";
            this.name = "Ted";
            this.name = "Star Wars";

        }

    }
}
