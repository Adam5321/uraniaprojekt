using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roziamoziba
{
    public class Filmfajlkezelo
    {
        public static List<Film> BeolvasFilmeket(string path)
        {
            List<Film> filmek = new List<Film>();
            StreamReader f = new StreamReader(path);
            while (!f.EndOfStream)
            {
                string[] line = f.ReadLine().Split(';');
                string sv = line[3].Replace(" ", "");
                string[] szereplok = sv.Split(',');
                filmek.Add(new Film(line[0], line[6], line[2], line[5], Convert.ToInt32(line[1]), szereplok, Convert.ToInt32(line[4])));
            }
            return filmek;
        }
    }
}
