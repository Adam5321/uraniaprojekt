using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roziamoziba
{
    public class Mozi
    {
        public MusorLista musorlista = new MusorLista();
        public void feladat()
        {
            musorlista.musorlistaGeneral();
        }
        public List<Film> katSzures(string sv)
        {
            List<Film> svfilmek = new List<Film>();
            if(sv != "Bármelyik")
            {
                for (int i = 0; i < musorlista.vetitesek.Count; i++)
                {
                    if (musorlista.vetitesek[i].Film.Kategoria == sv && (!svfilmek.Contains(musorlista.vetitesek[i].Film)))
                    {
                        svfilmek.Add(musorlista.vetitesek[i].Film);
                    }
                }
                return svfilmek;
            }
            else
            {
                for (int i = 0; i < musorlista.vetitesek.Count; i++)
                {
                    if (!svfilmek.Contains(musorlista.vetitesek[i].Film))
                    {
                        svfilmek.Add(musorlista.vetitesek[i].Film);
                    }
                }
                return svfilmek;
            }
        }
        public List<Film> vetSzures(string sv)
        {
            List<Film> svfilmek = new List<Film>();
            if (sv != "Bármelyik")
            {
                for (int i = 0; i < musorlista.vetitesek.Count; i++)
                {
                    string t = $"{musorlista.vetitesek[i].Idopont.Month}. {musorlista.vetitesek[i].Idopont.Day}.";
                    if (t == sv && (!svfilmek.Contains(musorlista.vetitesek[i].Film)))
                    {
                        svfilmek.Add(musorlista.vetitesek[i].Film);
                    }
                }
                return svfilmek;
            }
            else
            {
                for (int i = 0; i < musorlista.vetitesek.Count; i++)
                {
                    if (!svfilmek.Contains(musorlista.vetitesek[i].Film))
                    {
                        svfilmek.Add(musorlista.vetitesek[i].Film);
                    }
                }
                return svfilmek;
            }
        }
        
        
    }
}
