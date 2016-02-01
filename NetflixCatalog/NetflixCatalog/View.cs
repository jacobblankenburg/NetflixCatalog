using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog
{
    public class View
    {
        public void Display(List<ProgramGenres> GenreofProgram)
        {
            foreach (ProgramGenres programgenres in GenreofProgram)
            {
                Console.WriteLine(programgenres);
            }
        }
    }
}
