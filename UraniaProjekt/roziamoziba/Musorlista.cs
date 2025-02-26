using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace roziamoziba
{
    public class MusorLista
    {
        public List<Vetites> vetitesek;
        public List<Terem> termek;

        
        public MusorLista()
        {
            vetitesek = new List<Vetites>();
            termek = new List<Terem>(){new Terem("1. Terem"), new Terem("2. Terem"), new Terem("3. Terem")};
        }
        
        public void musorlistaGeneral()
        {
            List<Film> filmek = Filmfajlkezelo.BeolvasFilmeket("movies.txt");
            List<Vetites> svlista = new List<Vetites>();
            Random r = new Random();
            DateTime elsonap = new DateTime(2025, 2, 9);
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int oraglobal = 9;
                    int percglobal = 0;
                    int index = 0;
                    Film elsofilm = filmek[r.Next(filmek.Count)];
                    DateTime idopont = elsonap.AddDays(i).AddHours(oraglobal);
                    svlista.Add(new Vetites(elsofilm, idopont, termek[j]));
                    while (true)
                    {
                        Film film = filmek[r.Next(filmek.Count)];
                        int orak = svlista[index].Film.Ido / 60;
                        int perc = svlista[index].Film.Ido - orak * 60;
                        int szunet = r.Next(10, 16);
                        oraglobal += orak;
                        percglobal += perc + szunet;
                        if (percglobal >= 60)
                        {
                            int sv = percglobal / 60;
                            oraglobal += sv;
                            percglobal = percglobal - 60 * sv;
                        }

                        idopont = elsonap.AddDays(i).AddHours(oraglobal).AddMinutes(percglobal);
                        svlista.Add(new Vetites(film, idopont, termek[j]));
                        index++;
                        if (oraglobal + Math.Ceiling(Convert.ToDouble(film.Ido) / 60) >= 24)
                        {
                            break;
                        }
                    }
                    for (int x = 0; x < svlista.Count; x++)
                    {
                        vetitesek.Add(svlista[x]);
                    }
                    svlista.Clear();

                }
            }
        }
        public void musorKiir()
        {
            for(int i = 0; i < vetitesek.Count; i++)
            {
                vetitesek[i].vetitesJelenit();
            }
        }
        

    }
}
