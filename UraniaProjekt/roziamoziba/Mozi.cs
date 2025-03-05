using System.Collections.Generic;

namespace roziamoziba
{
    public class Mozi
    {
        public MusorLista musorlista = new MusorLista();

        private void Szures1(string sv, ref List<Film> svfilmek)
        {
            for (int i = 0; i < musorlista.vetitesek.Count; i++)
            {
                if (musorlista.vetitesek[i].Film.Kategoria == sv && (!svfilmek.Contains(musorlista.vetitesek[i].Film)))
                    svfilmek.Add(musorlista.vetitesek[i].Film);
            }
        }

        private void Szures2(int i, string sv, ref List<Film> svfilmek)
        {
            string t = $"{musorlista.vetitesek[i].Idopont.Month}. {musorlista.vetitesek[i].Idopont.Day}.";
            if (t == sv && (!svfilmek.Contains(musorlista.vetitesek[i].Film)))
                svfilmek.Add(musorlista.vetitesek[i].Film);
        }

        private void Mindegyik(ref List<Film> svfilmek)
        {
            for (int i = 0; i < musorlista.vetitesek.Count; i++)
            {
                if (!svfilmek.Contains(musorlista.vetitesek[i].Film))
                    svfilmek.Add(musorlista.vetitesek[i].Film);
            }
        }

        public void feladat()
        {
            musorlista.MusorlistaGeneral();
        }


        /// <summary>
        /// Method <c>katSzures</c> Szűrés kategória szerint
        /// </summary>
        /// <param name="sv"></param> Mi alapján szűrjön.
        /// <returns>A filmek lista</returns>

        public List<Film> katSzures(string sv)
        {
            List<Film> svfilmek = new List<Film>();
            if(sv != "Bármelyik") Szures1(sv, ref svfilmek);
            else Mindegyik(ref svfilmek);
            return svfilmek;
        }

        /// <summary>
        /// Method <c>vetSzures</c> Szűrés vetitési időpont szerint.
        /// </summary>
        /// <param name="sv"></param> Mi alapján szűrjön.
        /// <returns>A filmek lista</returns>

        public List<Film> vetSzures(string sv)
        {
            List<Film> svfilmek = new List<Film>();
            if (sv != "Bármelyik")
            {
                for (int i = 0; i < musorlista.vetitesek.Count; i++)
                    Szures2(i, sv, ref svfilmek);
            }
            else Mindegyik(ref svfilmek);
            return svfilmek;
        }
        public List<Vetites> vetSzures2(string sv)
        {
            List<Vetites> svvetitesek = new List<Vetites>();
            for (int i = 0; i < musorlista.vetitesek.Count; i++)
            {
                string t = $"{musorlista.vetitesek[i].Idopont.Month}. {musorlista.vetitesek[i].Idopont.Day}.";
                if (t == sv && !svvetitesek.Contains(musorlista.vetitesek[i]))
                {
                    svvetitesek.Add(musorlista.vetitesek[i]);
                }
            }
            return svvetitesek;
        }
    }
}
