using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roziamoziba
{
    public class Film : IFilm
    {
        public string Nev { get; set; }
        public string Kategoria { get; set; }
        public string Rendezo { get; set; }
        public string Leiras { get; set; }
        public int Ido { get; set; }
        public string[] Szereplok { get; set; }
        public int Ev { get; set; }

        public Film(string nev, string kategoria, string rendezo, string leiras, int ido, string[] szereplok, int ev)
        {
            Nev = nev;
            Kategoria = kategoria;
            Rendezo = rendezo;
            Leiras = leiras;
            Ido = ido;
            Szereplok = szereplok;
            Ev = ev;
        }
        public override string ToString()
        {
            return string.Format("{0}, {1} perc, {2}", Nev, Ido, Ev);
        }
    }
}
