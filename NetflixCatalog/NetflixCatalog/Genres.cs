using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog
{
    public enum ProgramGenres
    {
        All = 0,
        Action = 1,
        Family = 2,
        Comedy = 3,
        Romatic = 4,
        RomanticComedy = 5,
        ActionComedy = 6
    
    }
    public class Genres : IEnumerable
    {
        public ProgramGenres _genre;
        public List<ProgramGenres> GenreofProgram;

        public Genres()
        {
            GenreofProgram = new List<ProgramGenres>();
            foreach (ProgramGenres programggenres in Enum.GetValues(typeof(ProgramGenres))) ;
        }

        public IEnumerator GetEnumerator()
        {
            foreach (ProgramGenres programgenres in GenreofProgram)
            {
                yield return programgenres;
            }
        }
    }
}
