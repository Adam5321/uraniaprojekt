using System;
using System.Collections.Generic;

namespace roziamoziba
{
    /// <summary>
    /// Class <c>MusorLista</c> Létrehoz egy műsorlistát.
    /// </summary>

    public class MusorLista
    {
        public List<Vetites> vetitesek;

        public MusorLista()
        {
            vetitesek = new List<Vetites>();
        }

        /// <summary>
        /// Method <c>Generalas</c> A paraméterek alapján feltölt egy listát a megadott filmekkel.
        /// </summary>
        /// <param name="filmek"></param> Filmek listája.
        /// <param name="elsonap"></param> Első vetítési nap.
        /// <param name="i"></param> Napok ciklusának változója.
        /// <param name="j"></param> Termek ciklusának változója.
        /// <param name="r"></param> Random szám.
        /// <param name="svlista"></param> Segéd lista.
        private void Generalas(List<Film> filmek, DateTime elsonap, int i, int j, ref Random r, ref List<Vetites> svlista)
        {
            int ora = 9, perc = 0, index = 0;
            Film elsofilm = filmek[r.Next(filmek.Count)];
            DateTime idopont = elsonap.AddDays(i).AddHours(ora);
            svlista.Add(new Vetites(elsofilm, idopont, new Terem(j+1+".Terem", 10+j+1,10+j+1)));
            Film film;

            while(true)
            {
                film = filmek[r.Next(filmek.Count)];
                int t = svlista[index].Film.Ido;
                int orak = t / 60;
                int percek = t - orak * 60;
                int szunet = r.Next(10, 16);
                ora += orak;
                perc += percek + szunet;

                if (perc >= 60)
                {
                    int sv = perc / 60;
                    ora += sv;
                    perc -= 60 * sv;
                }

                idopont = elsonap.AddDays(i).AddHours(ora).AddMinutes(perc);
                svlista.Add(new Vetites(film, idopont, new Terem(j+1+". Terem",10+j+1,10+j+1)));
                index++;
                if (ora + Math.Ceiling(Convert.ToDouble(film.Ido) / 60) >= 24)
                {
                    break;
                }
            }

            for (int x = 0; x < svlista.Count; x++)
                vetitesek.Add(svlista[x]);

            svlista.Clear();
        }

        /// <summary>
        /// Method <c>MusorlistaGeneral</c> A General metódus segítségével legenerál egy műsorlistát.
        /// </summary>

        public void MusorlistaGeneral()
        {
            List<Film> filmek = Filmfajlkezelo.BeolvasFilmeket("movies.txt");
            List<Vetites> svlista = new List<Vetites>();
            Random r = new Random();
            DateTime elsonap = new DateTime(2025, 2, 9);
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 3; j++)
                    Generalas(filmek, elsonap, i, j, ref r, ref svlista);
            }
        }

        public void musorKiir()
        {
            for(int i = 0; i < vetitesek.Count; i++)
                vetitesek[i].vetitesJelenit();
        }
    }
}
