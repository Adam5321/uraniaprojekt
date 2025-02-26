using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roziamoziba
{
    public class Terem
    {
        public string Nev { get; set; }
        public int Ferohely { get; set; }

        public Terem(string nev)
        {
            Nev = nev;
            Ferohely = 80;
        }
    }
}
