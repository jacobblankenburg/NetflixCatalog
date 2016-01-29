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
        All, 
        Action, 
        Family,
        Comedy,
        Romatic,
        RomanticComedy,
        ActionComedy
    }
    public class Genres : IEnumerable 
    {
        public List<ProgramGenres> GenreofProgram;

        public Genres()
        {
            GenreofProgram = new List<ProgramGenres>();
            foreach (ProgramGenres programgnres in Enum.GetValues(typeof(ProgramGenres)));
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
