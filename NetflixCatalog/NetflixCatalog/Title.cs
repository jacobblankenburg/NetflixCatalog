using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog
{
    public class Title
    {
        public string name;
        public int? rating;
        public Genres genre;


        public Title()
        {
            this.name = null;
            this.rating = null;
            this.genre = null;
        }
       // public 

    }
}