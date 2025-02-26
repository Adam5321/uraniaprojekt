using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roziamoziba
{
    public class Vetites
    {
        public Film Film { get; set; }
        public DateTime Idopont { get; set; }
        public Terem Terem { get; set; }

        public Vetites(Film film, DateTime idopont, Terem terem)
        {
            Film = film;
            Idopont = idopont;
            Terem = terem;
        }
        public void vetitesJelenit()
        {
            Console.WriteLine(string.Format("{0} {1} {2}perc {3}", Idopont, Film.Nev, Film.Ido, Terem.Nev));
        }
        
    }
}
