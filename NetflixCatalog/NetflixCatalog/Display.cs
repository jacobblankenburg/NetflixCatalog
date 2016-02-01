using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog
{
    public class Display
    {
        Movie movie = new Movie("StarWars", 5, 156, ProgramGenres.Action);
        Movie movie2 = new Movie("Joe Dirt", 3, 134, ProgramGenres.Comedy);
        Movie movie3 = new Movie("Cars", 5, 143, ProgramGenres.Family);
        Movie movie4 = new Movie("DieHard", 4, 165, ProgramGenres.ActionComedy);

        

        TvShow tvshow = new TvShow("Game of Thrones", ProgramGenres.Action);
        TvShow tvshow2 = new TvShow("Arrow", ProgramGenres.ActionComedy);
        TvShow tvshow3 = new TvShow("Family Guy", ProgramGenres.Comedy);


        public void Consolewrite()
        {
            Console.WriteLine(movie);
            Console.WriteLine(movie2);
            Console.WriteLine(movie3);
            Console.WriteLine(movie4);
            Console.ReadLine();
            Console.WriteLine(tvshow);
            Console.WriteLine(tvshow2);
            Console.WriteLine(tvshow3);
            

        }

    }
}
