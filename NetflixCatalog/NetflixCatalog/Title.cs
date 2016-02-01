using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog
{
    public class Title
    {
        public string Name;
        public int? Rating;
        public ProgramGenres _genre;

        public Title()
        {
            this.Name = null;
            this.Rating = null;
            
            
        }
       public Title(string name ,int rating, string genres)
        {
            this.Name = name;
            this.Rating = rating;

        }

    }
}