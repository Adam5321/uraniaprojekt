using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roziamoziba
{
    public class Mozi
    {
        List<Film> filmek = Filmfajlkezelo.BeolvasFilmeket("movies.txt");
        MusorLista musorlista = new MusorLista();
        public void feladat()
        {
            musorlista.musorlistaGeneral();
            musorlista.musorKiir();
            /*
            Console.WriteLine("\n\n\n");
            List<Film> katszuro = katSzures("Dráma");
            for(int i = 0; i < katszuro.Count; i++)
            {
                Console.WriteLine(katszuro[i].ToString());
            }
            Console.WriteLine("\n\n\n");

            List<Film> vetszuro = vetSzures(new DateTime(2025, 2, 11).Date);
            for (int i = 0; i < vetszuro.Count; i++)
            {
                Console.WriteLine(vetszuro[i].ToString());
            }*/
        }
        public List<Film> katSzures(string sv)
        {
            List<Film> svfilmek = new List<Film>();
            for(int i = 0; i < filmek.Count; i++)
            {
                if (filmek[i].Kategoria == sv)
                {
                    svfilmek.Add(filmek[i]);
                }
            }
            return svfilmek;
        }
        public List<Film> vetSzures(DateTime sv)
        {
            List<Film> svfilmek = new List<Film>();
            for (int i = 0; i < musorlista.vetitesek.Count; i++)
            {
                if (musorlista.vetitesek[i].Idopont.Date == sv)
                {
                    svfilmek.Add(musorlista.vetitesek[i].Film);
                }
            }
            return svfilmek;
        }
        
        
    }
}
