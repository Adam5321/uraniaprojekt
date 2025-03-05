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
        public int[,] Ferohely { get; set; }
        public static Random r = new Random();

        public Terem(string nev, int n, int m)
        {
            Nev = nev;
            int[,] mat = new int[n,m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    int random = r.Next(0,3);
                    if (random == 0)
                    {
                        mat[i, j] = 1;
                    }
                    else
                    {
                        mat[i, j] = 0;
                    }
                }
            }
            Ferohely = mat;
        }
    }
}
